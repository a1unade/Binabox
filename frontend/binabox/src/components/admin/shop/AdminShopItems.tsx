import {useEffect, useState} from "react";
import apiClient from "../../../utils/axiosClient.ts";
import IShopData from "../../../interfaces/shop/IShopData.ts";

const AdminShopItems = () => {
    const [items, setItems] = useState<IShopData[]>([]);
    useEffect(() => {
         apiClient.get('/shop/getAllShopItems')
            .then(res => {
                if (res.data.length !== 0) setItems(res.data);
                else console.log("Error getting all shop items from shop");
            });
    }, [])

    const deleteItemAsync = async (id: number) => {
        apiClient.delete(`Shop/DeleteItem/${id}`)
            .then(res => {
                if (res.data.responseType === 0) console.log("Item deleted");
                else console.log("Error deleting item");
            })
    }

    if(!items){
        return <div>Loading...</div>;
    }
    else {
        return (
            <div className="admin-shop-items">
                <div className="admin-shop-item" style={{width: '85%'}}>
                    <div className="admin-shop-header"><span>Id</span></div>
                    <div className="admin-shop-header"><span>Title</span></div>
                    <div className="admin-shop-header"><span>Image</span></div>
                    <div className="admin-shop-header"><span></span></div>
                </div>
                {items.map((item) => (
                    <div className="admin-shop-item" key={item.id} style={{width: '95%'}}>
                        <div className="admin-shop-header"><span>{item.id}</span></div>
                        <div className="admin-shop-header"><span>{item.title}</span></div>
                        <div className="admin-shop-header"><img src={item.image} alt={'img'}/></div>
                        <div className="admin-shop-header"><button onClick={async () => await deleteItemAsync(item.id)} className="tf-button">Delete</button></div>
                    </div>
                ))}
            </div>
        );
    }
};

export default AdminShopItems;