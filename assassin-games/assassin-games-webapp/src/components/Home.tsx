import React, { useEffect, useState } from 'react'

// Component imports
import Countdown from './Countdown'

// CSS import
import '../styling/components/Router.scss'

//Graphics import
//import CalmFocused from '../assets/img/calm_focused_transp.png'
import Iris from '../assets/img/homepage_graphics/irisTorso.png'
import Gress from '../assets/img/homepage_graphics/gressTorso.png'
import Eucalyptus from '../assets/img/homepage_graphics/eucalyptusTorso.png'
import Lovehearts from '../assets/img/homepage_graphics/loveheartsTorso.png'
import Sandmonster from '../assets/img/homepage_graphics/sandmonsterTorso.png'
import igIcon from '../assets/svg/instaLogoNeg.svg'
import combinedTorsos from '../assets/img/homepage_graphics/combinedTorso.png'

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
                                <img src={Eucalyptus} alt="euca-assassin" width="174px" height="147px" />
                                <img src={Sandmonster} alt="love-assassin" width="174px" height="147px" />
                                <img src={Lovehearts} alt="love-assassin" width="174px" height="147px" />
                                <img src={Iris} alt="iris-assassin" width="174px" height="147px" />
                                <img src={Gress} alt="grass-assassin" width="174px" height="147px" />
                            </>) :
                            (
                                <img src={combinedTorsos} alt="assassin-torsos" width="348px" />
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
