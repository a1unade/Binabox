import {IMenuItem} from "../../../interfaces/menu/IMenuItem.ts";
import {UserType} from "../../users/userType.ts";

const Payments: IMenuItem = {
    id: 4,
    name: 'Payments',
    rusName: 'Платежи',
    links: '/payments',
    namesub: null,
    user: [UserType.USER, UserType.ADMIN]
}

export default Payments;