import {SiteActionTypes} from "../../types/actions/siteActions.ts";

interface ISwitchLanguageAction {
    type: SiteActionTypes.SWITCH_LANGUAGE;
    // Новый язык локализации
    payload: string;
}

export default ISwitchLanguageAction;