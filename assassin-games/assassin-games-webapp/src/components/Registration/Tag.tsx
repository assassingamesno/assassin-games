import React from "react";

import tagDelete from "../../assets/svg/tagDelete.svg";

interface props {
  value: string;
  onDelete: (event: string) => void;
}

export default function Tag(props: props) {
  return (
    <div className="Tag">
      <div>{props.value}</div>
      <button
        id="TagDelete"
        onClick={() => {
          props.onDelete(props.value);
        }}
      >
        <img src={tagDelete} alt="X" />
      </button>
    </div>
  );
}
