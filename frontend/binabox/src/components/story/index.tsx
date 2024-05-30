import StoryFirstIcon from "../tsx-icons/story/StoryFirstIcon.tsx";
import StorySecondIcon from "../tsx-icons/story/StorySecondIcon.tsx";
import {useSiteTypedSelector} from "../../hooks/useTypedSelector.ts";
import {useEffect, useState} from "react";
import IStoryProps from "../../interfaces/story/IStoryProps.ts";
import apiClient from "../../utils/axiosClient.ts";
function Story() {
    const [data, setData] = useState<IStoryProps>();
    const {language} = useSiteTypedSelector(state => state.site);

    useEffect(() => {
        apiClient.get(`Site/about?lang=${language}`)
            .then(res => {
                if (res.data.responseType === 0) setData(res.data);
                else console.log("Error getting data.");
            })
    }, [language])

    if(!data) return null;

    return (
        <section className="tf-section tf-about">
            <div className="tf-container">
                <div className="row ">
                    <div className="col-md-12 ">
                        <StoryFirstIcon/>
                        <StorySecondIcon/>
                        <div className="tf-heading wow fadeInUp">
                            <h2 className="heading">{data.title}</h2>
                            <p className="sub-heading">{data.description}</p>
                        </div>

                        <div className="counter-wrap wow fadeInUp" data-wow-delay="0.2s">
                            {
                                data.aboutCounters.map(idx => (
                                    <div key={idx.id} className="tf-counter ">
                                        <h6>{idx.title}</h6>
                                        <div className="content">
                                            <span className="counter-number" data-to="2240" data-speed="2000" >{idx.number}</span>+
                                        </div>
                                    </div>
                                ))
                            }
                        </div>
                    </div>
                    <div className='work-list'>
                        {
                            data.aboutStats.map(idx => (
                                <div key={idx.id} className="col-xl-3 col-lg-6 col-md-6 col-sm-6 col-12">
                                    <div className="tf-step wow fadeInUp" data-wow-delay="0.2s">
                                        <div className="step-title">
                                            <div className="sub-number">0{idx.id}</div>
                                            <h3>{idx.title}</h3>
                                        </div>
                                        <p>{idx.text}</p>
                                    </div>
                                </div>
                            ) )
                        }
                    </div>
                </div>
            </div>
        </section>
    );
}

export default Story;