interface ISubscriptionType{
    id: number;
    image: string;
    title: string;
    price: number;
    properties: {
        id: number;
        text: string;
    }[]
}

export default ISubscriptionType;