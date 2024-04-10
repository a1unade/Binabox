import { Accordion } from 'react-bootstrap-accordion';
import IFaqProps from "../../interfaces/faq/IFaqProps.ts";

const FaqsBlock = (props: IFaqProps) => {
    const {data} = props;

    return (
        <section className="tf-faq tf-section">
            <div className="tf-container">
                <div className="col-md-12 ">
                    <div className="tf-heading mb60 wow fadeInUp">
                        <h2 className="heading">FAQS</h2>
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