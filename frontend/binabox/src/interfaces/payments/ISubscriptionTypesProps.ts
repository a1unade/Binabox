import ISubscriptionType from "./ISubscriptionType.ts";

interface ISubscriptionTypesProps {
    title: string;
    description: string;
    subscriptions: ISubscriptionType[];
}

export default ISubscriptionTypesProps;