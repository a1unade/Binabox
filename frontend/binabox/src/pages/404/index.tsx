import background from '../../assets/images/background/bg-comming-soon.png';
import {NotFoundIcon} from "../../components/tsx-icons/404/NotFoundIcon.tsx";

const NotFound = () => {
    return (
        <>
            <section className="comming-soon error-page">
                <img src={background} alt="background" className="bg-comming-soon"/>
                <div className="comming-soon-inner">
                    <div className="image">
                        <NotFoundIcon/>
                    </div>
                    <h2 className="title">404 Error</h2>
                    <p className="sub">Sorry, Page not found</p>
                    <div className="group-btn">
                        <a href="../../../index.html" className="tf-button">BACK TO HOME</a>
                    </div>
                </div>
            </section>
        </>
    );
}

export default NotFound;