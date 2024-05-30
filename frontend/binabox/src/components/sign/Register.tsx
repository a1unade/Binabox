import React from 'react';
import apiClient from "../../utils/axiosClient.ts";
import {Link, useNavigate} from "react-router-dom";
import {ErrorIcon} from "../tsx-icons/sign/ErrorIcon.tsx";
import {validateEmail, validateNickname, validatePassword} from "../../utils/validator.ts";
import {useSiteTypedSelector} from "../../hooks/useTypedSelector.ts";

const Register = (props: {
    email: string,
    password: string,
    nickname: string,
    setEmail: React.Dispatch<React.SetStateAction<string>>,
    setPassword: React.Dispatch<React.SetStateAction<string>>,
    setNickname: React.Dispatch<React.SetStateAction<string>>
    setStep: React.Dispatch<React.SetStateAction<number>>
}) => {
    const {email, password, nickname, setEmail, setPassword, setNickname, setStep} = props;
    const {language} = useSiteTypedSelector(state => state.site);
    const navigate = useNavigate();

    const register = async () => {
        try {
            const response = await apiClient.post('Auth/register', {
                    email: email,
                    password: password,
                    nickname: nickname
                },
                {
                    headers: {
                        'Accept': '*/*',
                        'Content-Type': 'application/json'
                    }
                });

            if(response.status === 200){
                setStep(1);
            }
            else {
                navigate('/error');
            }

        } catch (error) {
            console.error('Ошибка при регистрации:', error);
            navigate('/error');
        }
    }

    const processRegistration = async () => {
        const emailMessage: string = validateEmail(email);
        const passwordMessage: string = validatePassword(password);
        const nicknameMessage: string = validateNickname(nickname);

        if (emailMessage.length === 0 && passwordMessage.length === 0 && nicknameMessage.length === 0) {
            await register();
        } else {
            if (emailMessage.length > 0) {
                document.getElementById("email-error")!.classList.add("error-message-active");
                document.getElementById("email-message")!.textContent = emailMessage;
                document.getElementById("email")!.classList.add("shake");
            }
            if (passwordMessage.length > 0) {
                document.getElementById("password-error")!.classList.add("error-message-active");
                document.getElementById("password-message")!.textContent = passwordMessage;
                document.getElementById("password")!.classList.add("shake");
            }
            if (nicknameMessage.length > 0) {
                document.getElementById("nickname-error")!.classList.add("error-message-active");
                document.getElementById("nickname-message")!.textContent = nicknameMessage;
                document.getElementById("nickname")!.classList.add("shake");
            }
        }
    }

    return (
        <div className="sign-in-form style2">
            <h2>{language === 'EN' ? 'SIGN UP' : 'РЕГИСТРАЦИЯ'}</h2>
            {language === 'EN' ?
                <p>Welcome! Please enter your details</p>
                :
                <p>Добро пожаловать! Пожалуйста введите свои данные</p>
            }
            <div className="contact-form">

                <fieldset id="field-set" style={{width: 590, paddingRight: 50}}>
                    <div id="nickname-error" className="error-message error">
                        <span><ErrorIcon/></span>
                        <span id="nickname-message"></span>
                    </div>
                    <input id="nickname"
                           onChange={(e) => setNickname(e.target.value)}
                           value={nickname}
                           tabIndex={1}
                           aria-required="true"
                           type="text"
                           placeholder={language === 'EN' ? 'Enter your nickname' : 'Введите свой никнейм'}/>
                </fieldset>

                <fieldset id="field-set" style={{width: 590, paddingRight: 50}}>
                    <div id="email-error" className="error-message error">
                        <span><ErrorIcon/></span>
                        <span id="email-message"></span>
                    </div>
                    <input tabIndex={2}
                           id="email"
                           aria-required="true"
                           onChange={(e) => setEmail(e.target.value)}
                           value={email} type="email"
                           placeholder={language === 'EN' ? 'Enter your email' : 'Введите свою эл. почту'}/>
                </fieldset>

                <fieldset id="field-set" style={{width: 590, paddingRight: 50}}>
                    <div id="password-error" className="error-message error">
                        <span><ErrorIcon/></span>
                        <span id="password-message"></span>
                    </div>
                    <input id="password"
                           onChange={(e) => setPassword(e.target.value)}
                           value={password}
                           tabIndex={2}
                           aria-required="true"
                           type="password"
                           placeholder={language === 'EN' ? 'Enter your password' : 'Введите свой пароль'}/>
                </fieldset>

                <button className="tf-button submit"
                        onClick={processRegistration}>{language === 'EN' ? 'SIGN UP' : 'Зарегистрироваться'}</button>
            </div>
            <div className="or"><span>{language === 'EN' ? 'login with' : 'войти через'}</span></div>
            <div className="box-sign-social">
                <Link className="tf-button" to=""><i className="fab fa-google"></i>Google</Link>
                <Link className="tf-button" to=""><i
                    className="fab fa-facebook-f"></i>Facebook</Link>
            </div>
        </div>
    );
};

export default Register;