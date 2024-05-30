import ISiteState from "../../../interfaces/site-actions/ISiteState.ts";
import {SiteAction, SiteActionTypes} from "../../../types/actions/siteActions.ts";

// Начальное состояние сайта
const initialState: ISiteState = {
    language: 'EN'
}

export const siteReducer = (state = initialState, action: SiteAction) => {
    switch (action.type){
        case SiteActionTypes.SWITCH_LANGUAGE:
            return {...state, language: action.payload}; // Смена языка локализации
        default:
            return state
    }
}
