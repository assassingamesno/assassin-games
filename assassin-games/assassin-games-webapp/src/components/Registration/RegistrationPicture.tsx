import React from "react";
import doAssassinPic from "../../assets/img/AssassinPicPlaceholder.png";
import no1 from "../../assets/img/AssassinPicNo1.png";
import no2 from "../../assets/img/AssassinPicNo2.png";
import no3 from "../../assets/img/AssassinPicNo3.png";
import FormPicture from "./FormPicture";

export default function RegistrationPicture() {
  return (
    <div className="regFormWrapper">
      <h1 className="regFormTitle">ASSASSINBILDE</h1>
      <p className="regFormDesc">
        Ta bilde rett forfra. Det vil bli brukt på insta og nettsiden.
      </p>

      <div className="assassinPicGuidelineWrapper">
        <div>
          <div className="assassinPicGuideline" id="apgYes">
            <div className="FormFieldTitle">YES</div>
            <img
              className="assassinPicGuidelinePic"
              src={doAssassinPic}
              alt="yes"
            />
          </div>
        </div>
        <div id="assassinPicGuidelineNos">
          <div className="assassinPicGuideline">
            <div className="FormFieldTitle">NO</div>
            <img className="assassinPicGuidelinePic" src={no1} alt="no1" />
          </div>

          <div className="assassinPicGuideline">
            <div className="FormFieldTitle">NO</div>
            <img className="assassinPicGuidelinePic" src={no2} alt="no2" />
          </div>

          <div className="assassinPicGuideline">
            <div className="FormFieldTitle">NO</div>
            <img className="assassinPicGuidelinePic" src={no3} alt="no3" />
          </div>
        </div>
      </div>

      <FormPicture
        title="BILDE"
        imageID="AssassinPic"
        onChange={() => console.log("Picture changed")}
      />
    </div>
  );
}
