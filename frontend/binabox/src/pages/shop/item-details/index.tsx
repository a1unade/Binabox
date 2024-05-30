import {Link, useNavigate, useParams} from 'react-router-dom';
import PageTitle from "../../../components/page-title";
import Category from "../../../components/item-details/category";
import Suggestions from "../../../components/item-details/suggestions";
import {useEffect, useState} from "react";
import IItemDetailsData from "../../../interfaces/item-details/IItemDetailsData.ts";
import apiClient from "../../../utils/axiosClient.ts";
import {useSiteTypedSelector, useUserTypedSelector} from "../../../hooks/useTypedSelector.ts";

const ItemDetails = () => {
    const [item, setItem] = useState<IItemDetailsData>()
    const {id} = useParams();
    const {email, balance} = useUserTypedSelector(state => state.user);
    const {language} = useSiteTypedSelector(state => state.site);
    const navigate = useNavigate();

    useEffect(() => {
        apiClient.get(`Shop/getItemDetails?id=${id}`)
            .then(res => {
                if (res.data.responseType === 0) setItem(res.data);
            })
    }, [id])

    const buyItem = async () => {
        try {
            if (item && item.price <= balance) {
                const response = await apiClient.post(`Shop/buyItem`, {
                            id: item.id,
                            userEmail: email
                        },
                        {
                            headers: {
                                'Accept': '*/*',
                                'Content-Type': 'application/json'
                            }
                        }
                    );
                if (response.data.responseType === 0) {
                    await apiClient.post(`User/removeFunds`, {
                            userId: document.cookie.split("=")[1],
                            value: item.price
                        },
                        {
                            headers: {
                                'Accept': '*/*',
                                'Content-Type': 'application/json'
                            }
                        }
                    );
                }
                else {
                    navigate('/error');
                }
            }
        } catch
            (error) {
            console.error('Ошибка при регистрации:', error);
            navigate('/error');
        }
    }

    if (!item) return <div>Loading...</div>;

    return (
        <div className='page-collection'>
            <PageTitle title={language ? 'ITEM DETAILS' : 'ДЕТАЛЬНАЯ ИНФОРМАЦИЯ'}/>
            <section className=" tf-item-detail ">
                <div className="tf-container">
                    <div className="item-details">
                        <div className="item-details-img">
                            <div className="tf-item-detail-image" style={{width: 700}}>
                                <img style={{width: '100%', height: '100%'}} src={item.image} alt="Binabox"/>
                            </div>
                        </div>
                        <div className="col-lg-6 col-md-12">
                            <div className="tf-item-detail-inner">
                                <h2 className="title">{item.title}</h2>
                                <p className="des">{item.description}</p>
                                <div className="infor-item-wrap">
                                    {item.categories.map((category) =>
                                        <Category id={category.id} name={category.name} info={category.info}
                                                  key={category.id}/>
                                    )}
                                </div>
                                <div className="price">
                                    <span className="heading">PRICE: </span>
                                    <span>{item.price} ETH</span>
                                </div>
                                <div className="group-btn">
                                    <Link to="" onClick={async () => await buyItem()} className="tf-button opensea"><i
                                        className="icon-fl-bag"></i> BUY</Link>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <Suggestions data={item.suggestions}/>
        </div>
    );
}

export default ItemDetails;