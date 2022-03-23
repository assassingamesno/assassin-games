import React from 'react'

import { useDispatch } from 'react-redux'

import { decrementFormPage, incrementFormPage } from '../../store/registration/actions'

import LeftArrow from '../../assets/svg/leftArrow.svg'
import RightArrow from '../../assets/svg/rightArrow.svg'
import { registration } from '../../utilities/Interfaces'

interface props {
    CurPage: number,
    TotPage: number,
}

export default function RegistrationNavbar(props: props) {

    const CurPage = props.CurPage;
    const totalPages = props.TotPage;

    const dispatch = useDispatch();

    const NextPage = () => {
        dispatch(incrementFormPage());
    }
    const PrevPage = () => {
        dispatch(decrementFormPage());
    }

    const NextClick = (): void => {
        if (CurPage !== totalPages) {
            NextPage();
        }
    }

    const PrevClick = (): void => {
        if (CurPage !== 1) {
            PrevPage();
        }
    }

    return (
        <div className="regNavbar">
            <button className='regNavButton' onClick={() => PrevClick()}>
                <img src={LeftArrow} alt="Left arrow" />
                <p className='prev'>FORRIGE</p>
            </button>
            <div className='regNavCounterWrapper'>
                <div className='regNavCurCounter'>
                    {CurPage}
                </div>
                <div className='regNavTotalCounter'>
                    {totalPages - 1}
                </div>
            </div>
            <button className='regNavButton' onClick={() => NextClick()}>
                <p className='next'>NESTE</p>
                <img src={RightArrow} alt="Right Arrow" />
            </button>
        </div>
    )
}

export function RegSummaryBar(props: { Registration: Partial<registration> }) {

    const dispatch = useDispatch();

    const submitForm = () => {
        // TODO: Add verification of all fields in the registration store and submit the form
        console.log("sent form to backend")

        window.location.href = "/registration/landing"
    }

    return (
        <div className="regNavbar">
            <button className='regNavButton' onClick={() => dispatch(decrementFormPage())}>
                <img src={LeftArrow} alt="Left arrow" />
                <p className='prev'>REDIGER</p>
            </button>
            <button className='regNavButton' onClick={() => submitForm()}>
                <p className='next'>SEND SKJEMA</p>
                <img src={RightArrow} alt="Right Arrow" />
            </button>
        </div>
    )
}

export function RegLandingBar() {
    return (
        <div className="regNavbar">
            <div>
                DETTE KOMMER TIL Å BLI DRITFETT
            </div>
        </div>
    )
}
