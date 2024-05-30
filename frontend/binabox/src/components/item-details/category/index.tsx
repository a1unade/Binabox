import IItemDetailsCategories from "../../../interfaces/item-details/IItemDetailsCategories.ts";

const Category = (category: IItemDetailsCategories) => {
    const {id, name, info} = category
    return (
        <div key={id} className="infor-item-box">
            <div className="category">{name}</div>
            <h4 className="name">{info}</h4>
        </div>
    );
};

export default Category;