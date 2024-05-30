import IRoadMapDataList from "./IRoadMapDataList.ts";

// Этап road map
interface IRoadMapData {
    // ID
    id: number;
    // Стиль для этапа
    class: string;
    // Заголовок этапа
    title: string;
    // Описание этапа
    list: IRoadMapDataList[];
}

export default IRoadMapData;