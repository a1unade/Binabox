import {IMenuItem} from "../../../interfaces/menu/IMenuItem.ts";
import {UserType} from "../../users/userType.ts";

const About: IMenuItem = {
    id: 2,
    name: 'About',
    rusName: 'О нас',
    links: '/about',
    namesub: [
        {
            id: 1,
            name: 'Contact',
            rusName: 'Контакты',
            links: '/about/contact'
        },
        {
            id: 2,
            name: 'Reviews',
            rusName: 'Отзывы',
            links: '/about/reviews'
        },
        {
            id: 3,
            name: 'Road Map',
            rusName: 'Дорожная карта',
            links: '/about/road-map'
        },
        {
            id: 4,
            name: 'FAQs',
            rusName: 'Вопросы',
            links: '/about/faq'
        },
    ],
    user: [UserType.UNDEFINED, UserType.USER, UserType.ADMIN]
}

export default About;