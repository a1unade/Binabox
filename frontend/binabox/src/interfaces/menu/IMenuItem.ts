import {ISubMenuItem} from "./ISubMenuItem.ts";
import {UserType} from "../../types/users/userType.ts";

// Элемент меню
export interface IMenuItem {
    // ID элемента меню
    id: number;
    // Название элемента меню
    name: string;
    // Название элемента меню на русском
    rusName: string;
    // Ссылка на элемент (для роутинга)
    links: string;
    // Элементы дропдауна
    namesub: ISubMenuItem[] | null;
    // Доступ пользователей
    user: UserType[]
}