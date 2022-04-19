interface rule {
  title: string, 
  desc: Array<{
    bulletTitle?: string, 
    bullets : Array<string>,
  }>
  double?: boolean,
  column?: number,
}

export const rules : Array<rule> = [
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
      ],
      double : true,
      column : 1,
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
      ],
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
    {
      title: "Weapons & Defence", 
      desc: [
        {
          bullets: [
            "Det er kun lov til å bruke den utdelte vannpistolen til å eliminere ditt target",
            "Det er ikke lov å male vannpistolen",
            "Det er ikke tillat med skjold av noen som helst form",
          ]
        }
      ],
      double : true,
      column : 4
    },
    {
      title: "Covid-19", 
      desc: [
        {
          bullets: [
            "Dersom man må i isolasjon på lenger enn 4 dager, blir man automatisk eliminert fra spillet",
            "Deltakere må melde fra til styret",
          ]
        }
      ]
    },
    {
      title: "No no civilian", 
      desc: [
        {
          bullets: [
            "Unngå å skyte sivile. Hvis hendelsen likevel inntreffer, promoter gjerne spillet",
          ]
        }
      ]
    },
    {
      title: "Two weeks notice", 
      desc: [
        {
          bullets: [
            "Alle assassins som ikke har drept sitt target innen 9. mai kl 23:59 blir automatisk eliminert fra spillet.",
            "Assassins som mister targetet sitt grunnet two weeks notice vil da få utdelt nytt target.",
            "Eksempel: I et spill med rekken av targets Hege, Martin, Arne, Mats og Anne, hvor Arne og Mats ryker grunnet regelen, så vil Martin få nytt target: Anne.",
          ]
        }
      ],
      double : true,
      column : 2,
    },
    {
      title: "Final Week", 
      desc: [
        {
          bullets: [
            "Dreper du din assassin dør vedkommende. Dette gjør at man kan drepe begge veier.",
            "Eksempel: Vi har et spill med tre assassins: Hvor x har y som target, og y har z som target. Dersom z dreper y, vil x få z som target.", 
            "Dette fører også til at immunitetsregelen opphører.",
          ]
        }
      ],
      double : true,
      column : 3,
    },
    {
      title: "Final Day", 
      desc: [
        {
          bulletTitle: "Location: Mellom Trondheim Torg og Ila. \n\nInfo: Basert på innspill fra deltakere. Finalen minner om et rebusløp hvor finalistene bil bli testet i kreativitet, AG-kunnskap og skyteevner. Dersom du vil vinne finalen lønner det seg å følge med på hendelsesforløpet gjennom hele spillet. \n\n Regler:",
          bullets: [
            "Ikke lov med flere vannpistoler, så still opp med full vannpistol og ha med påfyll",
            "Ikke lov med transportmidler", 
            "Ikke lov med bruk av Googling / bruk av mobil",
            "Ikke lov med hjelpere",
          ]
        }
      ],
      double : true,
      column : 4,
    },
  ]