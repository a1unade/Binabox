import {IMenuItem} from "../../../interfaces/menu/IMenuItem.ts";
import {userType} from "../../usersTypes/userType.ts";

const Home: IMenuItem = {
    id: 1,
    name: 'Home',
    links: '/',
    namesub: null,
    user: [userType.Default, userType.Vip, userType.Premium, userType.Admin]
}

export default Home;