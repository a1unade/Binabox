import img1 from '../../assets/images/slider/slider-1.jpg'
import img2 from '../../assets/images/slider/slider-2.jpg'
import img3 from '../../assets/images/slider/slider-3.jpg'
import img4 from '../../assets/images/slider/slider-9.jpg'
import img5 from '../../assets/images/slider/slider-10.jpg'
import img6 from '../../assets/images/slider/slider-11.jpg'
import Button02 from '../button/Button02';
import React, {useEffect, useState} from "react";
import IBannerData from "../../interfaces/banner/IBannerData.ts";
import {useSiteTypedSelector, useUserTypedSelector} from "../../hooks/useTypedSelector.ts";
import apiClient from "../../utils/axiosClient.ts";

const Banner = (props: {setModalActive: React.Dispatch<React.SetStateAction<boolean>>}) => {
    const {setModalActive} = props;
    const [data, setData] = useState<IBannerData>();
    const {isAuthenticated} = useUserTypedSelector(state => state.user);
    const {language} = useSiteTypedSelector(state => state.site);

    useEffect(() => {
        apiClient.get(`Site/banner?lang=${language}`)
            .then(res => {
                setData(res.data);
            })
    }, [language]);

    if (!data) return null;

    return (
        <section className="tf-slider">
            <div className="container-fluid">
                <div className="row">
                    <div className="col-md-12">
                        <div className="slider-item">
                            <div className="tf-slider-item">
                                <div className="content-inner">
                                    {language == 'EN' ?
                                        <>
                                            <div className="text-typing">
                                                <h1 className="heading mb0">WITH</h1>
                                                <div className="animate-contain">
                                                    <div className="animated-text">
                                                        <span>Binabox</span>
                                                        <span>Binabox</span>
                                                        <span>Binabox</span>
                                                    </div>
                                                </div>
                                            </div>
                                            <h1 className="heading">{data.title}</h1>
                                            <p className="sub-heading">{data.description}</p>
                                        </>
                                        :
                                        <>
                                            <h1 className="heading">{data.title}</h1>
                                            <div className="text-typing">
                                                <h1 className="heading mb0">С</h1>
                                                <div className="animate-contain">
                                                    <div className="animated-text">
                                                        <span>Binabox</span>
                                                        <span>Binabox</span>
                                                        <span>Binabox</span>
                                                    </div>
                                                </div>
                                            </div>
                                            <p className="sub-heading">{data.description}</p>
                                        </>
                                    }
                                    {isAuthenticated ?
                                        <div className="btn-slider ">
                                            <div onClick={() => setModalActive(true)} className="tf-button"
                                                 style={{cursor: 'pointer'}}>{language === 'EN' ? 'CONNECT WALLET' : 'ПОДКЛЮЧИТЕ КОШЕЛЕК'}
                                            </div>
                                            <Button02 path='/shop'
                                                      title={language === 'EN' ? 'WHITELIST NOW' : 'МАГАЗИН'}/>
                                        </div>
                                        :
                                        null
                                    }
                                </div>
                                <div className="content-right ">
                                    <div className="content-slide">
                                        <div className="image">
                                            <img src={img1} alt="Binabox" className="img-slider-1"/>
                                            <img src={img4} alt="Binabox" className="fadeInClass"/>
                                        </div>
                                        <div className="image s1">
                                            <img src={img2} alt="Binabox" className="img-slider-1"/>
                                            <img src={img5} alt="Binabox" className="fadeInClass"/>
                                        </div>
                                        <div className="image s1">
                                            <img src={img3} alt="Binabox" className="img-slider-1"/>
                                            <img src={img6} alt="Binabox" className="fadeInClass"/>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div className="col-md-12">
                    </div>
                </div>
            </div>
        </section>
    );
}

export default Banner;