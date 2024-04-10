
// Вопрос
interface IFaqData {
    // ID
    id: number;
    // Раскрыт или нет
    show: boolean | undefined;
    // Заголовок вопроса
    title: string;
    // Описание вопрооса
    text: string;
}

export default IFaqData;