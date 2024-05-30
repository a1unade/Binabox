import {UserActionTypes} from "../../types/actions/userActions.ts";

interface IRemoveUserBalance {
    type: UserActionTypes.REMOVE_USER_BALANCE;
    // Новый баланс
    payload: number;
}

export default IRemoveUserBalance;