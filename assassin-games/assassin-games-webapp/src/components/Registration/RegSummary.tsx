import React from 'react'

import SilverTrophy from '../../assets/img/assassinTrophySilver.png'
import { Personalia, registration } from '../../utilities/Interfaces'
import FormField from './FormField'

export function RegLanding(props: { Personalia: Partial<Personalia> }) {
    return (
        <div className="regFormWrapper">
            <h1 className="regFormTitle">DU ER RÅ!</h1>
            <p className='regFormDesc'>
                Takk for at du har registert deg.
                Jeg elsker deg {props.Personalia.name.toUpperCase()}.
            </p>
            <p className='regFormDesc'>
                <b>Følg <a id="InstaLanding" href='https://instagram.com/ag.trondheim'>@ag.trondheim</a> på instagram </b>
                for å få jevnlige oppdateringer om spillet.
            </p>
            <img src={SilverTrophy} alt="TrophySilver" />
            <div className="handleContainer">
                <a className="handle" id="InstaLandingButton " href="https://www.instagram.com/ag.trondheim/">@AG.TRONDHEIM</a>
            </div>
        </div>
    )
}

export function RegSummary(props: { Registration: Partial<registration> }) {
    return (
        <div className="regFormWrapper">
            <h1 className="regFormTitle">OPPSUMMERING</h1>
            <p className='regFormDesc'>
                Sjekk at de viktigste opplysningen er korrekte og send skjema eller går tilbake og rette opp.
            </p>
            <FormField readonly title="FULLT NAVN" value={props.Registration.Personalia.name} type="text" changeHandler={() => { }} />
            <FormField readonly title="EPOST" value={props.Registration.Personalia.email} type="text" changeHandler={() => { }} />
            <FormField readonly title="TELEFON" value={props.Registration.Personalia.phone} type="text" changeHandler={() => { }} />
            <FormField readonly title="ADRESSE" value={props.Registration.Location.address} type="text" changeHandler={() => { }} />
        </div>
    )
}
