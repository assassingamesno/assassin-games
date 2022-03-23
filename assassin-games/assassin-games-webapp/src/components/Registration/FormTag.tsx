import React, { useState } from 'react'

interface props {
    title: string,
    value?: string,
    placeholder?: string,
    type: string,
    dispatcher: (tagValue: string) => void
}


export default function FormTag(props: props) {

    const [tag, setTag] = useState("")

    const onInputChange = (event: React.ChangeEvent<HTMLInputElement>) => {
        setTag(event.target.value)
    }

    const onTagSubmit = () => {
        if (tag) {
            props.dispatcher(tag)
            setTag("")
        }
    }

    return (
        <div className="FormField">
            <div className='FormFieldTitle'>
                {props.title}
            </div>
            <div className="FormTagInputWrapper">
                <input className='FormFieldInput' type={props.type} placeholder={props.placeholder} value={tag} onChange={onInputChange} />
                <button className="FormTagSubmit" onClick={() => { onTagSubmit() }}>Legg til</button>
            </div>
        </div>
    )
}
