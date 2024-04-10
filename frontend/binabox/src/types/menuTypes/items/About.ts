import {IMenuItem} from "../../../interfaces/menu/IMenuItem.ts";
import {userType} from "../../usersTypes/userType.ts";

const About: IMenuItem = {
    id: 2,
    name: 'About',
    links: '/about',
    namesub: [
        {
            id: 1,
            name: 'Contact',
            links: '/about/contact'
        },
        {
            id: 2,
            name: 'Reviews',
            links: '/about/reviews'
        },
        {
            id: 3,
            name: 'Road Map',
            links: '/about/road-map'
        },
        {
            id: 4,
            name: 'FAQ',
            links: '/about/faq'
        },
    ],
    user: [userType.Default, userType.Vip, userType.Premium, userType.Admin]
}

export default About;