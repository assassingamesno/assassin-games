import { combineReducers } from "@reduxjs/toolkit";

import registrationReducer from './registration/reducer'
import homeReducer from './home/reducer'

export default combineReducers({
    registration: registrationReducer,
    home: homeReducer,
});