import {useState, useEffect} from 'react';
import {Link} from 'react-router-dom';
import logo from '../../assets/images/logo/logo-footer.png';

const Footer = () => {
    const [isVisible, setIsVisible] = useState(false);

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
                            <h2 className="title">JOIN OUR COMMUNITY</h2>
                            <p className="content"></p>
                            <div className="group-btn">
                                <a href="https://discord.gg/nMYj6zFAwN" className="tf-button discord"
                                   data-toggle="modal" data-target="#popup_bid"><i
                                    className="icon-fl-vt"></i><span>DISCORD</span></a>
                                <Link to="/collection" className="tf-button">WHITELIST NOW</Link>
                            </div>
                            <form className='email-sennder' action="#" id="subscribe-form">
                                <input type="email" placeholder="Enter your email" id="subscribe-email"/>
                                <button className="tf-button" type="submit" id="subscribe-button">SUBSCRIBE</button>
                            </form>
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
                                    <p className="copy-right">BINABOX 2022 - ALL rights reserved</p>
                                </div>
                                <ul className="menu-bottom">
                                    <li><Link to="/">Home</Link></li>
                                    <li><Link to="/about-v1">About</Link></li>
                                    <li><Link to="/roadmap-v1">Roadmap</Link></li>
                                    <li><Link to="/our-team">Our Team</Link></li>
                                    <li><Link to="/faq-v1">FAQs</Link></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            {isVisible && <Link onClick={scrollToTop} to='#' id="scroll-top"></Link>}
        </footer>
    );
}

export default Footer;