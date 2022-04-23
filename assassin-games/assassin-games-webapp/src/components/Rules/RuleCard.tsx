import React from 'react'
import { rule } from '../../utilities/Interfaces';


export default function RuleCard(props: {rule : rule}) {
  
  const rule : rule = props.rule;
  const renderBullets = rule.desc.map((bulletObj) => {

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
    gridColumn : (rule.column),
    gridRow : (rule.double ? '1/3' : null)
  }

  return (
    <div className='ruleCardWrapper' style={CardStyle}>
      <div className='ruleCardHeader'>
        <h1 className='ruleCardTitle lusitana'>{rule.title}</h1>
        <img className='ruleCardImage' src={require('../../assets/img/ruleCardImages/'+ rule.image +'.png')} alt='cardImage' width="80px" height='80px'/>
      </div>
      {renderBullets}
      {
        rule.bulletImage ? <img src={rule.bulletImage} alt='assassin-winner' width='290px'/> : <></>
      }
    </div>
  )
}
