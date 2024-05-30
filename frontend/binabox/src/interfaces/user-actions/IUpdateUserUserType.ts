import {UserActionTypes} from "../../types/actions/userActions.ts";
import {UserType} from "../../types/users/userType.ts";

interface IUpdateUserUserType{
    type: UserActionTypes.UPDATE_USER_USER_TYPE;
    // Новый тип пользователя
    payload: UserType
}

export default IUpdateUserUserType;