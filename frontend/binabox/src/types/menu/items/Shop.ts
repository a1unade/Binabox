import {IMenuItem} from "../../../interfaces/menu/IMenuItem.ts";
import {UserType} from "../../users/userType.ts";

const Shop: IMenuItem = {
    id: 3,
    name: 'Shop',
    rusName: 'Магазин',
    links: '/shop',
    namesub: null,
    user: [UserType.USER, UserType.ADMIN]
}

export default Shop;