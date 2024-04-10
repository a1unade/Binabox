import {IMenuItem} from "../../../interfaces/menu/IMenuItem.ts";
import {userType} from "../../usersTypes/userType.ts";

const Payments: IMenuItem = {
    id: 4,
    name: 'Payments',
    links: '/payments',
    namesub: null,
    user: [userType.Default, userType.Vip, userType.Premium, userType.Admin]
}

export default Payments;