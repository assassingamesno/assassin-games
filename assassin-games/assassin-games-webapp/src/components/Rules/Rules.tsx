import React from 'react'
import RuleCard from './RuleCard'

//Importing styling
import '../../styling/components/rules.scss'

//Importing graphics
import leftArrow from '../../assets/svg/leftArrowDark.svg'
import rightArrow from '../../assets/svg/rightArrowDark.svg'

export default function Rules() {

  let rules = [
    {
      title: "No Kill Zones", 
      desc: [
        {
          bulletTitle: "No Kill Zones",
          bullets: [
            "Innenfor husets fire vegger", 
            "Sykehus og legevakt, fengsel", 
            "Lesesal, grupperom, bibliotek, lab (steder hvor det er dyrt utstyr som kan ødelegges av vann bør unngås)", 
            "Jobb/honorerte verv"],
        }, 
        {
          bulletTitle: "OBS:", 
          bullets: [
            "Spiseareal/pauseareal telles ikke som 'No Kill Zone'", 
            "Veranda/balkong telles ikke som 'No Kill Zone'",
            "Undervisningsrom på campus telles ikke som 'No Kill Zone'",
          ]
        }
      ]
    },
    {
      title: "Target", 
      desc: [
        {
          bullets: [
            "Alle får utdelt ett target (navn) og addresse i dm"
          ]
        }
      ]
    },
    {
      title: "Immunity", 
      desc: [
        {
          bullets: [
            "Skyter du din morder før din morder skyter deg får du en time immunitet"
          ]
        }
      ]
    },
    {
      title: "Elimination", 
      desc: [
        {
          bullets: [
            "Dreper du ditt target, får du targetet til vedkommende",
            "Ta bilde og send til @ag.trondheim"
          ]
        }
      ]
    },
    {
      title: "Vold", 
      desc: [
        {
          bullets: [
            "Utøvelse av vold skal i aller høyeste grad unngås og medfører umiddelbar eliminasjon "
          ]
        }
      ]
    },
  ]

  const rulesRendering = rules.map((object) => {
    return <RuleCard title={object.title} desc={object.desc}/>
  })

  return (
    <div className="router-page">
      <div className='pageTitleWrapper'>
        <p className='pageDesc'>EN GOD ASSASSIN ER EN LOVLYDIG EN</p>
        <div className='titleControlWrapper'>
          <p className='lusitana pageTitle'>REGLER</p>
          <button>
            <img src={leftArrow} alt='arrow-left'/>
          </button>
          <button>
            <img src={rightArrow} alt='arrow-left'/>
          </button>
        </div>
      </div>
      <div className='CardsWrapper'>
        {rulesRendering}
      </div>
    </div>
  )
}
