import { Link } from 'react-router-dom';
import "swiper/css";
import "swiper/css/pagination";
import IShopProps from "../../../interfaces/shop/IShopProps.ts";
import ItemSwiper from "../../../components/sign/itemswiper.tsx";

function SignUp(props: IShopProps) {
    const {data} = props;

    return (
        <div>
            <section className="bg-sign-in">
                <div className="container-fluid">
                    <div className="sign">
                        <ItemSwiper data={data}/>
                        <div className="col-md-6">
                            <div className="sign-in-form style2">
                                <h2>SIGN UP</h2>
                                <p>Welcome back! Please enter your details</p>
                                <form action="#" id="contactform">
                                    <fieldset style={{width: 590, paddingRight: 50}}><input id="name" name="name" tabIndex={1} aria-required="true"  type="text" placeholder="Your full name" /></fieldset>
                                    <fieldset style={{width: 590, paddingRight: 50}}> <input  name="email" tabIndex={2} aria-required="true"  type="email" placeholder="Your email" /></fieldset>
                                    <fieldset style={{width: 590, paddingRight: 50}}> <input id="showpassword" name="password" tabIndex={2} aria-required="true"  type="password" placeholder="Set your password" /></fieldset>
                                    <button className="tf-button submit" type="submit">SIGN UP</button>
                                </form>
                                <div className="or"><span>login with</span></div>
                                <div className="box-sign-social">
                                    <Link className="tf-button" to="#"><i className="fab fa-google"></i>Google</Link>
                                    <Link className="tf-button" to="#"><i className="fab fa-facebook-f"></i>Facebook</Link>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    );
}

export default SignUp;