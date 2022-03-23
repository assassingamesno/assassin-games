import { registration } from "../../utilities/Interfaces";

const initialState: Partial<registration> = {
    CurPage: 1,
    TotPage: 6,
    Personalia: {
        name: '',
        email: '',
        phone: '',
        insta: '',
    },
    Student: {
        class: 0,
        study: '',
        campus: '',
    },
    Location: {
        address: '',
        store: '',
        hangouts: [],
    }
}

export default function reducer(
    state: Partial<registration> = initialState,
    { type, payload }: { type: string, payload?: string }
) {
    switch (type) {
        case 'INCREMENT_PAGE':
            return {
                ...state,
                CurPage: state.CurPage + 1
            };
        case 'DECREMENT_PAGE':
            return {
                ...state,
                CurPage: state.CurPage - 1
            };

        // Personalia reducers
        case 'SET_NAME':
            return {
                ...state,
                Personalia: {
                    ...state.Personalia,
                    name: payload,
                }
            };
        case 'SET_EMAIL':
            return {
                ...state,
                Personalia: {
                    ...state.Personalia,
                    email: payload,
                }
            }
        case 'SET_PHONE':
            return {
                ...state,
                Personalia: {
                    ...state.Personalia,
                    phone: payload,
                }
            }
        case 'SET_INSTA':
            return {
                ...state,
                Personalia: {
                    ...state.Personalia,
                    insta: payload,
                }
            }

        //Student related reducer
        case 'SET_CLASS':
            return {
                ...state,
                Student: {
                    ...state.Student,
                    class: payload,
                }
            }
        case 'SET_CAMPUS':
            return {
                ...state,
                Student: {
                    ...state.Student,
                    campus: payload,
                }
            }
        case 'SET_STUDY':
            return {
                ...state,
                Student: {
                    ...state.Student,
                    study: payload,
                }
            }

        // Location reducers
        case 'SET_ADDRESS':
            return {
                ...state,
                Location: {
                    ...state.Location,
                    address: payload,
                }
            }
        case 'SET_STORE':
            return {
                ...state,
                Location: {
                    ...state.Location,
                    store: payload,
                }
            }
        case 'ADD_HANGOUT':
            return {
                ...state,
                Location: {
                    ...state.Location,
                    hangouts: [...state.Location.hangouts, payload]
                }
            }
        case 'REMOVE_HANGOUT':
            return {
                ...state,
                Location: {
                    ...state.Location,
                    hangouts: state.Location.hangouts.filter((x: string) => {
                        return x !== payload;
                    }),
                }
            }

        default:
            return state;
    }
}