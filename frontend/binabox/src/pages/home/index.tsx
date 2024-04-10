import Banner from "../../components/banner";
import Logo from "../../components/logo";
import Work from "../../components/work";
import Partner from "../../components/partner";
import {dataWork} from "../../fakeData/dataWork.ts";
import {dataBanner} from "../../fakeData/dataBanner.ts";
import {dataLogo} from "../../fakeData/dataLogo.ts";
import dataPartner from "../../fakeData/dataPartner.ts";
import React from "react";

const Home = (props: {setModalActive: React.Dispatch<React.SetStateAction<boolean>>}) => {
    const {setModalActive} = props;

    return (
        <div className="home-1">
            <Banner data={dataBanner} setModalActive={setModalActive}/>
            <Logo data={dataLogo}/>
            <Work data={dataWork}/>
            <Partner data={dataPartner} delay={0}/>
        </div>
    );
};

export default Home;