import { rule } from "../utilities/Interfaces";
import winner from "../assets/img/assassinTrophySilver.png"

export const awards : Array<rule> = [
    {
        title: 'First Kill',
        desc: [
            {
                bulletTitle : 'Den første som dreper noen får et gavekort på 250 kr fra vinmonopolet.',
                bullets: []
            }
        ],
        image : 'Vinmonopolet',
    },
    {
        title: 'Assassin of the week',
        desc: [
            {
                bulletTitle : 'Hver uke får den assassin som har eliminert flest den uka (mandag-søndag) et gavekort på 500kr fra Midtbyen.',
                bullets: []
            }
        ],
        image : 'Midtbyen',
    },
    {
        title: 'Best director',
        desc: [
            {
                bulletTitle : 'Den som filmer det beste contentet får Sushime buffet for to.',
                bullets: []
            }
        ],
        image: 'Sushi',
    },
    {
        title: 'Jack the ripper',
        desc: [
            {
                bulletTitle : 'Den som gjennomfører den beste kill-planen får en velfortjent 50 min massasje på squeeze',
                bullets: []
            }
        ], 
        image: 'Massasje'
    },
    {
        title: 'Hat trick',
        desc: [
            {
                bulletTitle : 'Den første som klarer å eliminere tre personer på én dag får inngang for to på sjøbadet.',
                bullets: []
            }
        ],
        image: 'Folkbadstu'
    },
    {
        title: 'Most Kills',
        desc: [
            {
                bulletTitle : 'Den som har eliminert flest targets sammenlagt får en velfortjent 50 min massasje på squeeze.',
                bullets: []
            }
        ],
        image: 'Massasje'
    },
    {
        title: 'Hypeman',
        desc: [
            {
                bulletTitle : 'Den med best engasjement får inngang for to på Rush trampolinepark.',
                bullets: []
            }
        ],
        image : 'Rush'
    },
    {
        title: 'Snitches',
        desc: [
            {
                bulletTitle : 'Get riches i form av 100 kr gavekort på Sit.',
                bullets: []
            }
        ],
        image: 'SitKafe',
    },
    {
        title: 'Last Man Standing',
        desc: [
            {
                bulletTitle : 'Den siste som står igjen får 5k.',
                bullets: []
            }
        ],
        bulletImage: winner,
        image : 'Vinner',
        double: true,
    },

]