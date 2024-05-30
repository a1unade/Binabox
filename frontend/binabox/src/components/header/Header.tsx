import React, {useState, useEffect} from 'react';
import {Link, NavLink, useNavigate} from 'react-router-dom';
import MenuItems from '../../types/menu/index.ts';
import DarkMode from './DarkMode';
import {useSiteTypedSelector, useUserTypedSelector} from "../../hooks/useTypedSelector.ts";
import logo from '../../assets/images/logo/logo.png';
import logoDark from '../../assets/images/logo/logo_dark.png';
import {useUserActions} from "../../hooks/useActions.ts";
import LanguageMode from "./LanguageMode.tsx";

const Header = (props: { setModalActive: React.Dispatch<React.SetStateAction<boolean>> }) => {
    const {type, avatar, isAuthenticated} = useUserTypedSelector(state => state.user);
    const {language} = useSiteTypedSelector(state => state.site);
    const {setModalActive} = props;
    const [scroll, setScroll] = useState(false);
    const {logout} = useUserActions();
    const navigate = useNavigate();

    useEffect(() => {
        window.addEventListener("scroll", () => {
            setScroll(window.scrollY > 300);
        });
        return () => {
            setScroll(false);
        }
    }, []);

    const [menuActive, setMenuActive] = useState(false);

    const handleMenuActive = () => {
        setMenuActive(!menuActive);
    };

    const [activeIndex, setActiveIndex] = useState(0);

    const handleDropdown = (index: number) => {
        setActiveIndex(index);
    };

    return (
        <header className={`header ${scroll ? 'is-fixed' : ''}`}>
            <div className="tf-container" style={{width: '100%'}}>
                <div className="row">
                    <div className="col-md-12">
                        <div id="site-header-inner">
                            <div id="site-logo" className="clearfix">
                                <div id="site-logo-inner">
                                    <Link to="/" rel="home" className="main-logo">
                                        <img id="logo_header" className='logo-dark' src={logoDark} alt="Binasea"/>
                                        <img id="logo_header" className='logo-light' src={logo} alt="Binasea"/>
                                    </Link>
                                </div>
                            </div>
                            <div className="header-center">
                                <nav id="main-nav" className={`main-nav ${menuActive ? 'active' : ''}`}>
                                    <ul id="menu-primary-menu" className="menu">
                                        {
                                            MenuItems.map((data, idx) => (
                                                data.user.includes(type) ?
                                                    <li key={idx} onClick={() => handleDropdown(idx)}
                                                        className={`menu-item ${data.namesub ? 'menu-item-has-children' : ''} ${activeIndex === idx ? 'active' : ''}`}>
                                                        <Link
                                                            to={data.links}>{language === 'EN' ? data.name : data.rusName}</Link>
                                                        {
                                                            data.namesub &&
                                                            <ul className="sub-menu">
                                                                {
                                                                    data.namesub.map((submenu) => (
                                                                        <li key={submenu.id} className="menu-item">
                                                                            <NavLink
                                                                                to={submenu.links}>{language === 'EN' ?
                                                                                submenu.name :
                                                                                submenu.rusName}</NavLink>
                                                                        </li>
                                                                    ))
                                                                }
                                                            </ul>
                                                        }
                                                    </li>
                                                    :
                                                    null
                                            ))
                                        }
                                    </ul>
                                </nav>
                            </div>
                            <div className="header-right">
                                <DarkMode/>
                                <LanguageMode/>
                                <a href="https://discord.gg/nMYj6zFAwN" className="tf-button discord">
                                    <i className="icon-fl-vt"></i><span>DISCORD</span></a>
                                {isAuthenticated ?
                                    <>
                                        <div onClick={() => setModalActive(true)} className="tf-button connect"
                                             data-toggle="modal" data-target="#popup_bid" style={{cursor: 'pointer'}}>
                                            <i className="icon-fl-wallet"></i>
                                            <span>{language === 'EN' ? 'CONNECT' : 'КОШЕЛЕК'}</span>
                                        </div>
                                        <div className={`mobile-button ${menuActive ? 'active' : ''}`}
                                             onClick={handleMenuActive}><span></span>
                                        </div>
                                    </>
                                    :
                                    null
                                }
                                <div className="profile-nav">
                                    <nav id="main-nav">
                                        <ul>
                                            <li style={{paddingTop: 0, paddingBottom: 0}}>
                                                <a href="/profile">
                                                    <div style={{width: 50, height: 50, marginLeft: 20}}
                                                         className="profile-avatar">
                                                        <img src={avatar} alt='avatar'/>
                                                    </div>
                                                </a>
                                                {isAuthenticated ?
                                                    <ul className="sub-menu" style={{marginTop: 20}}>
                                                        <li className="menu-item">
                                                            <NavLink to={''}
                                                                     onClick={() => {
                                                                         logout();
                                                                         navigate('/')
                                                                     }}>{language === 'EN' ? 'SIGN OUT' : 'ВЫХОД'}</NavLink>
                                                        </li>
                                                    </ul>
                                                    :
                                                    <ul className="sub-menu" style={{marginTop: 20}}>
                                                        <li className="menu-item">
                                                            <NavLink
                                                                to={'/sign-in'}>{language === 'EN' ? 'SIGN IN' : 'ВХОД'}</NavLink>
                                                        </li>
                                                        <li className="menu-item">
                                                            <NavLink
                                                                to={'/sign-up'}>{language === 'EN' ? 'SIGN UP' : 'РЕГИСТРАЦИЯ'}</NavLink>
                                                        </li>
                                                    </ul>
                                                }
                                            </li>
                                        </ul>
                                    </nav>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </header>
    );
}

export default Header;