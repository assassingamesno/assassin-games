import React from 'react'

interface props {
    title: string,
    value?: string,
    placeholder?: string,
    readonly?: boolean,
    type: string,
    // Legge inn en eller annen funksjon her som validerer og dispatcher riktig?
    changeHandler: (event: React.ChangeEvent<HTMLInputElement>) => void
}

export default function FormField(props: props) {

    return (
        <div className="FormField">
            <div className='FormFieldTitle'>
                {props.title}
            </div>
            {
                props.readonly ?
                    (
                        <input className='FormFieldInput' type={props.type} placeholder={props.placeholder} value={props.value} onChange={props.changeHandler} readOnly />
                    ) : (
                        <input className='FormFieldInput' type={props.type} placeholder={props.placeholder} value={props.value} onChange={props.changeHandler} />
                    )
            }
        </div>
    )
}
