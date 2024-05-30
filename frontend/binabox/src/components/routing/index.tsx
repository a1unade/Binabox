import {BrowserRouter, Route, Routes} from "react-router-dom";
import {useState} from "react";
import NotFound from "../../pages/404";
import Header from "../header/Header.tsx";
import Footer from "../footer";
import Home from "../../pages/home";
import About from "../../pages/about";
import Contact from "../../pages/about/contact";
import Reviews from "../../pages/about/reviews";
import RoadMap from "../../pages/about/road-map";
import Faq from "../../pages/about/faq";
import Shop from "../../pages/shop";
import SignUp from "../../pages/sign/sign-up";
import SignIn from "../../pages/sign/sign-in";
import BlogDetails from "../../pages/blog/blog-details";
import ItemDetails from "../../pages/shop/item-details";
import Blog from "../../pages/blog";
import Payments from "../../pages/payments";
import AuthRequest from "../../pages/401";
import Profile from "../../pages/profile";
import Modal from "../connect-modal";
import dataCollection from "../../fakeData/dataCollection.ts";
import dataBlog from "../../fakeData/dataBlog.ts";
import {dataBlogDetails} from "../../fakeData/dataBlogDetails.ts";
import {useUserTypedSelector} from "../../hooks/useTypedSelector.ts";
import {UserType} from "../../types/users/userType.ts";
import {useUserActions} from "../../hooks/useActions.ts";
import ShopControl from "../../pages/admin/shop-control";
import EmailConfirmed from "../../pages/email/EmailConfirmed.tsx";
import Error from "../../pages/error";
import FeedbackControl from "../../pages/admin/users-feedback";

const Routing = () => {
    const [modalActive, setModalActive] = useState(false);
    const {isAuthenticated, type} = useUserTypedSelector(state => state.user);
    const {createUserById} = useUserActions();
    
    if(type === UserType.UNDEFINED && document.cookie.length !== 0){
        const userId = document.cookie.split("=")[1];
        createUserById(userId);
    }

    return (
        <BrowserRouter>
            <Header setModalActive={setModalActive}/>
            <Routes>
                <Route path={'/'} element={<Home setModalActive={setModalActive}/>}></Route>
                <Route path={'/about'} element={<About/>}></Route>
                <Route path={'/about/contact'} element={<Contact/>}></Route>
                <Route path={'/about/reviews'} element={<Reviews/> }></Route>
                <Route path={'/about/road-map'} element={<RoadMap/>}></Route>
                <Route path={'/about/faq'} element={<Faq/>}></Route>
                {isAuthenticated ? (
                    <>
                        <Route path={'/shop'} element={<Shop/>}></Route>
                        <Route path={'/shop/item/:id'} element={<ItemDetails/> }></Route>
                        <Route path={'/payments'} element={<Payments/>}></Route>
                        <Route path={'/profile'} element={<Profile/>}></Route>
                    </>
                ) : (
                    <>
                        <Route path={'/shop'} element={<AuthRequest/>}></Route>
                        <Route path={'/shop/item/:id'} element={<AuthRequest/>}></Route>
                        <Route path={'/payments'} element={<AuthRequest/>}></Route>
                        <Route path={'/profile'} element={<SignIn data={dataCollection}/>}></Route>
                        <Route path={'/sign-in'} element={<SignIn data={dataCollection}/>}></Route>
                        <Route path={'/sign-up'} element={<SignUp data={dataCollection}/>}></Route>
                    </>
                )}
                <Route path={'/blog'} element={<Blog data={dataBlog}/>}></Route>
                <Route path={'/blog/article/:id'} element={<BlogDetails data={dataBlogDetails}/>}></Route>
                <Route path={'/admin/shop'} element={<ShopControl/>}/>
                <Route path={'/admin/feedback'} element={<FeedbackControl/>}/>
                <Route path={'/emailConfirmed/:userId'} element={<EmailConfirmed/>}/>
                <Route path={'/error'} element={<Error/>}/>
                <Route path={'*'} element={<NotFound/>}></Route>
            </Routes>
            <Modal active={modalActive} setActive={setModalActive}/>
            <Footer/>
        </BrowserRouter>
    );
};

export default Routing;