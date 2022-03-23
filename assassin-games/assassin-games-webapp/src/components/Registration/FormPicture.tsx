import React from "react";

import pictureAdd from "../../assets/svg/pictureAdd.svg";

interface props {
  title: string;
  imageID: string;
  onChange: (event: React.ChangeEvent<HTMLInputElement>) => void;
}

export default function FormPicture(props: props) {
  return (
    <div className="FormField">
      <div className="FormFieldTitle">{props.title}</div>
      <label htmlFor={props.imageID}>
        <div className="FormPictureContainer">
          <div>
            <img src={pictureAdd} alt="+" />
          </div>
        </div>
      </label>
      <input
        type="file"
        id={props.imageID}
        className="FormPictureInput"
        onChange={props.onChange}
        accept="image/png, image/jpeg"
      />
    </div>
  );
}
