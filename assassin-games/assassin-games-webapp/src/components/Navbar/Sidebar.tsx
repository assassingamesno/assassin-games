import { Link } from "react-router-dom";
import { slide as Menu } from "react-burger-menu";
import burgerMenuIcon from "../../assets/svg/burgerMenuIcon.svg"

export default function Sidebar() {
  return (
    <div>
      <nav>
        <Menu width={"15%"} pageWrapId={"page-wrap"} outerContainerId={"App"} customBurgerIcon={<img src={burgerMenuIcon} alt="menu-icon" />} right>
          <Link className="menu-item" to={"/"}>
            Hovedside
          </Link>
          <Link className="menu-item" to={"/players"}>
            Spillere
          </Link>
          <Link className="menu-item" to={"/about"}>
            Om oss
          </Link>
        </Menu>
      </nav>
    </div>
  );
}
