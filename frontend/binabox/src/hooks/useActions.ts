import {useDispatch} from "react-redux";
import {bindActionCreators} from "redux";
import * as UserActionCreators from '../store/action-creators/users'
import * as SiteActionCreators from '../store/action-creators/site'

export const useUserActions = () => {
    const dispatch = useDispatch();
    return bindActionCreators(UserActionCreators, dispatch);
}

export const useSiteActions = () => {
    const dispatch = useDispatch();
    return bindActionCreators(SiteActionCreators, dispatch);
}