import {UserActionTypes} from "../../types/actions/userActions.ts";

interface IDeleteUserAction {
    type: UserActionTypes.DELETE_USER;
}

export default IDeleteUserAction;
