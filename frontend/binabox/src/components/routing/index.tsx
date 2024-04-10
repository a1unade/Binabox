import { BrowserRouter, Routes, Route } from "react-router-dom";
import NotFound from "../../pages/404";
import Header from "../header/Header.tsx";
import Footer from "../footer";
import Home from "../../pages/home";
import About from "../../pages/about";
import Contact from "../../pages/about/contact";
import Reviews from "../../pages/about/reviews";
import RoadMap from "../../pages/about/roadMap";
import Faq from "../../pages/about/faq";
import Shop from "../../pages/shop";
import SignUp from "../../pages/sign/signup";
import SignIn from "../../pages/sign/signin";
import BlogDetails from "../../pages/blog/blogDetails";
import ItemDetails from "../../pages/shop/item-details";
import Blog from "../../pages/blog";
import {dataContact} from "../../fakeData/dataContact.ts";
import dataReviews from "../../fakeData/dataReviews.ts";
import dataCollection from "../../fakeData/dataCollection.ts";
import {dataItemDetails} from "../../fakeData/dataItemDetails.ts";
import dataBlog from "../../fakeData/dataBlog.ts";
import {dataBlogDetails} from "../../fakeData/dataBlogDetails.ts";
import Payments from "../../pages/payments";
import Modal from "../../pages/connect";
import {useState} from "react";

const Routing = () => {
    const [modalActive, setModalActive] = useState(false);
    return (
        <BrowserRouter>
            <Header setModalActive={setModalActive}/>
            <Routes>
                <Route path={'/'} element={<Home setModalActive={setModalActive}/>}></Route>
                <Route path={'/about'} element={<About/>}></Route>
                <Route path={'/about/contact'} element={<Contact data={dataContact}/>}></Route>
                <Route path={'/about/reviews'} element={<Reviews data={dataReviews.data} titleData={dataReviews.titleData}/> }></Route>
                <Route path={'/about/road-map'} element={<RoadMap/>}></Route>
                <Route path={'/about/faq'} element={<Faq/>}></Route>
                <Route path={'/shop'} element={<Shop data={dataCollection}/>}></Route>
                <Route path={'/shop/item/:id'} element={<ItemDetails data={dataItemDetails.data} suggestions={dataItemDetails.suggestions}/> }></Route>
                <Route path={'/payments'} element={<Payments />}></Route>
                <Route path={'/blog'} element={<Blog data={dataBlog}/>}></Route>
                <Route path={'/blog/article/:id'} element={<BlogDetails data={dataBlogDetails}/>}></Route>
                <Route path={'/sign-in'} element={<SignIn data={dataCollection}/>}></Route>
                <Route path={'/sign-up'} element={<SignUp data={dataCollection}/>}></Route>
                <Route path={'*'} element={<NotFound/>}></Route>
            </Routes>
            <Modal active={modalActive} setActive={setModalActive}/>
            <Footer/>
        </BrowserRouter>
    );
};

export default Routing;