import React from "react";
import FormPicture from "./FormPicture";

export default function RegistrationPayment() {
  return (
    <div className="regFormWrapper">
      <h1 className="regFormTitle">BETALING</h1>
      <p className="regFormDesc">
        Betalingen vil gå til en felles pott som førsteplassen kan kose seg med.
        Legg til screenshot av betaling.
      </p>
      <FormPicture
        title="BETALINGSBEVIS"
        imageID="paymentProof"
        onChange={() => {
          console.log("hello world!");
        }}
      />
    </div>
  );
}
