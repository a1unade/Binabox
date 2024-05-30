import {UserActionTypes} from "../../types/actions/userActions.ts";

interface IAddUserBalance {
    type: UserActionTypes.ADD_USER_BALANCE;
    // Новый баланс
    payload: number;
}

export default IAddUserBalance;