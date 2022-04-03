import { Home } from "../../utilities/Interfaces";

const checkRegOpen = (starttime: string) => {
    let now = new Date()
    let start = new Date(Date.parse(starttime))
    return now.getTime() - start.getTime() > 0
}

const initialState: Home = {
    regOpenBool: checkRegOpen("04/04/2022 12:00:00 +0200"),
}

export default function reducer(
    state: Home = initialState,
    { type, payload }: { type: string, payload: boolean }
) {
    switch (type) {
        case 'OPEN_REG':
            return {
                ...state,
                regOpenBool: true,
            }
        default:
            return state;
    }
}