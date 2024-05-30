import PageTitle from "../../components/page-title";
import Story from "../../components/story";
import Team from "../../components/team";
import {useSiteTypedSelector} from "../../hooks/useTypedSelector.ts";


const About = () => {
    const {language} = useSiteTypedSelector(state => state.site);

    return (
        <div className='page-about home-1'>
            <PageTitle title={language === 'EN' ? 'ABOUT US' : 'О НАС'} />
            <Story/>
            <Team/>
        </div>
    );
};

export default About;