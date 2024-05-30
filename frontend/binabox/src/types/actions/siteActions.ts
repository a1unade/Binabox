import ISwitchLanguageAction from "../../interfaces/site-actions/ISwitchLanguageAction.ts";

// Перечисление всех типов actions для site reducer
export enum SiteActionTypes {
    SWITCH_LANGUAGE = 'SWITCH_LANGUAGE' // Смена языка сайта
}

export type SiteAction = ISwitchLanguageAction