import {Dispatch} from "redux";
import {UserAction, UserActionTypes} from "../../types/actions/userActions.ts";
import apiClient from "../../utils/axiosClient.ts";

// Обновление аватарки у redux state пользователя
export const changeAvatar = (avatar: string) => {
    return async (dispatch: Dispatch<UserAction>) => {
        try {
            const response = await apiClient.post(`User/changeAvatar`, {
                avatar: avatar,
                userId: document.cookie.split("=")[1]
            });

            if (response.status === 200) {
                dispatch({type: UserActionTypes.UPDATE_USER_AVATAR, payload: avatar});
            } else {
                console.log("Error");
            }
        } catch (e) {
            console.log(e);
        }
    }
}

// Создание стейта пользователя по почте (при регистрации)
export const createUserByEmail = (email: string) => {
    return async (dispatch: Dispatch<UserAction>) => {
        try {
            const encodedEmail = encodeURIComponent(email);
            const response = await apiClient.get(`User/getUserByEmail/${encodedEmail}`);

            if (response.data.responseType === 0) {
                dispatch({
                    type: UserActionTypes.CREATE_USER, payload: {
                        nickname: response.data.nickname,
                        email: response.data.email,
                        type: response.data.type,
                        subscription: response.data.subscription,
                        isAuthenticated: true,
                        balance: response.data.balance,
                        avatar: response.data.avatar
                    }
                });
            } else {
                console.log("Error");
            }
        } catch (e) {
            console.log(e);
        }
    }
}

// Создание стейта пользователя по ID (cookie)
export const createUserById = (id: string) => {
    return async (dispatch: Dispatch<UserAction>) => {
        try {
            const response = await apiClient(`User/getUserById/${id}`);
            if (response.data.responseType === 0) {
                dispatch({
                    type: UserActionTypes.CREATE_USER, payload: {
                        nickname: response.data.nickname,
                        email: response.data.email,
                        type: response.data.type,
                        subscription: response.data.subscription,
                        isAuthenticated: true,
                        balance: response.data.balance,
                        avatar: response.data.avatar
                    }
                });
            } else {
                console.log("Error");
            }
        } catch (e) {
            console.log(e);
        }
    }
}

// Смена никнейма у пользвателя
export const changeNickname = (newNickname: string) => {
    return async (dispatch: Dispatch<UserAction>) => {
        try {
            const response = await apiClient.post(`User/changeNickname`, {
                nickname: newNickname,
                userId: document.cookie.split("=")[1]
            });

            if (response.status === 200) {
                dispatch({type: UserActionTypes.UPDATE_USER_NICKNAME, payload: newNickname});
            } else {
                console.log("Error");
            }
        } catch (e) {
            console.log(e);
        }
    }
}

// Пополнение кошелька
export const addBalance = (balance: number) => {
    return async (dispatch: Dispatch<UserAction>) => {
        try {
            const response = await apiClient.post(`User/addFunds`, {
                value: balance,
                userId: document.cookie.split("=")[1]
            });

            if (response.data.responseType === 0) {
                dispatch({type: UserActionTypes.ADD_USER_BALANCE, payload: balance});
            } else {
                console.log("Error");
            }
        } catch (e) {
            console.log(e);
        }
    }
}

// Списание с кошелька
export const removeBalance = (balance: number) => {
    return async (dispatch: Dispatch<UserAction>) => {
        try {
            const response = await apiClient.post(`User/removeFunds`, {
                value: balance,
                userId: document.cookie.split("=")[1]
            });

            if (response.data.responseType === 0) {
                dispatch({type: UserActionTypes.REMOVE_USER_BALANCE, payload: balance});
            } else {
                console.log("Error");
            }
        } catch (e) {
            console.log(e);
        }
    }
}

export const updateSubscription = (price: number, subscription: number) => {
    return async (dispatch: Dispatch<UserAction>) => {
        try {
            const response = await apiClient.post(`User/buySubscription`, {
                userId: document.cookie.split("=")[1],
                price: price,
                subscriptionType: subscription
            });

            if (response.data.responseType === 0) {
                dispatch({type: UserActionTypes.UPDATE_USER_SUBSCRIPTION_TYPE, payload: subscription});
            } else {
                console.log("Error");
            }
        } catch (e) {
            console.log(e);
        }
    }
}

export const logout = () => {
    return async (dispatch: Dispatch<UserAction>) => {
        try {
            dispatch({type: UserActionTypes.DELETE_USER});
            document.cookie = "auth=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
            await apiClient.post('Auth/logout');
        } catch (e) {
            console.log(e);
        }
    }
}