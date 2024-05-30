// Дропдаун у элемента меню
export interface ISubMenuItem {
    // ID элемента
    id: number;
    // Название элемента
    name: string;
    // Название элемента на русском
    rusName: string;
    // Ссылка на элемент (для роутинга)
    links: string
}
