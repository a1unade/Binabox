import IStoryData from "./IStoryData.ts";
import IDataCounter from "./IDataCounter.ts";

// Данные для страницы about
interface IStoryProps {
    // Заголовок
    title: string;
    // Описание
    description: string;
    // Преимущества сайта
    aboutStats: IStoryData[];
    // Статистика сайта
    aboutCounters: IDataCounter[]
}

export default IStoryProps;