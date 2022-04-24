import React, { useEffect, useState } from "react";

// Component imports
import Countdown from "./Countdown";

// CSS import
import "../styling/components/Router.scss";

//Graphics import
//import CalmFocused from '../assets/img/calm_focused_transp.png'
import Iris from "../assets/img/homepage_graphics/irisTorso.png";
import Gress from "../assets/img/homepage_graphics/gressTorso.png";
import Eucalyptus from "../assets/img/homepage_graphics/eucalyptusTorso.png";
import Lovehearts from "../assets/img/homepage_graphics/loveheartsTorso.png";
import Sandmonster from "../assets/img/homepage_graphics/sandmonsterTorso.png";
import igIcon from "../assets/svg/instaLogoNeg.svg";
import combinedTorsos from "../assets/img/homepage_graphics/combinedTorso.png";
import gameStart from "../assets/img/homepage_graphics/gameStart.png";
import huntStart from "../assets/img/homepage_graphics/huntStart.png";
import huntAttack from "../assets/img/homepage_graphics/huntAttack.png";
import newTarget from "../assets/img/homepage_graphics/newTarget.png";
import huntHerjer from "../assets/img/homepage_graphics/huntHerjer.png";
import instaUpdates from "../assets/img/homepage_graphics/instaUpdates.png";
import awardsDuring from "../assets/img/homepage_graphics/awardsDuring.png";
import winner from "../assets/img/homepage_graphics/winner.png";
import flyingAssassin from "../assets/img/homepage_graphics/flyingAssassin.png";

export default function Home() {
  let countdownTitle = "registrering åpner om"; //TODO: finn en måte å gjøre sånn at denne kan oppdateres for arrangør
  const [width, setWidth] = useState(window.innerWidth);

  useEffect(() => {
    function updateWidth() {
      setWidth(window.innerWidth);
    }

    window.addEventListener("resize", updateWidth);
  });

  return (
    <>
      <div className="countdownContainer">
        <div>{countdownTitle.toUpperCase()}</div>
        <Countdown seasonStart="04/04/2022 12:00:00 +0200"></Countdown>
      </div>
      <div className="router-page">
        <div id="homeAssassinContainer">
          {width > 968 ? (
            <>
              <img
                src={Eucalyptus}
                alt="euca-assassin"
                width="174px"
                height="147px"
              />
              <img
                src={Sandmonster}
                alt="love-assassin"
                width="174px"
                height="147px"
              />
              <img
                src={Lovehearts}
                alt="love-assassin"
                width="174px"
                height="147px"
              />
              <img
                src={Iris}
                alt="iris-assassin"
                width="174px"
                height="147px"
              />
              <img
                src={Gress}
                alt="grass-assassin"
                width="174px"
                height="147px"
              />
            </>
          ) : (
            <img src={combinedTorsos} alt="assassin-torsos" width="348px" />
          )}
        </div>
        <h1 className="lusitana">ASSASSIN GAMES</h1>
        <InstaHandle title="ag.trondheim" />
        <div className="WTContainer">
          <div className="item1">
            <WalkthroughGraphic title="" graphic={flyingAssassin} />
          </div>
          <div className="item2">
            <div className="WTTitleBox">
              <h1 className="lusitana">En forklaring av spillets gang</h1>
            </div>
            <div id="WTIngress">
              Assassin Games er et frivillig initiativ
              <br />
              drevet av og for studenter i Trondheim.
              <br />
              Fra 24. april er ingen steder trygge.
              <br />
              Trondheim transformeres til en slagmark
              <br />
              hvor kun den sterkeste overlever.
            </div>
          </div>
        </div>
        <div className="WTGraphicWrapper">
          <div className="item3">
            <WalkthroughGraphic
              title="Alle spillere får tildelt én vannpistol og ett target"
              graphic={gameStart}
            />
          </div>
          <div className="item4">
            <WalkthroughGraphic title="Jakten har begynt" graphic={huntStart} />
          </div>
          <div className="item5">
            <WalkthroughGraphic
              title="Du slår til på riktig tidspunkt"
              graphic={huntAttack}
            />
          </div>
          <div className="item6">
            <WalkthroughGraphic
              title="Du får nytt target"
              graphic={newTarget}
            />
          </div>
          <div className="item7">
            <WalkthroughGraphic title="Jakten herjer" graphic={huntHerjer} />
          </div>
          <div className="item8">
            <WalkthroughGraphic
              title="Oppdatering på instagram"
              graphic={instaUpdates}
            />
          </div>
          {/* <div>
            {width > 1000 ? (
              <>
                <div id="tittelItem9">
                  <p>Premier underveis</p>
                </div>
                <div className="item9">
                  <WalkthroughGraphic title="" graphic={awardsDuring} />
                </div>
              </>
            ) : (
              <>
                <div className="item9">
                  <WalkthroughGraphic
                    title="Premier underveis"
                    graphic={awardsDuring}
                  />
                </div>
              </>
            )}
          </div> */}
          <div className="WTGraphicTitle">
            <h2>Premier underveis</h2>
          </div>
          <div className="item9">
            <WalkthroughGraphic title="" graphic={awardsDuring} />
          </div>
          <div className="item10">
            <WalkthroughGraphic
              title="Den siste som står igjen løfter pokalen"
              graphic={winner}
            />
          </div>
        </div>
      </div>
      <div className="Footer">
        {/* <p>Denne nettsiden er laget av Kodeklubben <sup>TM</sup></p> */}
      </div>
    </>
  );
}

interface props {
  title: string;
}

function InstaHandle(props: props) {
  return (
    <div
      className="handleContainer"
      onClick={() => {
        window.open("https://www.instagram.com/" + props.title + "/", "_blank");
      }}
    >
      <img src={igIcon} alt="neg-ig-icon" />
      <div>{props.title.toUpperCase()}</div>
    </div>
  );
}

interface WTGprops {
  title: string;
  graphic: string;
}

function WalkthroughGraphic(props: WTGprops) {
  return (
    <div className="WTGraphicContainer">
      <h2 className="WTGraphicTitle">{props.title}</h2>
      <img
        className="WTGraphic"
        src={props.graphic}
        alt="Walkthrough graphic"
      />
    </div>
  );
}
