import React from 'react';
import { Link } from 'react-router-dom';
import './NavMenu.css';

const Navbar = () => {
    return (
        <nav className="navbar">
            <ul className="nav-list">
                <li className="nav-item">
                    <Link to="/vessel">Vessel</Link>
                </li>
                <li className="nav-item">
                    <Link to="/departament">Departament</Link>
                </li>
            </ul>
        </nav>
    );
};

export default Navbar;