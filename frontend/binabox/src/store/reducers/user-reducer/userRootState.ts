import {UserType} from "../../../types/users/userType.ts";
import {SubscriptionType} from "../../../types/users/subscriptionType.ts";

// Root state для хука typed selector
export type UserRootState = {
    user: {
        // Никнейм пользователя
        nickname: string;
        // Электронная почта пользователя
        email: string;
        // Тип пользователя
        type: UserType;
        // Электронная почта пользователя
        subscription: SubscriptionType;
        // Выполнил ли пользователь вход
        isAuthenticated: boolean;
        // Аватарка пользователя
        avatar: string;
        // Баланс кошелька
        balance: number
    }
}