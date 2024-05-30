import {UserActionTypes} from "../../types/actions/userActions.ts";
import {UserType} from "../../types/users/userType.ts";
import {SubscriptionType} from "../../types/users/subscriptionType.ts";

interface ICreateUserAction {
    type: UserActionTypes.CREATE_USER;
    payload: {
        // Ник пользователя
        nickname: string;
        // Электронная почта пользователя
        email: string;
        // Тип пользователя
        type: UserType;
        // Тип подписки
        subscription: SubscriptionType;
        // Выполнен ли вход
        isAuthenticated: boolean;
        // Аватарка пользователя
        avatar: string;
        // Баланс пользователя
        balance: number
    };
}

export default ICreateUserAction;