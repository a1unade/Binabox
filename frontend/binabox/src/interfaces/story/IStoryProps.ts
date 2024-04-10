import IStoryData from "./IStoryData.ts";
import IDataCounter from "./IDataCounter.ts";
import IAboutData from "./IAboutData.ts";

// Данные для страницы about
interface IStoryProps {
    // Преимущества сайта
    data: IStoryData[];
    // Статистика сайта
    dataCounter: IDataCounter[]
    // Информация о сайте
    dataAbout: IAboutData;
}

export default IStoryProps;