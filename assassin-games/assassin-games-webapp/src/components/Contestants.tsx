import React from 'react'
import initialDetails from '../data/initialDetails'
import Search from './Search'

export default function Contestants() {
    return (
        <div className="router-page">
            <div>
                <Search details={initialDetails} />
            </div>
        </div>
    )
}
