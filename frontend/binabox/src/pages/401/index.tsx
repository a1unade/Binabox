import background from "../../assets/images/background/bg-comming-soon.png";
import authIcon from "../../assets/images/icon/auth.png"
import {useSiteTypedSelector} from "../../hooks/useTypedSelector.ts";

const AuthRequest = () => {
    const {language} = useSiteTypedSelector(state => state.site);

    return (
        <>
            <section className="comming-soon error-page">
                <img src={background} alt="background" className="bg-comming-soon"/>
                <div className="comming-soon-inner">
                    <div className="image">
                        <img src={authIcon} alt="auth"/>
                    </div>
                    <h2 className="title">{language === 'EN' ? 'Restricted Access' : 'Ограниченный доступ'}</h2>
                    {language === 'EN' ?
                        <p className="sub">To unlock all site features, please <a href="/sign-in">login</a> or <a
                            href="/sign-up">register</a>.</p>
                        :
                        <p className="sub">Чтобы разблокировать все возможности сайта <a href="/sign-in">выполните
                            вход</a> или <a
                            href="/sign-up">зарегистрируйтесь</a>.</p>}
                    <div className="group-btn">
                        <a href="/" className="tf-button">{language === 'EN' ? 'BACK TO HOME' : 'НА ГЛАВНУЮ'}</a>
                    </div>
                </div>
            </section>
        </>
    );
};

export default AuthRequest;