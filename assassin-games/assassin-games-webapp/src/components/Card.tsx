//src/components/Card.js
//<img className="br-100 h3 w3 dib" alt={person.name} src={process.env.PUBLIC_URL + person.imgPath} />

import React from "react";
import image from "../assets/img/1.jpg";

function Card({ person }) {
  return (
    <div className="">
      <img className="" alt={person.name} src={image} width={40} height={40} />
      <div>
        <h2>{person.name}</h2>
        <p>{person.email}</p>
      </div>
    </div>
  );
}

export default Card;
