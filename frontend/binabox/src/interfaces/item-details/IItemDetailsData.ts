import IItemDetailsCategories from "./IItemDetailsCategories.ts";
import IShopData from "../shop/IShopData.ts";

// Информация о предмете из магазина
interface IItemDetailsData {
    // ID
    id: number;
    // Картинка предмета
    image: string;
    // Название предмета
    title: string;
    // Описание предмета
    description: string;
    // Список с категориями предмета
    categories: IItemDetailsCategories[];
    // Цена предмета
    price: number;
    // Дополнительные предложения
    suggestions: IShopData[];
}

export default IItemDetailsData;