import {IMenuItem} from "../../../interfaces/menu/IMenuItem.ts";
import {userType} from "../../usersTypes/userType.ts";

const Shop: IMenuItem = {
    id: 3,
    name: 'Shop',
    links: '/shop',
    namesub: null,
    user: [userType.Default, userType.Vip, userType.Premium, userType.Admin]
}

export default Shop;