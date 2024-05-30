import PageTitle from "../../../components/page-title";
import RoadMapBlock from "../../../components/road-map";
import {useSiteTypedSelector} from "../../../hooks/useTypedSelector.ts";

const RoadMap = () => {
    const {language} = useSiteTypedSelector(state => state.site);

    return (
        <div className='page-roadmap'>
            <PageTitle title={language === 'EN' ? 'ROAD MAP' : 'ДОРОЖНАЯ КАРТА'}/>
            <RoadMapBlock/>
        </div>
    );
};

export default RoadMap;