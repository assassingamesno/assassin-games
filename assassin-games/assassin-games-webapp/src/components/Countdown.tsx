import React, { useState, useEffect } from 'react'

import '../styling/components/home.scss'

interface CountdownProps {
    seasonStart: string //String with the date for the season start
}

export default function Countdown(props: CountdownProps) {

    const countdownDate = new Date(Date.parse(props.seasonStart));
    const [res, setRes] = useState(getTimeUntilStart(new Date(), countdownDate));

    function getTimeUntilStart(curr: Date, start: Date): [number, number, number, number] {
        // Helper function calculating the days, hours and seconds between curr and start

        // Calculater difference in milliseconds
        let secDiff: number = (start.getTime() - curr.getTime()) / 1000;
        let counter = secDiff;

        let days: number = Math.floor(counter / (60 * 60 * 24));
        counter = secDiff % (60 * 60 * 24)
        let hours: number = Math.floor(counter / (60 * 60));
        counter = counter % (60 * 60);
        console.log(counter);
        let minutes = Math.floor(counter / 60);
        counter = counter % 60
        let seconds: number = Math.floor(counter);

        return [days, hours, minutes, seconds]
    }

    useEffect(() => {

        const timer = setTimeout(() => {
            setRes(getTimeUntilStart(new Date(), countdownDate));
        }, 1000)

        return () => {
            clearTimeout(timer)
        }
    })

    return (
        <div>
            <h1 className="lusitana countdown">
                {res[0].toLocaleString('en-US', { minimumIntegerDigits: 2, useGrouping: false })}d:
                {res[1].toLocaleString('en-US', { minimumIntegerDigits: 2, useGrouping: false })}t:
                {res[2].toLocaleString('en-US', { minimumIntegerDigits: 2, useGrouping: false })}m:
                {res[3].toLocaleString('en-US', { minimumIntegerDigits: 2, useGrouping: false })}s</h1>
        </div>
    )
}
