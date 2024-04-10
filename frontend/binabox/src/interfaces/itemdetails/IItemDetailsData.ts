import IItemDetailsCategories from "./IItemDetailsCategories.ts";

// Информация о предмете из магазина
interface IItemDetailsData {
    // ID
    id: number;
    // Картинка предмета
    img: string;
    // Название предмета
    title: string;
    // Описание предмета
    description: string;
    // Список с категориями предмета
    categories: IItemDetailsCategories[];
    // Ценв предмета
    price: number;
}

export default IItemDetailsData;