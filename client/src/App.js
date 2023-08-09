import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import NavMenu from './components/NavMenu';
import Vessel from './components/Vessel';
import Departament from './components/Departament';
import Home from './components/Home';

function App() {
    return (
        <Router>
            <div>
                <NavMenu />
                <Routes>
                    <Route path="/Home" element={<Home />} />
                    <Route path="/vessel" element={<Vessel />} />
                    <Route path="/departament" element={<Departament />} />
                </Routes>
            </div>
        </Router>
    );
}

export default App;
