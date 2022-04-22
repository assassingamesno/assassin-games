import { CountdownInput } from "../utilities/Interfaces"

export const gameTimestamps: Array<CountdownInput> = [
    {
        event: 'registration',
        starttime: '04/04/2022 12:00:00 +0200',
        title: 'registreringen åpner om',
    },
    {
        event: 'after-registration',
        starttime: '04/05/2022 12:00:00 +0200',
        title: '',
        cdReplacement: 'Påmeldingen er åpnet!'
    },
    {
        event: 'gameStart',
        starttime: '04/22/2022 17:37:00 +0200',
        title: 'Spillet starter om',
    },
    {
        event: 'after-gameStart',
        starttime: '04/26/2022 00:00:00 +0200',
        title: 'spillet er nå i gang',
        cdReplacement: 'Spillet dekkes på Instagram',
    },
    {
        event: 'notice',
        starttime: '05/09/2022 00:00:00 +0200',
        title: 'two week notice avsluttes om',
    },
    {
        event: 'after-notice',
        starttime: '05/10/2022 00:00:00 +0200',
        title: 'two week notice er avsluttet',
        cdReplacement: 'Se resultatet på Instagram',
    },
    {
        event: 'finalWeek',
        starttime: '05/16/2022 00:00:00 +0200',
        title: 'final week starter om',
    },
    {
        event: 'after-finalweek',
        starttime: '05/17/2022 00:00:00 +0200',
        title: 'final week er i gang',
        cdReplacement: 'Sjekk regler, sjekk instagram'
    },
    {
        event: 'finalDay',
        starttime: '05/23/2022 00:00:00 +0200',
        title: 'Finaledag starter om',
    },
    {
        event: 'after-finalDay',
        starttime: '05/23/2022 23:59:59 +0200',
        title: 'den store dagen er her',
        cdReplacement: 'LIVE-dekning på Instagram',
    },
    {
        event: 'afterGame',
        starttime: '05/24/2022 00:00:00 +0200',
        title: 'assassin games runde 4',
        cdReplacement: '... under utvikling',
    },
]