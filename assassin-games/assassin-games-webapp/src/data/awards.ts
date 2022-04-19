interface rule {
    title: string, 
    desc: Array<{
      bulletTitle?: string, 
      bullets : Array<string>,
    }>
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
        ]
    },
    {
        title: 'Assassin of the week',
        desc: [
            {
                bulletTitle : 'Den som dreper flest hver uke',
                bullets: []
            }
        ]
    },
    {
        title: 'Best director',
        desc: [
            {
                bulletTitle : 'Den som filmer det beste contentet',
                bullets: []
            }
        ]
    },
    {
        title: 'Jack the ripper',
        desc: [
            {
                bulletTitle : 'Den som gjennomfører den beste kill-planen',
                bullets: []
            }
        ]
    },
    {
        title: 'Hat trick',
        desc: [
            {
                bulletTitle : 'Den første som klarer å eliminere tre personer på én dag',
                bullets: []
            }
        ]
    },
    {
        title: 'Most Kills',
        desc: [
            {
                bulletTitle : 'Den som har drept flest targets sammenlagt',
                bullets: []
            }
        ]
    },
    {
        title: 'Hypeman',
        desc: [
            {
                bulletTitle : 'Beste engasjement',
                bullets: []
            }
        ]
    },
    {
        title: 'Snitches',
        desc: [
            {
                bulletTitle : 'TODO: Get stitches',
                bullets: []
            }
        ]
    },
    {
        title: 'Last Man Standing',
        desc: [
            {
                bulletTitle : 'Den siste som står igjen',
                bullets: []
            }
        ],
        double: true,
    },

]