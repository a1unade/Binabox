import { Accordion } from 'react-bootstrap-accordion';
import {useSiteTypedSelector} from "../../hooks/useTypedSelector.ts";
import {useEffect, useState} from "react";
import IFaqData from "../../interfaces/faq/IFaqData.ts";
import apiClient from "../../utils/axiosClient.ts";

const FaqsBlock = () => {
    const [data, setData] = useState<IFaqData[]>([]);
    const {language} = useSiteTypedSelector(state => state.site);

    useEffect(() => {
        apiClient.get(`Site/faq?lang=${language}`)
            .then(res => setData(res.data));
    }, [language])

    return (
        <section className="tf-faq tf-section">
            <div className="tf-container">
                <div className="col-md-12 ">
                    <div className="tf-heading mb60 wow fadeInUp">
                        <h2 className="heading">{language === 'EN' ? 'FAQS' : 'ВОПРОСЫ'}</h2>
                    </div>
                </div>
                <div className="row justify-content-center">
                    <div className="col-md-8 wow fadeInUp">
                        {
                            data.slice(0, 4).map(idx => (
                                <div className='flat-toggle h6 tf-flat-accordion2'>
                                    <Accordion show={idx.show} key={idx.id} title={idx.title}>
                                        <p className="toggle-content">{idx.text} </p>
                                    </Accordion>
                                </div>
                            ))
                        }
                    </div>
                </div>
            </div>
        </section>
    );
}

export default FaqsBlock;