import React, { useEffect, useState } from 'react'

// Component imports
import Countdown from './Countdown'

// CSS import
import '../styling/components/Router.scss'

//Graphics import
//import CalmFocused from '../assets/img/calm_focused_transp.png'
import Iris from '../assets/svg/homepage_graphics/irisTorso.svg'
import Gress from '../assets/svg/homepage_graphics/gressTorso.svg'
import Eucalyptus from '../assets/svg/homepage_graphics/eucalyptusTorso.svg'
import Lovehearts from '../assets/svg/homepage_graphics/loveheartsTorso.svg'
import Sandmonster from '../assets/svg/homepage_graphics/sandmonsterTorso.svg'
import igIcon from '../assets/svg/instaLogoNeg.svg'
import combinedTorsos from '../assets/svg/homepage_graphics/combinedTorso.svg'

export default function Home() {

    let countdownTitle = "registrering åpner om" //TODO: finn en måte å gjøre sånn at denne kan oppdateres for arrangør
    const [width, setWidth] = useState(window.innerWidth)

    useEffect(() => {
        function updateWidth() {
            setWidth(window.innerWidth)
        }

        window.addEventListener('resize', updateWidth)
    })


    return (
        <>
            <div className="countdownContainer">
                <div>{countdownTitle.toUpperCase()}</div>
                <Countdown seasonStart='04/04/2022 00:00:00 +0200'></Countdown>
            </div >
            <div className="router-page">
                <div id="homeAssassinContainer">
                    {
                        (width > 968) ? (
                            <>
                                <img src={Eucalyptus} alt="euca-assassin" />
                                <img src={Sandmonster} alt="love-assassin" />
                                <img src={Lovehearts} alt="love-assassin" />
                                <img src={Iris} alt="iris-assassin" />
                                <img src={Gress} alt="grass-assassin" />
                            </>) :
                            (
                                <img src={combinedTorsos} alt="assassin-torsos" />
                            )
                    }

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
