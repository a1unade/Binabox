import "swiper/css";
import "swiper/css/pagination";
import {useState} from "react";
import IShopProps from "../../../interfaces/shop/IShopProps.ts";
import ItemSwiper from "../../../components/sign/item-swiper.tsx";
import Register from "../../../components/sign/Register.tsx";
import Confirmation from "../../../components/sign/Confirmation.tsx";

function SignUp(props: IShopProps) {
    const {data} = props;
    const [step, setStep] = useState(0); // Этапы регистрации (ввод данных, подтверждение почты)
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [nickname, setNickname] = useState('');

    const renderCurrentStep = () => {
        switch (step) {
            case 0:
                return <Register email={email} password={password} nickname={nickname} setEmail={setEmail}
                                 setPassword={setPassword} setNickname={setNickname} setStep={setStep}/>
            case 1:
                return <Confirmation email={email}/>
            default:
                return null
        }
    }

    return (
        <div>
            <section className="bg-sign-in">
                <div className="container-fluid">
                    <div className="sign">
                        <ItemSwiper data={data}/>
                        <div className="col-md-6">
                            {renderCurrentStep()}
                        </div>
                    </div>
                </div>
            </section>
        </div>
    );
}

export default SignUp;