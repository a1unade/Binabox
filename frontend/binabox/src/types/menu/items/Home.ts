import {IMenuItem} from "../../../interfaces/menu/IMenuItem.ts";
import {UserType} from "../../users/userType.ts";

const Home: IMenuItem = {
    id: 1,
    name: 'Home',
    rusName: 'Главная',
    links: '/',
    namesub: null,
    user: [UserType.UNDEFINED, UserType.USER, UserType.ADMIN]
}

export default Home;