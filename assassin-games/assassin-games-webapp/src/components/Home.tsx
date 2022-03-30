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
                <div className="WTContainer">
                    <div className='WTTitleBox'>
                        <h1 className='lusitana'>
                            En forklaring av <br /> spillets gang
                        </h1>
                    </div>
                    <div id='WTIngress'>
                        Assassin Games er et frivillig initiativ
                        drevet av og for studenter i Trondheim.
                        Fra 24. april er ingen steder trygge.
                        Trondheim transformeres til en slagmark
                        hvor kun den sterkest kan stå igjen som seiersherre.
                    </div>
                    <div>
                        <WalkthroughGraphic title='Alle spillere får tildelt én vannpistol og ett target' graphic={combinedTorsos} />
                        <WalkthroughGraphic title='Jakten har begynt' graphic={combinedTorsos} />
                        <WalkthroughGraphic title='Du slår til på riktig tidspunkt' graphic={combinedTorsos} />
                        <WalkthroughGraphic title='Du får nytt target' graphic={combinedTorsos} />
                        <WalkthroughGraphic title='Jakten herjer' graphic={combinedTorsos} />
                        <WalkthroughGraphic title='Oppdatering på instagram' graphic={combinedTorsos} />
                        <WalkthroughGraphic title='Permier underveis' graphic={combinedTorsos} />
                        <WalkthroughGraphic title='Den siste som står igjen løfter pokalen' graphic={combinedTorsos} />
                    </div>
                </div>
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

interface WTGprops {
    title: string
    graphic: string
}

function WalkthroughGraphic(props: WTGprops) {
    return (
        <>
            <h2 className='WTGraphicTitle'>{props.title}</h2>
            <img className="WTGraphic" src={props.graphic} alt='Walkthrough graphic' />
        </>
    )
}
