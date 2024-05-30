import {UserActionTypes} from "../../types/actions/userActions.ts";

interface IUpdateUserEmail {
    type: UserActionTypes.UPDATE_USER_EMAIL;
    // Новая почта пользователя
    payload: string;
}

export default IUpdateUserEmail;