import { Link } from "react-router-dom";
import { slide as Menu } from "react-burger-menu";
import burgerMenuIcon from "../../assets/svg/burgerMenuIcon.svg"
import instaHandle from "../../assets/img/instaIconDark.png"
import { useState } from "react";

export default function Sidebar() {

  const [open, setOpen] = useState(false);

  const handleOpen = () => {
    setOpen(!open);
  }



  return (
    <div>
      <nav>
        <Menu isOpen={open} onClose={handleOpen} onOpen={handleOpen} width={"240px"} pageWrapId={"page-wrap"} outerContainerId={"App"} customBurgerIcon={<img src={burgerMenuIcon} alt="menu-icon" />} right>
          <Link className="menu-item" to={"/"} onClick={()=>{setOpen(false)}}>
            HOVEDSIDE
          </Link>
          <Link className="menu-item" to={"/rules"} onClick={()=>{setOpen(false)}}>
            REGLER
          </Link>
          <Link className="menu-item" to={"/awards"} onClick={()=>{setOpen(false)}}>
            PREMIER
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
