import IReviewsData from "./IReviewsData.ts";

// Отзывы на странице reviews
interface IReviewsProps {
    reviews: IReviewsData[];
    title: string;
    description: string;
}

export default IReviewsProps;