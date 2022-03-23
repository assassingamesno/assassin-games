import { combineReducers } from "@reduxjs/toolkit";

import registrationReducer from './registration/reducer'

export default combineReducers({
    registration: registrationReducer,
});