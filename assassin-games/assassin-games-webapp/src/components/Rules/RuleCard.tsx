import React from 'react'

interface props {
  title: string,
  desc: Array<
    {
      bulletTitle?: string, 
      bullets: Array<string>
    }
  >,
  image: string,
  double?: boolean,
  column?: number,
}


export default function RuleCard(props: props) {
  const renderBullets = props.desc.map((bulletObj) => {

    return (
      <div className="ruleCardBulletContainer">
        {bulletObj.bulletTitle ? <p>{bulletObj.bulletTitle}</p> : <></>}
        <ul className='ruleCardBullets'>
          {bulletObj.bullets.map((bullet) => {
            return <li className='ruleCardBullet'>{bullet}</li>
          })}
        </ul>
      </div>
    )
  });

  const CardStyle = {
    gridColumn : (props.column),
    gridRow : (props.double ? '1/3' : null)
  }

  return (
    <div className='ruleCardWrapper' style={CardStyle}>
      <div className='ruleCardHeader'>
        <h1 className='ruleCardTitle lusitana'>{props.title}</h1>
        <img className='ruleCardImage' src={props.image} alt='cardImage' width="80px" height='80px'/>
      </div>
      {renderBullets}
    </div>
  )
}
