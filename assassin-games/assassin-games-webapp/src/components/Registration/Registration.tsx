import React from "react";

import { useSelector } from "react-redux";
import { reduxStore } from "../../utilities/Interfaces";

import "../../styling/components/Registration.scss";

import RegistrationNavbar, { RegLandingBar } from "./RegistrationNavbar";
import RegistrationPersonalia from "./RegistrationPersonalia";
import RegistrationLocation from "./RegistrationLocation";
import RegistrationStudent from "./RegistrationStudent";
import RegistrationPicture from "./RegistrationPicture";
import RegistrationPayment from "./RegistrationPayment";
import { RegLanding, RegSummary } from "./RegSummary";
import { RegSummaryBar } from "./RegistrationNavbar";

export default function Registration() {
  const RegStore = useSelector((state: reduxStore) => state.registration);

  var pages = {
    1: <RegistrationPersonalia Personalia={RegStore.Personalia} />,
    2: <RegistrationStudent Student={RegStore.Student} />,
    3: <RegistrationLocation Location={RegStore.Location} />,
    4: <RegistrationPicture />,
    5: <RegistrationPayment />,
    6: <RegSummary Registration={RegStore} />,
  };

  let bar = null;
  switch (RegStore.CurPage) {
    case 6:
      bar = <RegSummaryBar Registration={RegStore} />
      break;

    default:
      bar = <RegistrationNavbar CurPage={RegStore.CurPage} TotPage={RegStore.TotPage} />
      break;
  }

  return (
    <div className="router-page">
      <div className="registrationWrapper">
        {bar}
        {pages[RegStore.CurPage]}
      </div>
    </div>
  );
}

export function RegistrationLanding() {

  const RegStore = useSelector((state: reduxStore) => state.registration);

  return (
    <div className="router-page">
      <div className="registrationWrapper">
        <RegLandingBar />
        <RegLanding Personalia={RegStore.Personalia} />
      </div>
    </div>
  );
}
