import ICreateUserAction from "../../interfaces/user-actions/ICreateUserAction.ts";
import IUpdateUserNickname from "../../interfaces/user-actions/IUpdateUserNickname.ts";
import IUpdateUserEmail from "../../interfaces/user-actions/IUpdateUserEmail.ts";
import IUpdateUserUserType from "../../interfaces/user-actions/IUpdateUserUserType.ts";
import IUpdateUserSubscriptionType from "../../interfaces/user-actions/IUpdateUserSubscriptionType.ts";
import IUpdateUserAvatar from "../../interfaces/user-actions/IUpdateUserAvatar.ts";
import IDeleteUserAction from "../../interfaces/user-actions/IDeleteUserAction.ts";
import IAddUserBalance from "../../interfaces/user-actions/IAddBalance.ts";
import IRemoveUserBalance from "../../interfaces/user-actions/IRemoveUserBalance.ts";

// Перечисление всех типов actions для user reducer
export enum UserActionTypes {
    CREATE_USER = 'CREATE_USER', // Создание redux-state пользователя при регистрации/входе
    UPDATE_USER_NICKNAME = 'UPDATE_USER_NICKNAME', // Обновление поля никнейма пользователя у redux-state
    UPDATE_USER_EMAIL = 'UPDATE_USER_EMAIL', // Обновление поля почты пользователя у redux-state
    UPDATE_USER_USER_TYPE = 'UPDATE_USER_USER_TYPE', // Обновление поля типа пользователя у redux-state
    UPDATE_USER_SUBSCRIPTION_TYPE = 'UPDATE_USER_SUBSCRIPTION_TYPE', // Обновление типа подписки пользователя у redux-state
    UPDATE_USER_AVATAR = 'UPDATE_USER_AVATAR', // Смена аватарки у пользователя
    DELETE_USER = 'DELETE_USER', // Выход пользователя из аккаунта
    ADD_USER_BALANCE = 'ADD_USER_BALANCE', // Добавление баланса кошелька
    REMOVE_USER_BALANCE = 'REMOVE_USER_BALANCE', // Списание с кошелька
}

export type UserAction =
    ICreateUserAction
    | IUpdateUserNickname
    | IUpdateUserEmail
    | IUpdateUserUserType
    | IUpdateUserSubscriptionType
    | IUpdateUserAvatar
    | IDeleteUserAction
    | IAddUserBalance
    | IRemoveUserBalance;