import PageTitle from "../../../components/pagetitle";
import RoadMapBlock from "../../../components/roadmap";
import {dataRoadmap} from "../../../fakeData/dataRoadMap.ts";

const RoadMap = () => {
    return (
        <div className='page-roadmap'>
            <PageTitle title='Road Map' />
            <RoadMapBlock data={dataRoadmap.data}/>
        </div>
    );
};

export default RoadMap;