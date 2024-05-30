import {UserActionTypes} from "../../types/actions/userActions.ts";
import {SubscriptionType} from "../../types/users/subscriptionType.ts";

interface IUpdateUserSubscriptionType{
    type: UserActionTypes.UPDATE_USER_SUBSCRIPTION_TYPE;
    // Новый тип подписки у пользователя
    payload: SubscriptionType
}

export default IUpdateUserSubscriptionType;