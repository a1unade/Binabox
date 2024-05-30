import IUserState from "../../../interfaces/user-actions/IUserState.ts";
import {SubscriptionType} from "../../../types/users/subscriptionType.ts";
import {UserType} from "../../../types/users/userType.ts";
import {UserAction, UserActionTypes} from "../../../types/actions/userActions.ts";
import userAvatar from '../../../assets/images/avatars/users-1.svg';

// Начальное состояние пользователя
const initialState: IUserState = {
    // Никнейм пользователя
    nickname: "",
    // Электронная почта пользователя
    email: "",
    // Тип пользователя
    type: UserType.UNDEFINED,
    // Подписка пользователя
    subscription: SubscriptionType.FREE,
    // Выполнени ли вход
    isAuthenticated: false,
    // Автарка
    avatar: userAvatar,
    // Баланс кошелька
    balance: 0
}

export const userReducer = (state = initialState, action: UserAction) => {
    switch (action.type) {
        case UserActionTypes.UPDATE_USER_NICKNAME:
            return {...state, nickname: action.payload, isAuthenticated: true}; // Смена ника у пользователя
        case UserActionTypes.UPDATE_USER_EMAIL:
            return {...state, email: action.payload, isAuthenticated: true}; // Смена электронной почты у пользователя
        case UserActionTypes.UPDATE_USER_USER_TYPE:
            return {...state, type: action.payload, isAuthenticated: true}; // Смена типа у пользователя
        case UserActionTypes.UPDATE_USER_SUBSCRIPTION_TYPE:
            return {...state, subscription: action.payload, isAuthenticated: true}; // Смена типа подписки и пользователя
        case UserActionTypes.UPDATE_USER_AVATAR:
            return {...state, avatar: action.payload}; // Смена аватарки у пользователя
        case UserActionTypes.CREATE_USER: // Создание нового пользователя и сохранение в стейт
            return {
                nickname: action.payload.nickname,
                email: action.payload.email,
                type: action.payload.type,
                subscription: action.payload.subscription,
                isAuthenticated: true,
                balance: action.payload.balance,
                avatar: action.payload.avatar
            };
        case UserActionTypes.DELETE_USER: // Выход из аккаунта
            return {state: initialState}
        case UserActionTypes.ADD_USER_BALANCE: // Пополнение кошелька
            return {...state, balance: state.balance + action.payload};
        case UserActionTypes.REMOVE_USER_BALANCE: // Списание с кошелька
            return {...state, balance: state.balance - action.payload};
        default:
            return state
    }
}
