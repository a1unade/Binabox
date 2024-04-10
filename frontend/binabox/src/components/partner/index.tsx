import IPartnerProps from "../../interfaces/partner/IPartnerProps.ts";
import PartnerBackgroundIcon from "../tsx-icons/partner/PartnerBackgroundIcon.tsx";
import PartnerSlider from "./partnerswiper";

const Partner = (props: IPartnerProps) => {
    const {data} = props;
    return (
        <section className=" tf-section tf-partner-sec">
            <div className="icon">
                <PartnerBackgroundIcon/>
            </div>
            <div className="tf-container">
                <div className="row">
                    <div className="col-md-12 ">
                        <div className="tf-heading mb60 wow fadeInUp">
                            <h2 className="heading"><span>BINABOX</span> PARTNER</h2>
                        </div>
                    </div>
                    <div className="col-md-12 wow fadeInUp">
                        <PartnerSlider data={data.slice(0, 6)} delay={1500}/>
                    </div>
                    <div className="col-md-12 wow fadeInUp">
                        <PartnerSlider data={data.slice(6, 12)} delay={2000}/>
                    </div>
                    <div className="col-md-12 wow fadeInUp">
                        <PartnerSlider data={data.slice(12, 18)} delay={1500}/>
                    </div>
                </div>
            </div>
        </section>
    );
}

export default Partner;