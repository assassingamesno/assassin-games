// Navbar related actions 
export const incrementFormPage = () => ({
    type: 'INCREMENT_PAGE'
})

export const decrementFormPage = () => ({
    type: 'DECREMENT_PAGE'
})

//Personalia related actions
export const setName = (name: string) => ({
    type: 'SET_NAME',
    payload: name,
})

export const setEmail = (email: string) => ({
    type: 'SET_EMAIL',
    payload: email,
})

export const setPhone = (phone: string) => ({
    type: 'SET_PHONE',
    payload: phone,
})

export const setInsta = (handle: string) => ({
    type: 'SET_INSTA',
    payload: handle,
})

//Student related actions
export const setClass = (year: number) => ({
    type: 'SET_CLASS',
    payload: year,
})

export const setCampus = (campus: string) => ({
    type: 'SET_CAMPUS',
    payload: campus,
})

export const setStudy = (study: string) => ({
    type: 'SET_STUDY',
    payload: study,
})

//Placement related actions
export const setAddress = (address: string) => ({
    type: 'SET_ADDRESS',
    payload: address,
})
export const setStore = (store: string) => ({
    type: 'SET_STORE',
    payload: store,
})
export const addHangout = (hangout: string) => ({
    type: 'ADD_HANGOUT',
    payload: hangout,
})
export const removeHangout = (hangout: string) => ({
    type: 'REMOVE_HANGOUT',
    payload: hangout,
})

