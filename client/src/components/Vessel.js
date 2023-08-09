import React, { useState, useEffect } from "react";
import axios from 'axios';
import './Vessel.css';

const Vessel = () => {
    const [vessels, setvessels] = useState([]);
    const [name, setname] = useState("");
    const [type, settype] = useState("");
    const [buildAt, setbuildAt] = useState("");

    useEffect(() => {
        getVessels();
    }, []);

    async function getVessels() {
        try {
            const response = await axios.get("Vessel/GetVessels");
            setvessels(response.data);
        } catch (error) {
            console.error(error);
        }
    }

    async function addVessel(event) {
        event.preventDefault();
        try {
            await axios.post("Vessel/AddVessel", {
                name: name,
                type: type,
                buildat: buildAt,
            });
            alert("Vessel added");

            setname("");
            settype("");
            setbuildAt("");
            getVessels();
        } catch (error) {
            alert(error);
        }
    }

    return (
        <div className="container">
            <h1>Vessels</h1>
            <div className="row">
                <form>
                    <div className="form-group">
                        <label>Vessel Name</label>
                        <input
                            type="text"
                            className="form-control"
                            id="name"
                            value={name}
                            onChange={(event) => setname(event.target.value)}
                        />
                    </div>
                    <div className="form-group">
                        <label>Vessel Type</label>
                        <input
                            type="text"
                            className="form-control"
                            id="type"
                            value={type}
                            onChange={(event) => settype(event.target.value)}
                        />
                    </div>
                    <div className="form-group">
                        <label>Vessel BuildAt</label>
                        <input
                            type="date"
                            className="form-control"
                            id="buildat"
                            value={buildAt}
                            onChange={(event) => setbuildAt(event.target.value)}
                        />
                    </div>
                    <div>
                        <button className="btn btn-primary" onClick={addVessel}>
                            Add
                        </button>
                    </div>
                </form>
            </div>
            <div className="row">
                <div className="col-12">
                    <table className="table table-bordered table-stripped">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Name</th>
                                <th>Type</th>
                                <th>BuildAt</th>
                                <th>Departaments</th>
                            </tr>
                        </thead>
                        <tbody>
                            {vessels.map(vessel => (
                                <tr key={vessel.id}>
                                    <td>{vessel.id}</td>
                                    <td>{vessel.name}</td>
                                    <td>{vessel.type}</td>
                                    <td>{vessel.buildAt.substring(0, 10)}</td>
                                    <td>{vessel.departaments.map(d => d.name).join(", ")}</td>
                                </tr>
                            ))}
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    );
};

export default Vessel;
