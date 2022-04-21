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

export const awards : Array<rule> = [
    {
        title: 'First Kill',
        desc: [
            {
                bulletTitle : 'Den første som dreper noen',
                bullets: []
            }
        ],
        image : 'Vinmonopolet',
    },
    {
        title: 'Assassin of the week',
        desc: [
            {
                bulletTitle : 'Den som dreper flest hver uke',
                bullets: []
            }
        ],
        image : 'Midtbyen',
    },
    {
        title: 'Best director',
        desc: [
            {
                bulletTitle : 'Den som filmer det beste contentet',
                bullets: []
            }
        ],
        image: 'Sushi',
    },
    {
        title: 'Jack the ripper',
        desc: [
            {
                bulletTitle : 'Den som gjennomfører den beste kill-planen',
                bullets: []
            }
        ], 
        image: 'Massasje'
    },
    {
        title: 'Hat trick',
        desc: [
            {
                bulletTitle : 'Den første som klarer å eliminere tre personer på én dag',
                bullets: []
            }
        ],
        image: 'Folkbadstu'
    },
    {
        title: 'Most Kills',
        desc: [
            {
                bulletTitle : 'Den som har drept flest targets sammenlagt',
                bullets: []
            }
        ],
        image: 'Massasje'
    },
    {
        title: 'Hypeman',
        desc: [
            {
                bulletTitle : 'Beste engasjement',
                bullets: []
            }
        ],
        image : 'Rush'
    },
    {
        title: 'Snitches',
        desc: [
            {
                bulletTitle : 'Get riches',
                bullets: []
            }
        ],
        image: 'SitKafe',
    },
    {
        title: 'Last Man Standing',
        desc: [
            {
                bulletTitle : 'Den siste som står igjen',
                bullets: []
            }
        ],
        image : 'Vinner',
        double: true,
    },

]