import React, { useState } from 'react'
import RuleCard from './RuleCard'

//Importing styling
import '../../styling/components/rules.scss'

//Importing graphics
import leftArrow from '../../assets/svg/leftArrowDark.svg'
import rightArrow from '../../assets/svg/rightArrowDark.svg'

//Importing data
import {rules} from '../../data/rules'

interface rule {
  title: string, 
  desc: Array<{
    bulletTitle?: string, 
    bullets : Array<string>,
  }>
  double?: boolean,
  column?: number,
}

export default function Rules() {

  const [pageIndex, setPageIndex] = useState(0);

  const pagify = (rules : Array<rule>) => {
    // Function which takes in a list of rules and divides the list into pages of rules based on necessary amount
    let necessaryCells = 0; 
    let pages = []
    let currPage = []
    rules.forEach((rule: rule) => {
      //Check if the page 
      let demand = rule.double ? 2 : 1;
      if (necessaryCells + demand <= 8){
        // Add to current page and adds demand to the counter
        currPage = [...currPage, rule]
        necessaryCells += demand; 
      } else {
        //If there is not enough space for the current rule
        // terminate the page and add to pages
        pages = [...pages, currPage]
        currPage = [rule]
        necessaryCells = demand;
      }
    })

    //Cleanup: checks that currPage is in pages, and adds if not
    if (!pages.includes(currPage)) {
      pages = [...pages, currPage]
    }

    return pages
  }

  let pages = pagify(rules)

  const rulesRendering = pages[pageIndex].map((object) => {
    return <RuleCard title={object.title} desc={object.desc} double={object.double} column={object.column}/>
  })

  const decrementPage = () => {
    if (!(pageIndex <= 0)) {
      setPageIndex(pageIndex - 1);
    }
  }

  const incrementPage = () => {
    if (!(pageIndex >= pages.length - 1)) {
      setPageIndex(pageIndex + 1);
    }
  }

  return (
    <div className="router-page">
      <div className='pageTitleWrapper'>
        <p className='pageDesc'>EN GOD ASSASSIN ER EN LOVLYDIG EN</p>
        <div className='titleControlWrapper'>
          <p className='lusitana pageTitle'>REGLER</p>
          <button className={'leftArrowButton' + (pageIndex > 0 ? '' : ' unclickable')} onClick={decrementPage}>
            <img src={leftArrow} alt='arrow-left' />
          </button>
          <button className={'rightArrowButton' + (pageIndex < pages.length - 1 ? '' : ' unclickable')} onClick={incrementPage}>
            <img src={rightArrow} alt='arrow-right'/>
          </button>
        </div>
      </div>
      <div className='CardsWrapper'>
        {rulesRendering}
      </div>
    </div>
  )
}
