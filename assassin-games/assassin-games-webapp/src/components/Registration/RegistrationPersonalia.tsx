import React from 'react'

import { useDispatch } from 'react-redux'
import { setName, setPhone, setEmail, setInsta } from '../../store/registration/actions'

import { Personalia } from '../../utilities/Interfaces'
import FormField from './FormField'

export default function RegistrationPersonalia(props: { Personalia: Partial<Personalia> }) {

    const dispatch = useDispatch()

    const onNameChange = (event: React.ChangeEvent<HTMLInputElement>) => {
        dispatch(setName(event.target.value))
    }

    const onPhoneChange = (event: React.ChangeEvent<HTMLInputElement>) => {
        dispatch(setPhone(event.target.value))
    }

    const onEmailChange = (event: React.ChangeEvent<HTMLInputElement>) => {
        dispatch(setEmail(event.target.value))
    }

    const onInstaChange = (event: React.ChangeEvent<HTMLInputElement>) => {
        dispatch(setInsta(event.target.value))
    }

    return (
        <div className='regFormWrapper'>
            <h1 className='regFormTitle'>PERSONINFO</h1>
            <p className='regFormDesc'>Legg inn din informasjon sånn at vi vet hvem du er og kan få kontakt med deg:)</p>
            <div className='regFormForm'>
                <FormField type='text' title='FULLT NAVN' value={props.Personalia.name} changeHandler={onNameChange} />
                <FormField type='text' title='EPOST' value={props.Personalia.email} changeHandler={onEmailChange} />
                <FormField type='text' title='TELEFON' value={props.Personalia.phone} changeHandler={onPhoneChange} />

                <div className="FormField">
                    <div className='FormFieldTitle'>
                        BRUKERNAVN PÅ INSTAGRAM
                    </div>
                    <div className='FormFieldInstaWrapper'>
                        <div id='InstaAlfa'><div>@</div></div>
                        <input className='FormFieldInput' id="InstaInput" value={props.Personalia.insta} type='text' onChange={onInstaChange} />
                    </div>
                </div>
            </div>
        </div>
    )
}
