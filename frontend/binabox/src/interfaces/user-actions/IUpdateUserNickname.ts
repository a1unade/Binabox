import {UserActionTypes} from "../../types/actions/userActions.ts";

interface IUpdateUserNickname {
    type: UserActionTypes.UPDATE_USER_NICKNAME;
    // Новый ник пользователя
    payload: string;
}

export default IUpdateUserNickname;