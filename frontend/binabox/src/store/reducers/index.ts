import {combineReducers} from "redux";
import {userReducer} from "./user-reducer";
import {siteReducer} from "./site-reducer";

export const rootReducer = combineReducers({
    user: userReducer,
    site: siteReducer
})