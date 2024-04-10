import React from 'react';
import metaMask from "../../assets/images/svg/icon-wallet-1.svg";
import fortmatic from "../../assets/images/svg/icon-wallet-2.svg";
import bitski from "../../assets/images/svg/icon-wallet-3.svg";

const WalletsTypes = (props: {setActive: React.Dispatch<React.SetStateAction<boolean>>, setCurrentPage: React.Dispatch<React.SetStateAction<number>>}) => {
    const {setActive, setCurrentPage} = props;

    return (
        <div className="modal-body">
            <a href="#" className="btn-close" data-dismiss="modal" onClick={() => setActive(false)}><i
                className="fal fa-times"></i></a>
            <h3>Connect Your Wallet</h3>
            <p className="sub-heading">Select what network and wallet you want to connect below</p>

            <div className="tf-wallet" onClick={() => setCurrentPage(1)}>
                <div className="image">
                    <img src={metaMask} alt="Image"/>
                </div>
                <div className="content">
                    <div className="title">Meta Mask</div>
                    <div className="sub">Connect your Meta Mask wallet</div>
                </div>
            </div>

            <div className="tf-wallet" onClick={() => setCurrentPage(2)}>
                <div className="image">
                    <img src={fortmatic} alt="Image"/>
                </div>
                <div className="content">
                    <div className="title">Fortmatic</div>
                    <div className="sub">Connect your Fortmatic wallet</div>
                </div>
            </div>

            <div className="tf-wallet" onClick={() => setCurrentPage(3)}>
                <div className="image">
                    <img src={bitski} alt="Image"/>
                </div>
                <div className="content">
                    <div className="title">Bitski</div>
                    <div className="sub">Connect your Bitski wallet</div>
                </div>
            </div>

            <div className="bottom">By connecting your wallet, you agree to our <a href="#">Terms of
                Service</a> and our <a href="#">Privacy Policy.</a></div>
        </div>
    );
};

export default WalletsTypes;