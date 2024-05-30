import {Swiper, SwiperSlide} from "swiper/react";
import {Autoplay} from "swiper/modules";
import {Link} from "react-router-dom";
import IShopProps from "../../interfaces/shop/IShopProps.ts";

const ItemSwiper = (props: IShopProps) => {
    const {data} = props
    return (
        <div className="col-md-6">
            <div className="content-left vertical-carousel">
                <div className="content-slide">
                    <div className="content-slide">
                        <Swiper
                            className="collection-1"
                            direction={"vertical"}
                            spaceBetween={30}
                            slidesPerView={3}
                            loop={true}
                            modules={[Autoplay]}
                            autoplay={{
                                delay: 1500,
                                disableOnInteraction: false,
                            }}
                        >
                            {
                                data.slice(0, 7).map(idx => (
                                    <SwiperSlide key={idx.id}>
                                        <div className="item">
                                            <div className="tf-product ">
                                                <div className="image">
                                                    <img src={idx.image} alt="Binabox"/>
                                                </div>
                                                <h6 className="name"><Link
                                                    to="/item-details">{idx.title}</Link></h6>
                                            </div>
                                        </div>
                                    </SwiperSlide>
                                ))
                            }
                        </Swiper>
                        <div style={{width: 20}}></div>
                        <Swiper
                            className="collection-1"
                            direction={"vertical"}
                            spaceBetween={30}
                            slidesPerView={3}
                            loop={true}
                            modules={[Autoplay]}
                            autoplay={{
                                delay: 2000,
                                disableOnInteraction: false,
                            }}
                        >
                            {
                                data.slice(3, 9).map(idx => (
                                    <SwiperSlide key={idx.id}>
                                        <div className="item">
                                            <div className="tf-product ">
                                                <div className="image">
                                                    <img src={idx.image} alt="Binabox"/>
                                                </div>
                                                <h6 className="name"><Link
                                                    to="/item-details">{idx.title}</Link></h6>
                                            </div>
                                        </div>
                                    </SwiperSlide>
                                ))
                            }
                        </Swiper>
                        <div style={{width: 20}}></div>
                        <Swiper
                            className="collection-1"
                            direction={"vertical"}
                            spaceBetween={30}
                            slidesPerView={3}
                            loop={true}
                            modules={[Autoplay]}
                            autoplay={{
                                delay: 1500,
                                disableOnInteraction: false,
                            }}
                        >
                            {
                                data.slice(7, 13).map(idx => (
                                    <SwiperSlide key={idx.id}>
                                        <div className="item">
                                            <div className="tf-product ">
                                                <div className="image">
                                                    <img src={idx.image} alt="Binabox"/>
                                                </div>
                                                <h6 className="name"><Link
                                                    to="/item-details">{idx.title}</Link></h6>
                                            </div>
                                        </div>
                                    </SwiperSlide>
                                ))
                            }
                        </Swiper>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default ItemSwiper;