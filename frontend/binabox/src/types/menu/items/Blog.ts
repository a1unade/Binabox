import {IMenuItem} from "../../../interfaces/menu/IMenuItem.ts";
import {UserType} from "../../users/userType.ts";

const Blog: IMenuItem = {
    id: 5,
    name: 'Blog',
    rusName: 'Новости',
    links: '/blog',
    namesub: null,
    user: [UserType.UNDEFINED, UserType.USER, UserType.ADMIN]
}

export default Blog;