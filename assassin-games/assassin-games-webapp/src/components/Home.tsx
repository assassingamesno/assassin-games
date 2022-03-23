import React from 'react'

// Component imports
import Countdown from './Countdown'

// CSS import
import '../styling/components/Router.scss'

//Graphics import
//import CalmFocused from '../assets/img/calm_focused_transp.png'
import Iris from '../assets/img/IrisTorso.png'
import Gress from '../assets/img/GressTorso.png'
import Eucalyptus from '../assets/img/EucalyptusTorso.png'
import Lovehearts from '../assets/img/LoveheartsTorso.png'
import Sandmonster from '../assets/img/SandmonsterTorso.png'
import igIcon from '../assets/svg/instaLogoNeg.svg'

export default function Home() {

    let countdownTitle = "registrering åpner om" //TODO: finn en måte å gjøre sånn at denne kan oppdateres for arrangør


    return (
        <>
            <div className="countdownContainer">
                <div>{countdownTitle.toUpperCase()}</div>
                <Countdown seasonStart='04/04/2022 00:00:00'></Countdown>
            </div >
            <div className="router-page">
                <div id="homeAssassinContainer">
                    <img src={Eucalyptus} alt="euca-assassin" />
                    <img src={Sandmonster} alt="love-assassin" />
                    <img src={Lovehearts} alt="love-assassin" />
                    <img src={Iris} alt="iris-assassin" />
                    <img src={Gress} alt="grass-assassin" />
                </div>
                <h1 className="lusitana">ASSASSIN GAMES</h1>
                <InstaHandle title="ag.trondheim" />
            </div >
        </>
    )
}

interface props {
    title: string,
}

function InstaHandle(props: props) {
    return (
        <div className="handleContainer" onClick={() => { window.open("https://www.instagram.com/" + props.title + "/", "_blank") }}>
            <img src={igIcon} alt='neg-ig-icon' />
            <div>{props.title.toUpperCase()}</div>
        </div>
    )

}
