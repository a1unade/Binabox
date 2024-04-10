import { Link } from 'react-router-dom';
import ITeamProps from "../../interfaces/team/ITeamProps.ts";
import TeamBackgroundIcon from "../tsx-icons/team/TeamBackgroundIcon.tsx";

const Team = (props: ITeamProps) => {
    const {data} = props;

    return (
        <section className="tf-section team tf-team-ss">
            <TeamBackgroundIcon/>
            <div className="tf-container">
                <div className="row justify-content-center">
                    <div className="col-md-12 ">
                        <div className="tf-heading mb60 wow fadeInUp">
                            <h2 className="heading">OUR TEAM</h2>
                        </div>
                    </div>
                    <div className="employee-list">
                        {
                            data.map(idx => (
                                <div key={idx.id} className="employee">
                                    <div className="tf-team">
                                        <div className="image">
                                            <img src={idx.img} alt="Binabox" />
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