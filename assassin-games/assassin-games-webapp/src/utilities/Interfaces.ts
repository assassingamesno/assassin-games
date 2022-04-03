
export interface reduxStore {
    home: Home,
    registration: registration,
}

export interface Home {
    regOpenBool: boolean,
}

export interface Personalia {
    name: string,
    email: string,
    phone: string,
    insta: string,
}

export interface Student {
    campus: string,
    class: number,
    study: string,
}

export interface Location {
    address: string,
    store: string,
    hangouts: Array<String>,
}

export interface registration {
    CurPage: number,
    TotPage: number,
    Personalia: Personalia,
    Student: Student,
    Location: Location,
}