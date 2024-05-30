import {UserType} from "../../types/users/userType.ts";
import {SubscriptionType} from "../../types/users/subscriptionType.ts";

// Начальное состояние user state.
// Интерфейс для redux, хранит состояние пользователя в store.
interface IUserState {
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
    // Баланс кошелька
    balance: number
}

export default IUserState;
