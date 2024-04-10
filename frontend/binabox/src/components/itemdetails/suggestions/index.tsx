import { Navigation , Autoplay   } from 'swiper/modules';
import { Swiper, SwiperSlide } from 'swiper/react';
import { Link } from 'react-router-dom';
import IShopProps from "../../../interfaces/shop/IShopProps.ts";


function Suggestions(props: IShopProps) {
    const {data} = props;
    return (
        <section className="tf-collection-ss">
            <div className="tf-container">
                <div className="row">
                    <div className="col-md-12 wow fadeInUp">
                        <Swiper
                            spaceBetween={30}
                            breakpoints={{
                                0: {
                                    slidesPerView: 1,
                                },
                                500: {
                                    slidesPerView: 2,
                                },
                                768: {
                                    slidesPerView: 3,
                                },
                                991: {
                                    slidesPerView: 4,
                                },
                            }}
                            autoplay={{
                                delay: 2500,
                                disableOnInteraction: false,
                            }}
                            loop={true}

                            modules={[Autoplay, Navigation]}
                            className="collection-1 visible"
                        >

                            {
                                data.slice(20,26).map(idx => (
                                    <SwiperSlide key={idx.id}>
                                        <Link to={`/shop/item/${idx.id}`}>
                                            <div className="item" style={{cursor: 'pointer'}}>
                                                <div className="tf-product ">
                                                    <div className="image">
                                                        <img src={idx.img} alt="Binabox"/>
                                                    </div>
                                                    <h6 className="name"><Link to="/item-details">{idx.title}</Link>
                                                    </h6>
                                                </div>
                                            </div>
                                        </Link>
                                    </SwiperSlide>
                                ))
                            }
                        </Swiper>
                    </div>
                </div>
            </div>
        </section>
    );
}

export default Suggestions;