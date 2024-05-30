import {UserActionTypes} from "../../types/actions/userActions.ts";

interface IUpdateUserAvatar {
    type: UserActionTypes.UPDATE_USER_AVATAR;
    // Новая аватарка пользователя
    payload: string;
 }

 export default IUpdateUserAvatar;