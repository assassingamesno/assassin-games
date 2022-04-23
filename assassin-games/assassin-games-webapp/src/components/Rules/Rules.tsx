import React, { useEffect, useState } from 'react'
import RuleCard from './RuleCard'

//Importing styling
import '../../styling/components/rules.scss'

//Importing graphics
import leftArrow from '../../assets/svg/leftArrowDark.svg'
import rightArrow from '../../assets/svg/rightArrowDark.svg'

interface rule {
  title: string, 
  desc: Array<{
    bulletTitle?: string, 
    bullets : Array<string>,
  }>
  image: string,
  double?: boolean,
  column?: number,
}

interface props {
  title: string,
  pageDesc: string,
  data : Array<rule>;
}

export default function Rules(props: props) {

  const [pageIndex, setPageIndex] = useState(0);

  const [width, setWidth] = useState(window.innerWidth)

  useEffect(() => {
      function updateWidth() {
          setWidth(window.innerWidth)
      }

      window.addEventListener('resize', updateWidth)
  })

  const mobileScreen = (width < 1100);

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

  let pages = mobileScreen ? [props.data] : pagify(props.data)

  const rulesRendering = pages[pageIndex].map((object) => {
    return <RuleCard rule={object}/>
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
        <p className='pageDesc'>{props.pageDesc.toUpperCase()}</p>
        <div className='titleControlWrapper'>
          <p className='lusitana pageTitle'>{props.title.toUpperCase()}</p>
          {
            mobileScreen ? <></> : 
            <>
              <button className={'leftArrowButton' + (pageIndex > 0 ? '' : ' unclickable')} onClick={decrementPage}>
                <img src={leftArrow} alt='arrow-left' />
              </button>
              <button className={'rightArrowButton' + (pageIndex < pages.length - 1 ? '' : ' unclickable')} onClick={incrementPage}>
                <img src={rightArrow} alt='arrow-right'/>
              </button>
            </>
          }
        </div>
      </div>
      <div className='CardsWrapper'>
        {rulesRendering}
      </div>
    </div>
  )
}
