import {TypedUseSelectorHook, useSelector} from "react-redux";
import {UserRootState} from "../store/reducers/user-reducer/userRootState.ts";
import {SiteRootState} from "../store/reducers/site-reducer/siteRootState.ts";


// Typed Selector для пользователей (userReducer)
export const useUserTypedSelector: TypedUseSelectorHook<UserRootState> = useSelector;

// Typed Selector для сайта (siteReducer)
export const useSiteTypedSelector: TypedUseSelectorHook<SiteRootState> = useSelector;