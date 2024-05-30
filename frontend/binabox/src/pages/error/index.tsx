import background from '../../assets/images/background/bg-comming-soon.png';
import {NotFoundIcon} from "../../components/tsx-icons/404/NotFoundIcon.tsx";
import {useSiteTypedSelector} from "../../hooks/useTypedSelector.ts";

const Error = () => {
    const {language} = useSiteTypedSelector(state => state.site);

    return (
        <>
            <section className="comming-soon error-page">
                <img src={background} alt="background" className="bg-comming-soon"/>
                <div className="comming-soon-inner">
                    <div className="image">
                        <NotFoundIcon/>
                    </div>
                    <h2 className="title">{language === 'EN' ? 'Error' : 'Ошибка'}</h2>
                    <p className="sub">{language === 'EN' ? 'An error occurred, please try again later.' : 'Произошла ошибка, повторите попытку позже.'}</p>
                    <div className="group-btn">
                        <a href="/" className="tf-button">{language === 'EN' ? 'BACK TO HOME' : 'НА ГЛАВНУЮ'}</a>
                    </div>
                </div>
            </section>
        </>
    );
}

export default Error;