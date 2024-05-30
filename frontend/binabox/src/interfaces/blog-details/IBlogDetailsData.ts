import IBlogDetailsContent from "./IBlogDetailsContent.ts";
import IBlogDetailsTags from "./IBlogDetailsTags.ts";
import IBlogDetailsChildren from "./IBlogDetailsChildren.ts";

interface IBlogDetailsData {
    id: number;
    category: string;
    user: string;
    date: string;
    content: IBlogDetailsContent;
    tags: IBlogDetailsTags;
    previous: IBlogDetailsChildren;
    next: IBlogDetailsChildren;
}

export default IBlogDetailsData;