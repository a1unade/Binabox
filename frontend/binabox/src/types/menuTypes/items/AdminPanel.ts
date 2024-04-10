import {IMenuItem} from "../../../interfaces/menu/IMenuItem.ts";
import {userType} from "../../usersTypes/userType.ts";

const AdminPanel: IMenuItem = {
    id: 6,
    name: 'Admin',
    links: '/admin',
    namesub: [
        {
            id: 1,
            name: 'Dashboard',
            links: '/admin/dashboard'
        },
        {
            id: 2,
            name: 'Shop Control',
            links: '/admin/shop'
        },
        {
            id: 3,
            name: 'Reviews Control',
            links: '/admin/reviews'
        },
        {
            id: 4,
            name: 'Site Control',
            links: '/admin/site'
        },
        {
            id: 5,
            name: 'Users Control',
            links: '/admin/users'
        },
        {
            id: 6,
            name: 'Users Feedback',
            links: '/admin/feedback'
        },
    ],
    user: [userType.Admin]
}

export default AdminPanel;