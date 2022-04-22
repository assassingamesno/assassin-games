import React from 'react'
import { CountdownInput } from '../../utilities/Interfaces'

// Import of components
import Countdown from './Countdown'

interface props {
    seasonInfo : Array<CountdownInput>
}

export default function CountdownOperator(props : props) {

    const now = new Date();
    let nextCD : CountdownInput;

    const findCurrentInterval = (inputs : Array<CountdownInput>) => {
        inputs.some((object: CountdownInput) => {
            const nextTime = new Date(Date.parse(object.starttime))
            if ((nextTime.getTime() - now.getTime()) > 0){
                nextCD = object;
                return true;
            }
            nextCD = object;
            return false;
        })
    }

    findCurrentInterval(props.seasonInfo);

    console.log(nextCD)

    return (
        <div>CountdownOperator</div>
    )
}
