import PageTitle from "../../../components/page-title";
import FaqsBlock from "../../../components/faq";
import {useSiteTypedSelector} from "../../../hooks/useTypedSelector.ts";

const Faq = () => {
    const {language} = useSiteTypedSelector(state => state.site);

    return (
        <div className='page-faq'>
            <PageTitle title={language === 'EN' ? 'HOW CAN WE HELP?' : 'КАК МЫ МОЖЕМ ПОМОЧЬ?'}/>
            <FaqsBlock/>
        </div>
    );
}

export default Faq;