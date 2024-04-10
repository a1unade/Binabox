import IReviewsData from "./IReviewsData.ts";
import IReviewsTitle from "./IReviewsTitle.ts";

// Отзывы на странице reviews
interface IReviewsProps {
    data: IReviewsData[];
    titleData: IReviewsTitle;
}

export default IReviewsProps;