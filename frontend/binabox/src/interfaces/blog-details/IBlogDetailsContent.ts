import IBlogDetailsPost from "./IBlogDetailsPost.ts";
import IBlogDetailsImages from "./IBlogDetailsImages.ts";

interface IBlogDetailsContent {
    id: number;
    p1: string;
    p2: string;
    p3: string;
    p4: string;
    p5: string;
    post: IBlogDetailsPost;
    images: IBlogDetailsImages;
    title1: string;
    title2: string;
    title3: string;
}

export default IBlogDetailsContent;