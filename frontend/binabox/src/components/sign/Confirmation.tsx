import {useEffect, useState} from 'react';
import {useSignalR} from "../../hooks/useSignalR.ts";
import {useUserActions} from "../../hooks/useActions.ts";
import {useSiteTypedSelector} from "../../hooks/useTypedSelector.ts";
import {useNavigate} from "react-router-dom";

const Confirmation = (props: { email: string }) => {
    const {email} = props;
    const {createUserByEmail} = useUserActions();
    const [isEmailConfirmed, setIsEmailConfirmed] = useState(false);
    const {language} = useSiteTypedSelector(state => state.site);
    useSignalR({setIsEmailConfirmed});
    const navigate = useNavigate();

    useEffect(() => {
        if (isEmailConfirmed) navigate('/');
    }, [isEmailConfirmed]);

    return (
        <div className="sign-in-form style2">
            {language === 'EN' ?
                <div>
                    <h2>LAST STEP</h2>
                    <p>Please confirm your email</p>
                </div>
                :
                <div>
                    <h2>ПОСЛЕДНИЙ ШАГ</h2>
                    <p>ПОАЖЛУЙСТА ПОДТВЕРДИТЕ ВАШУ ЭЛ. ПОЧТУ</p>
                </div>
            }


            {isEmailConfirmed ?
                createUserByEmail(email) &&
                (
                    <p>{language === 'EN' ? 'Email is confirmed!' : 'Почта подтверждена!'}</p>
                ) : (
                    <div>
                        <p>{language === 'EN' ? 'Email is not confirmed yet.' : 'Почта еще не подтверждена.'}</p>
                        <p>{language === 'EN' ? 'Confirmation message sent to your email.' : 'Письмо для подтверждения было отправлено на адрес вашей эл. почты.'}</p>
                    </div>
                )}
        </div>
    );
};

export default Confirmation;
