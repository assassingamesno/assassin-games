import React from "react";
import { Link } from "react-router-dom";
import ag_logo from "../../assets/ag_logo.svg";

import "../../styling/components/Sidebar.scss";
import "../../styling/components/Navbar.scss";

export default function Navbar() {
  return (
    <div className="router-navbar">
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
