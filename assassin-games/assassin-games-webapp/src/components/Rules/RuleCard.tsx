import React from 'react'

interface props {
  title: string,
  desc: Array<
    {
      bulletTitle?: string, 
      bullets: Array<string>
    }
  >,
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

  return (
    <div className='ruleCardWrapper'>
      <h1 className='ruleCardTitle lusitana'>{props.title}</h1>
      {renderBullets}
    </div>
  )
}
