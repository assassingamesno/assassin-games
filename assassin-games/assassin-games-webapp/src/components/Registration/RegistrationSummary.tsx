import React from "react";
import { useDispatch } from "react-redux";
import { setName } from "../../store/registration/actions";
import { registration } from "../../utilities/Interfaces";
import FormField from "./FormField";

export default function RegistrationSummary(props: registration) {
  const dispatch = useDispatch();

  const onNameChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    dispatch(setName(event.target.value));
  };

  return (
    <div className="regFormWrapper">
      <h1 className="regFormTitle">OPPSUMMERING</h1>
      <p className="regFormDesc">
        Se gjennom og endre eller legg til hvis noe mangler
      </p>
      <div>
        <FormField
          type="text"
          title="FULLT NAVN"
          value={props.Personalia.name}
          changeHandler={onNameChange}
        />
      </div>
    </div>
  );
}
