import React, { useState } from "react";
import { useDispatch } from "react-redux";
import {
  addHangout,
  removeHangout,
  setAddress,
  setStore,
} from "../../store/registration/actions";
import { Location } from "../../utilities/Interfaces";
import FormField from "./FormField";
import FormTag from "./FormTag";
import Tag from "./Tag";

export default function RegistrationLocation(props: { Location: Location }) {

  const dispatch = useDispatch();

  const onAddressChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    dispatch(setAddress(event.target.value));
  };

  const onStoreChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    dispatch(setStore(event.target.value));
  };

  const onTagDelete = (tagValue: string) => {
    dispatch(removeHangout(tagValue));
  };

  const onTagSubmit = (tagValue: string) => {
    dispatch(addHangout(tagValue))
  }

  const renderTags = props.Location.hangouts.map((hangout: string) => {
    return <Tag value={hangout} onDelete={onTagDelete} />;
  });

  return (
    <div className="regFormWrapper">
      <h1 className="regFormTitle">STEDSINFO</h1>
      <p className="regFormDesc">
        Din adresse vil kun deles med din snikmorder. <br />
        Nærbutikk og vankesteder vil bli offentliggjort som del av din profil.
      </p>
      <div className="regFormForm">
        <FormField
          type="text"
          value={props.Location.address}
          title="ADRESSE"
          changeHandler={onAddressChange}
        />
        <FormField
          type="text"
          value={props.Location.store}
          title="NÆRBUTIKK"
          changeHandler={onStoreChange}
        />
        <FormTag title="VANKESTEDER" dispatcher={onTagSubmit} type="text" />

        <div className="TagContainer">{renderTags}</div>
      </div>
    </div>
  );
}
