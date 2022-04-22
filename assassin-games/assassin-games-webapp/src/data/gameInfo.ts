import { CountdownInput } from "../utilities/Interfaces"

export const gameTimestamps: Array<CountdownInput> = [
    {
        event: 'registration',
        starttime: '04/04/2022 12:00:00 +0200',
        aftertime: '04/05/2022 12:00:00 +0200',
        title: 'registreringen åpner om',
        afterTitle: 'Påmeldingen er åpen!',
        afterText: 'Påmeldingen er åpen!',
    },
    {
        event: 'gameStart',
        starttime: '04/25/2022 00:00:00 +0200',
        aftertime: '04/26/2022 00:00:00 +0200',
        title: 'Spillet starter om',
        afterTitle: 'spillet er nå i gang',
        afterText: 'Spillet dekkes på Instagram',
    },
    {
        event: 'notice',
        starttime: '05/09/2022 00:00:00 +0200',
        aftertime: '05/10/2022 00:00:00 +0200',
        title: 'two week notice avsluttes om',
        afterTitle: 'two week notice er avsluttet',
        afterText: 'Se resultatet på Instagram',
    },
    {
        event: 'finalWeek',
        starttime: '05/16/2022 00:00:00 +0200',
        aftertime: '05/17/2022 00:00:00 +0200',
        title: 'final week starter om',
        afterTitle: 'final week er i gang',
        afterText: 'Sjekk regler, sjekk instagram'
    },
    {
        event: 'finalDay',
        starttime: '05/23/2022 00:00:00 +0200',
        aftertime: '05/23/2022 23:59:59 +0200',
        title: 'Finaledag starter om',
        afterTitle: 'den store dagen er her',
        afterText: 'LIVE-dekning på Instagram'
    },
    {
        event: 'afterGame',
        starttime: '05/24/2022 00:00:00 +0200',
        aftertime: '',
        title: 'assassin games runde 4',
        afterText: '... under utvikling',
        afterTitle: ''
    },
]