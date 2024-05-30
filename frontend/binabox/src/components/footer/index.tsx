import {useState, useEffect} from 'react';
import {Link} from 'react-router-dom';
import logo from '../../assets/images/logo/logo-footer.png';
import {useSiteTypedSelector} from "../../hooks/useTypedSelector.ts";

const Footer = () => {
    const [isVisible, setIsVisible] = useState(false);
    const {language} = useSiteTypedSelector(state => state.site);

    const scrollToTop = () => {
        window.scrollTo({
            top: 0,
            behavior: "smooth"
        });
    };

    useEffect(() => {
        const toggleVisibility = () => {
            if (window.scrollY > 500) {
                setIsVisible(true);
            } else {
                setIsVisible(false);
            }
        };

        window.addEventListener("scroll", toggleVisibility);

        return () => window.removeEventListener("scroll", toggleVisibility);
    }, []);

    return (
        <footer className="footer style-2">
            <div className="footer-inner">
                <div className="tf-container">
                    <div className="row">
                        <div className="col-md-12">
                            {language == 'EN' ?
                                <h2 className="title">JOIN OUR COMMUNITY</h2>
                                :
                                <h2 className="title">ПРИСОЕДИНЯЙТЕСЬ К НАШЕМУ СООБЩЕСТВУ</h2>
                            }
                            <p className="content"></p>
                            <div className="group-btn">
                                <a href="https://discord.gg/nMYj6zFAwN" className="tf-button discord"
                                   data-toggle="modal" data-target="#popup_bid"><i
                                    className="icon-fl-vt"></i><span>DISCORD</span></a>
                                <Link to="/shop" className="tf-button">{language === 'EN' ? 'WHITELIST NOW' : 'МАГАЗИН'}</Link>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div className="bottom-inner">
                <div className="tf-container">
                    <div className="row">
                        <div className="col-md-12">
                            <div className="bottom">
                                <div className="content-left">
                                    <img src={logo} alt="Binabox"/>
                                    <p className="copy-right">{language === 'EN' ? 'BINABOX 2024 - ALL rights reserved' : 'BINABOX 2024 - Все права защищены'}</p>
                                </div>
                                <ul className="menu-bottom">
                                    <li><Link to="/">{language === 'EN' ? 'Home' : 'Главная'}</Link></li>
                                    <li><Link to="/about">{language === 'EN' ? 'About' : 'О нас'}</Link></li>
                                    <li><Link to="/about/road-map">{language === 'EN' ? 'Roadmap' : 'Дорожная карта'}</Link></li>
                                    <li><Link to="/about/reviews">{language === 'EN' ? 'Reviews' : 'Отзывы'}</Link></li>
                                    <li><Link to="/about/faq">{language === 'EN' ? 'FAQs' : 'Вопросы'}</Link></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            {isVisible && <div onClick={scrollToTop} id="scroll-top"></div>}
        </footer>
    );
}

export default Footer;