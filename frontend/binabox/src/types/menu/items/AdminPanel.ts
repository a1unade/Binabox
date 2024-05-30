import {IMenuItem} from "../../../interfaces/menu/IMenuItem.ts";
import {UserType} from "../../users/userType.ts";

const AdminPanel: IMenuItem = {
    id: 6,
    name: 'Admin',
    rusName: 'Админ',
    links: '/admin',
    namesub: [
        {
            id: 1,
            name: 'Dashboard',
            rusName: 'Дашборд',
            links: '/admin/dashboard'
        },
        {
            id: 2,
            name: 'Shop Control',
            rusName: 'Магазин',
            links: '/admin/shop'
        },
        {
            id: 3,
            name: 'Reviews Control',
            rusName: 'Отзывы',
            links: '/admin/reviews'
        },
        {
            id: 4,
            name: 'Site Control',
            rusName: 'Сайт',
            links: '/admin/site'
        },
        {
            id: 5,
            name: 'Users Control',
            rusName: 'Пользователи',
            links: '/admin/users'
        },
        {
            id: 6,
            name: 'Users Feedback',
            rusName: 'Заявки',
            links: '/admin/feedback'
        },
    ],
    user: [UserType.ADMIN]
}

export default AdminPanel;