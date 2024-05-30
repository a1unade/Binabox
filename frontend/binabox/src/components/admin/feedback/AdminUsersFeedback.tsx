import {useEffect, useState} from 'react';
import apiClient from "../../../utils/axiosClient.ts";
import IUserFeedback from "../../../interfaces/feedback/IUserFeedback.ts";

const AdminUsersFeedback = () => {
    const [items, setItems] = useState<IUserFeedback[]>([]);
    useEffect(() => {
        apiClient.get('/Site/getFeedback')
            .then(res => {
                if (res.data.length !== 0) setItems(res.data);
                else console.log("Error getting all users feedback");
            });
    }, []);

    if(!items){
        return <div>Loading...</div>;
    }

    else {
        return (
            <div className="admin-shop-items">
                <div className="admin-shop-item" style={{width: '85%'}}>
                    <div className="admin-shop-header"><span>Name</span></div>
                    <div className="admin-shop-header"><span>Email</span></div>
                    <div className="admin-shop-header"><span>Message</span></div>
                    <div className="admin-shop-header"><span></span></div>
                </div>
                {items.map((item) => (
                    <div className="admin-shop-item" key={item.email} style={{width: '95%'}}>
                        <div className="admin-shop-header"><span>{item.name}</span></div>
                        <div className="admin-shop-header"><span>{item.email}</span></div>
                        <div className="admin-shop-header"><span>{item.message}</span></div>
                    </div>
                ))}
            </div>
        );
    }
};

export default AdminUsersFeedback;