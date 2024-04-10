import { Link } from 'react-router-dom';
import IShopProps from "../../../interfaces/shop/IShopProps.ts";
import ItemSwiper from "../../../components/sign/itemswiper.tsx";

const SignIn = (props: IShopProps) => {
    const {data} = props;

    return (
        <div>
            <section className="bg-sign-in">
                <div className="container-fluid">
                    <div className="sign">
                        <ItemSwiper data={data}/>
                        <div className="col-md-6">
                            <div className="sign-in-form">
                                <h2>SIGN IN</h2>
                                <p>Welcome back! Please enter your details</p>
                                <form action="#" id="contactform">
                                    <fieldset style={{width: 590, paddingRight: 50}}><input id="name" name="name" tabIndex={1} aria-required="true" type="text" placeholder="Username or Email" /></fieldset>
                                    <fieldset style={{width: 590, paddingRight: 50}}> <input id="showpassword" name="password" tabIndex={2} aria-required="true"  type="password" placeholder="Password"/></fieldset>
                                    <div className="forgot-pass-wrap">
                                        <label>
                                            <input type="checkbox" />
                                            <span className="btn-checkbox"></span>
                                            Remember me
                                        </label>
                                        <Link to="#">Forgot your password?</Link>
                                    </div>
                                    <button className="tf-button submit" type="submit">SIGN IN</button>
                                </form>
                                <div className="choose-sign">
                                    Do you have account? <Link to="/sign-up">Sign up for free</Link>
                                </div>
                                <div className="or"><span>or</span></div>
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

export default SignIn;