import { Home } from "../../utilities/Interfaces";

const initialState: Home = {
    regOpenBool: true,
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