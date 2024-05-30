import StoryFirstIcon from "../tsx-icons/story/StoryFirstIcon.tsx";
import StorySecondIcon from "../tsx-icons/story/StorySecondIcon.tsx";
import ISubscriptionTypesProps from "../../interfaces/payments/ISubscriptionTypesProps.ts";
import {useSiteTypedSelector, useUserTypedSelector} from "../../hooks/useTypedSelector.ts";
import {useEffect, useState} from "react";
import apiClient from "../../utils/axiosClient.ts";
import {useUserActions} from "../../hooks/useActions.ts";

const SubscriptionTypes = () => {
    const {language} = useSiteTypedSelector(state => state.site);
    const {subscription} = useUserTypedSelector(state => state.user);
    const [data, setData] = useState<ISubscriptionTypesProps>();
    const {updateSubscription, removeBalance} = useUserActions()
    const subscriptionTypes: { [key: string]: number } = {
        'FREE': 0,
        'VIP': 1,
        'PREMIUM': 2
    };

    useEffect(() => {
        apiClient.get(`Site/payments?lang=${language}`)
            .then(res => setData(res.data))
            .catch((e) => console.log(e));
    }, [language]);

    if (!data) return null;

    return (
        <section className="tf-section tf-about">
            <div className="tf-container">
                <div className="row ">
                    <div className="col-md-12 ">
                        <StoryFirstIcon/>
                        <StorySecondIcon/>
                    </div>
                    <div className="tf-heading wow fadeInUp">
                        <h2 className="heading">{data.title}</h2>
                        <p className="sub-heading">{data.description}</p>
                    </div>
                    <div className='subscriptions-list'>
                        {
                            data.subscriptions.map(idx => (
                                <div key={idx.id} className="subscription-item">
                                    <div className="tf-step wow fadeInUp" data-wow-delay="0.2s">
                                        <div className="step-title">
                                            <div className="sub-number">
                                                <div className='subscription-icons'>
                                                    <img src={idx.image} alt=''/>
                                                </div>
                                            </div>
                                        </div>
                                        <div className="subscription-properties">
                                            <h3 style={{marginBottom: 20}}>{idx.title}</h3>
                                            <ul>
                                                {
                                                    idx.properties.map((property) => <li style={{marginBottom: 20}}
                                                                                         key={property.id}>{property.text}</li>)
                                                }
                                            </ul>
                                        </div>
                                        {idx.price !== 0 ?
                                            <div className="subscription-price">
                                                <div className="group-btn">
                                                    {subscriptionTypes[idx.title] !== subscription ?
                                                        <div>
                                                            <div className="price">
                                                                <span
                                                                    className="heading">{language === 'EN' ? 'PRICE:' : 'ЦЕНА:'}</span>
                                                                <span>{idx.price} ETH</span>
                                                            </div>
                                                            <div className="tf-button opensea" onClick={() =>  {
                                                                updateSubscription(idx.price, subscriptionTypes[idx.title])
                                                                removeBalance(idx.price)}}>
                                                                <i className="icon-fl-bag"></i>{language === 'EN' ? 'SUBSCRIBE' : 'ПОДПИСАТЬСЯ'}
                                                            </div>
                                                        </div>
                                                        :
                                                        <div>
                                                        <p>{language === 'EN' ? 'CURRENT PLAN' : 'ТЕКУЩАЯ ПОДПИСКА'}</p>
                                                        </div>}
                                                </div>
                                            </div>
                                            :
                                            null
                                        }
                                    </div>
                                </div>
                            ))
                        }
                    </div>
                </div>
            </div>
        </section>
    );
};

export default SubscriptionTypes;