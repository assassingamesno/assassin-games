import { Link } from "react-router-dom";
import { slide as Menu } from "react-burger-menu";
import burgerMenuIcon from "../../assets/svg/burgerMenuIcon.svg"
import instaHandle from "../../assets/img/instaIconDark.png"

export default function Sidebar() {
  return (
    <div>
      <nav>
        <Menu width={"240px"} pageWrapId={"page-wrap"} outerContainerId={"App"} customBurgerIcon={<img src={burgerMenuIcon} alt="menu-icon" />} right>
          <Link className="menu-item" to={"/"}>
            HOVEDSIDE
          </Link>
          <Link className="menu-item" to={"/rules"}>
            REGLER
          </Link>


          <div className="menu-item">
            <img className="handleIcon" src={instaHandle} alt="@ag.trondheim" width="24px" onClick={() => { window.open("https://www.instagram.com/ag.trondheim", "_blank") }}/>
          </div>
          {
            /*
              <Link className="menu-item" to={"/players"}>
                Spillere
              </Link>
              <Link className="menu-item" to={"/about"}>
                Om oss
              </Link>
            */
          }
        </Menu>
      </nav>
    </div>
  );
}
