import React from "react";
import { fallDown as Menu } from "react-burger-menu";
import { Link } from "react-router-dom";
import ag_logo from "../assets/ag_logo.svg";
import burger from "../assets/burger_menu.svg";

import "../styling/components/BurgerMenu.scss";

export default function Navbar() {
    return (
        <nav className="router-navbar">
            <div className="router-navbutton logo">
                <Link to="/">
                    <img src={ag_logo} width="50px" height="50px" alt="AG_logo"/>
                </Link>
            </div>
            <h1 className="lusitana"></h1>
            <div className="router-navbutton burgermenu">
                <Menu customBurgerIcon={<img src={burger} alt="burger_menu"/>}>
                    <Link className="link" to="/">Home</Link>
                    <Link className="link" to="/players">Players</Link>
                    <Link className="link" to="/about">About</Link>
                </Menu>
            </div>
        </nav>
    )
}
