import React from "react";

// Importing components
import { Link } from "react-router-dom";
import Sidebar from "./Sidebar";

// Importing graphics
import ag_logo from "../../assets/ag_logo.svg";

// Importing styling
import "../../styling/components/Sidebar.scss";
import "../../styling/components/Navbar.scss";

export default function Navbar() {
  return (
    <div className="router-navbar">
      <div className="router-navbutton sidebar">
        <Sidebar />
      </div>
      <div className="router-navbutton logo">
        <nav className="router-navbutton">
          <Link to="/">
            <img src={ag_logo} width="50px" height="50px" alt="ag_logo" />
          </Link>
        </nav>
      </div>
    </div>
  );
}
