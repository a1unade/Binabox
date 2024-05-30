import { Link } from 'react-router-dom';
import TeamBackgroundIcon from "../tsx-icons/team/TeamBackgroundIcon.tsx";
import {useSiteTypedSelector} from "../../hooks/useTypedSelector.ts";
import {useEffect, useState} from "react";
import ITeamData from "../../interfaces/team/ITeamData.ts";
import apiClient from "../../utils/axiosClient.ts";

const Team = () => {
    const {language} = useSiteTypedSelector(state => state.site);
    const [data, setData] = useState<ITeamData[]>([]);

    useEffect(() => {
        apiClient.get(`Site/team?lang=${language}`)
            .then(res => setData(res.data))
    }, [language])

    if (!data) return null;

    return (
        <section className="tf-section team tf-team-ss">
            <TeamBackgroundIcon/>
            <div className="tf-container">
                <div className="row justify-content-center">
                    <div className="col-md-12 ">
                        <div className="tf-heading mb60 wow fadeInUp">
                            <h2 className="heading">{language === 'EN' ? 'OUR TEAM' : 'НАША КОМАНДА'}</h2>
                        </div>
                    </div>
                    <div className="employee-list">
                        {
                            data.map(idx => (
                                <div key={idx.id} className="employee">
                                    <div className="tf-team">
                                        <div className="image">
                                            <img src={idx.image} alt="Binabox" />
                                        </div>
                                        <h4 className="name"><Link to="/our-team">{idx.name}</Link></h4>
                                        <p className="position">{idx.position}</p>
                                    </div>
                                </div>
                            ))
                        }
                    </div>
                </div>
            </div>
        </section>
    );
}

export default Team;