import {Link, useNavigate} from 'react-router-dom';
import IShopProps from "../../../interfaces/shop/IShopProps.ts";
import ItemSwiper from "../../../components/sign/item-swiper.tsx";
import apiClient from "../../../utils/axiosClient.ts";
import {useState} from "react";
import {useUserActions} from "../../../hooks/useActions.ts";
import {useSiteTypedSelector} from "../../../hooks/useTypedSelector.ts";

const SignIn = (props: IShopProps) => {
    const {data} = props;
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const {language} = useSiteTypedSelector(state => state.site);
    const {createUserByEmail} = useUserActions();
    const navigate = useNavigate();

    const login = async () => {
        try {
            const response = await apiClient.post('Auth/login', {
                    email: email,
                    password: password
                },
                {
                    headers: {
                        'Accept': '*/*',
                        'Content-Type': 'application/json'
                    },
                    withCredentials: true
                });

                if(response.data.responseType === 0) {
                    createUserByEmail(email);
                    navigate('/');
                }
                else {
                    navigate('/error');
                }
        } catch (error) {
            console.error('Ошибка при входе в аккаунт:', error);
        }
    }

    return (
        <div>
            <section className="bg-sign-in">
                <div className="container-fluid">
                    <div className="sign">
                        <ItemSwiper data={data}/>
                        <div className="col-md-6">
                            <div className="sign-in-form">
                                {language === 'EN' ?
                                    <div>
                                        <h2>SIGN IN</h2>
                                        <p>Welcome back! Please enter your details</p>
                                    </div>
                                    :
                                    <div>
                                        <h2>ВХОД</h2>
                                        <p>С Возвращением! Пожалуйста введите свои данные</p>
                                    </div>
                                }
                                <div className="contact-form" id="contactform">
                                    <fieldset style={{width: 590, paddingRight: 50}}>
                                        <input id="name" value={email} onChange={(e) => setEmail(e.target.value)}
                                               name="name" tabIndex={1} aria-required="true" type="text"
                                               placeholder={language === 'EN' ? 'Email' : 'Почта'}/>
                                    </fieldset>
                                    <fieldset style={{width: 590, paddingRight: 50}}>
                                        <input id="showpassword" value={password}
                                               onChange={(e) => setPassword(e.target.value)} name="password"
                                               tabIndex={2} aria-required="true" type="password"
                                               placeholder={language === 'EN' ? 'Password' : 'Пароль'}/>
                                    </fieldset>
                                    <div className="forgot-pass-wrap">
                                        <Link to="">{language === 'EN' ? 'Forgot your password?' : 'Забыли пароль?'}</Link>
                                    </div>
                                    <button className="tf-button submit" type="submit" onClick={async () => await login()}>{language === 'EN' ? 'SIGN IN' : 'ВОЙТИ'}</button>
                                </div>
                                <div style={{height: 40}}></div>
                                {language === 'EN' ?
                                    <div className="choose-sign">
                                        Do you have account? <Link to="/sign-up">Sign up for free</Link>
                                    </div>
                                    :
                                    <div className="choose-sign">
                                        У вас есть аккаунт? <Link to="/sign-up">Зарегистрируйтесь бесплатно</Link>
                                    </div>
                                }
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    );
}

export default SignIn;