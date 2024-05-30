import {Navigation, Autoplay} from 'swiper/modules';
import {Swiper, SwiperSlide} from 'swiper/react';
import IPartnerProps from "../../../interfaces/partner/IPartnerProps.ts";
const PartnerSlider = ( props: IPartnerProps) => {
    const {data, delay} = props;

    return (
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
            effect="fade"
            speed={1000}
            autoplay={{
                delay: delay,
                disableOnInteraction: false,
            }}
            loop={true}
            modules={[Autoplay, Navigation]}
            className="partner"
        >
            {data.map(idx => (
                <SwiperSlide key={idx.id}>
                    <div className="slider-item">
                        <div className="tf-partner">
                            <img src={idx.img} alt="Binabox"/>
                        </div>
                    </div>
                </SwiperSlide>
            ))}
        </Swiper>
    );
}

export default PartnerSlider;