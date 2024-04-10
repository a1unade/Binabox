import IItemDetailsData from "./IItemDetailsData.ts";
import IShopData from "../shop/IShopData.ts";

// Предмет на странице item details
interface IItemDetailsProps {
    data: IItemDetailsData;
    suggestions: IShopData[];
}

export default IItemDetailsProps;