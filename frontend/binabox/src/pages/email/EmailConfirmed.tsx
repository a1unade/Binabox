import background from "../../assets/images/background/bg-comming-soon.png";
import emailConfirmed from "../../assets/images/icon/email-confirmed.png"
import {useSiteTypedSelector} from "../../hooks/useTypedSelector.ts";

const EmailConfirmed = () => {
    const {language} = useSiteTypedSelector(state => state.site);

    return (
        <>
            <section className="comming-soon error-page">
                <img src={background} alt="background" className="bg-comming-soon"/>
                <div className="comming-soon-inner">
                    <div className="image">
                        <img src={emailConfirmed} alt={"emailConfirmed"}/>
                    </div>
                    <h2 className="title">{language == 'EN' ? 'Done' : 'Готово'}</h2>
                    <p className="sub">{language == 'EN' ? 'Email successfully confirmed' : 'Почта успешно подтверждена'}</p>
                    <div className="group-btn">
                        <a href="/" className="tf-button">{language === 'EN' ? 'BACK TO HOME' : 'НА ГЛАВНУЮ'}</a>
                    </div>
                </div>
            </section>
        </>
    );
};

export default EmailConfirmed;