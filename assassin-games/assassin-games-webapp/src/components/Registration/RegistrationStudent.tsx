import React from "react";

import { useDispatch } from "react-redux";

import FormSelect from "./FormSelect";
import FormPicture from "./FormPicture";

import {
  classOptions,
  studyOptions,
  campusOptions,
} from "../../data/regoptions";
import {
  setCampus,
  setClass,
  setStudy,
} from "../../store/registration/actions";
import { Student } from "../../utilities/Interfaces";

export default function RegistrationStudent(props: { Student: Student }) {
  const dispatch = useDispatch();

  const onPictureUpload = (event: React.ChangeEvent<HTMLInputElement>) => {
    console.log(event.target.value);
  };

  const classChange = (event: React.ChangeEvent<HTMLSelectElement>) => {
    dispatch(setClass(+event.target.value));
  };

  const studyChange = (event: React.ChangeEvent<HTMLSelectElement>) => {
    dispatch(setCampus(event.target.value));
  };

  const campusChange = (event: React.ChangeEvent<HTMLSelectElement>) => {
    dispatch(setStudy(event.target.value));
  };

  return (
    <div className="regFormWrapper">
      <h1 className="regFormTitle">STUDENTINFO</h1>
      <p className="regFormDesc">
        For å være med på AG er du nødt til å være student.
      </p>
      <FormPicture
        title="STUDENTBEVIS"
        onChange={onPictureUpload}
        imageID="studentProof"
      />
      <FormSelect
        value={props.Student.class}
        title="KLASSE"
        options={classOptions}
        onChange={classChange}
      />
      <FormSelect
        value={props.Student.campus}
        title="CAMPUS"
        options={campusOptions}
        onChange={studyChange}
      />
      <FormSelect
        value={props.Student.study}
        title="STUDIERETNING"
        options={studyOptions}
        onChange={campusChange}
      />
    </div>
  );
}
