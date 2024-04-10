import PageTitle from "../../components/pagetitle";
import Story from "../../components/story";
import {dataStory} from "../../fakeData/dataStory.ts";
import Team from "../../components/team";
import dataTeam from "../../fakeData/dataTeam.ts";


const About = () => {
    return (
        <div className='page-about home-1'>
            <PageTitle title='About Us' />
            <Story data={dataStory.data} dataCounter={dataStory.dataCounter} dataAbout={dataStory.dataAbout}/>
            <Team data={dataTeam.data}/>
        </div>
    );
};

export default About;