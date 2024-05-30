import RoadMapShapeFirstIcon from "../tsx-icons/roadmap/RoadMapShapeFirstIcon.tsx";
import RoadMapShapeSecondIcon from "../tsx-icons/roadmap/RoadMapShapeSecondIcon.tsx";
import RoadMapBinaboxIcon from "../tsx-icons/roadmap/RoadMapBinaboxIcon.tsx";
import {useEffect, useState} from "react";
import IRoadMapData from "../../interfaces/road-map/IRoadMapData.ts";
import {useSiteTypedSelector} from "../../hooks/useTypedSelector.ts";
import apiClient from "../../utils/axiosClient.ts";


const RoadMapBlock = () => {
    const {language} = useSiteTypedSelector(state => state.site);
    const [data, setData] = useState<IRoadMapData[]>([]);

    useEffect(() => {
        apiClient.get(`Site/roadMap?lang=${language}`)
            .then(res => setData(res.data));
    }, [language]);

    if (!data) return null;

    return (
        <section className="tf-section section-roadmap2 section-bg-1">
            <div className="tf-heading  mb87 wow fadeInUp">
                <h2 className="heading">ROAD MAP</h2>
            </div>
            <RoadMapShapeFirstIcon/>
            <RoadMapShapeSecondIcon/>
            <div className="container w-100">
                <div className="row">
                    <div className="col-md-12">
                        <div className="tf-roadmap style2">
                            {
                                data.map(idx => (
                                    <div key={idx.id} className={`roadmap-box-2 ${idx.class}`} data-wow-duration="1.5s">
                                        <div className="content">
                                            <h4 className="title">{idx.title}</h4>
                                            <ul className="list-infor">
                                                {
                                                    idx.list.map(idx => (
                                                        <li key={idx.id}>
                                                            <RoadMapBinaboxIcon/>
                                                            {idx.text}
                                                        </li>
                                                    ))
                                                }

                                            </ul>
                                        </div>
                                        <span></span>
                                        <div className="shape-circle">
                                            <svg xmlns="http://www.w3.org/2000/svg" width="176" height="60"
                                                 viewBox="0 0 176 60" fill="none">
                                                <path opacity="0.7" d="M0 30L136 30" stroke="var(--primary-color13)"
                                                      strokeWidth="2" strokeDasharray="6 6"/>
                                                <circle cx="146" cy="30" r="30" transform="rotate(90 146 30)"
                                                        fill="#21E786" fillOpacity="0.2"/>
                                                <circle cx="146" cy="30" r="15" transform="rotate(90 146 30)"
                                                        fill="#21E786"/>
                                            </svg>
                                        </div>
                                    </div>
                                ))
                            }
                        </div>
                    </div>
                </div>
            </div>
        </section>
    );
}

export default RoadMapBlock;