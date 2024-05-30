import { Link } from 'react-router-dom';
import {useEffect, useState} from "react";
import {useSiteTypedSelector} from "../../hooks/useTypedSelector.ts";
import apiClient from "../../utils/axiosClient.ts";
import IWorkData from "../../interfaces/work/IWorkData.ts";

const Work = () => {
    const [data, setData] = useState<IWorkData[]>();
    const {language} = useSiteTypedSelector(state => state.site);

    useEffect(() => {
        apiClient.get(`Site/works?lang=${language}`)
            .then(res => {
                setData(res.data);
            })
    }, [language]);

    if (!data) return null;

    return (
        <section className="tf-section section-work">
            <div className="tf-container">
                <div className="row">
                    <div className="col-md-12 ">
                        <div className="tf-heading mb60 wow fadeInUp">
                            {language === 'EN' ?
                                <h2 className="heading">HOW TO <span> BINABOX </span>WORK</h2>
                                :
                                <h2 className="heading">КАК РАБОТАЕТ <span> BINABOX </span></h2>
                            }
                        </div>
                    </div>
                    <div className="work-list">
                        {
                            data.map(idx => (
                                <div key={idx.id} className="col-xl-3 col-lg-6 col-md-6">
                                    <div className="tf-work wow fadeInUp" data-wow-delay="0.3s">
                                        <div className="image">
                                            <img id="work-2" src={idx.image} alt="Binabox" />
                                        </div>
                                        <h6 className="title"><Link to="#">{idx.title}</Link></h6>
                                        <p className="content">{idx.text}</p>
                                    </div>
                                </div>
                            ))
                        }
                    </div>
                </div>
            </div>
        </section>
    );
}

export default Work;