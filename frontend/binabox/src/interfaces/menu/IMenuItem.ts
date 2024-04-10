import {ISubMenuItem} from "./ISubMenuItem.ts";
import {userType} from "../../types/usersTypes/userType.ts";

// Элемент меню
export interface IMenuItem {
    // ID элемента меню
    id: number;
    // Название элемента меню
    name: string;
    // Ссылка на элемент (для роутинга)
    links: string;
    // Элементы дропдауна
    namesub: ISubMenuItem[] | null;
    // Доступ пользователей
    user: userType[]
}