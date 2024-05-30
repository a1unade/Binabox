import {SiteAction, SiteActionTypes} from "../../types/actions/siteActions.ts";
import {Dispatch} from "redux";

export const switchLanguage = (language: string) => {
    return (dispatch: Dispatch<SiteAction>) => {
        try {
            dispatch({type: SiteActionTypes.SWITCH_LANGUAGE, payload: language});
        } catch (e) {
            console.log(e);
        }
    }
}