import {IMenuItem} from "../../../interfaces/menu/IMenuItem.ts";
import {userType} from "../../usersTypes/userType.ts";

const Blog: IMenuItem = {
    id: 5,
    name: 'Blog',
    links: '/blog',
    namesub: null,
    user: [userType.Default, userType.Vip, userType.Premium, userType.Admin]
}

export default Blog;