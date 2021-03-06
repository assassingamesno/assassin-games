import React, { useState } from 'react'
import { CountdownInput } from '../../utilities/Interfaces'

// Import of components
import Countdown from './Countdown'

interface props {
    seasonInfo : Array<CountdownInput>
}

export default function CountdownOperator(props : props) {

    const now = new Date();
    let nextCD : CountdownInput;

    const [rerender, setRerender] = useState(false)

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



    return (
        <div>
            <div>{nextCD.title.toUpperCase()}</div>
            {nextCD.cdReplacement ? 
                <>
                    <h1 className='lusitana countdown'>{nextCD.cdReplacement}</h1> 
                    <Countdown style={{display:'none'}} seasonStart={nextCD.starttime} onFinish={() => {setRerender(!rerender);}}/>
                </>
            :
                <Countdown seasonStart={nextCD.starttime} onFinish={() => {setRerender(!rerender);}}/>
            }
        </div>
    )
}
