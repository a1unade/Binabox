import PageTitle from "../../../components/pagetitle";
import FaqsBlock from "../../../components/faq";
import dataFaqs from "../../../fakeData/dataFaq.ts";

const Faq = () => {
    return (
        <div className='page-faq'>
            <PageTitle title='HOW CAN WE HELP?'/>
            <FaqsBlock data={dataFaqs.data}/>
        </div>
    );
}

export default Faq;