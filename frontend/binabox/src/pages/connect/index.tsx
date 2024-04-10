import React, {useState} from "react";
import WalletsTypes from "../../components/modal";

const Modal = (props: {active: boolean, setActive: React.Dispatch<React.SetStateAction<boolean>>}) => {
    const {active, setActive} = props;
    const [currentPage, setCurrentPage] = useState(0);

    const renderModal = () => {
        switch(currentPage){
            case 0:{
                return(
                    <>
                        <WalletsTypes setActive={setActive} setCurrentPage={setCurrentPage}/>
                    </>
                )
            }
            default:
                return null;
        }
    }

    return (
        <div className={active ? "modal fade popup show show-modal" : "hidden"}>
            <div id="popup_bid" tabIndex={-1} aria-modal="true" role="dialog" onClick={() => setActive(false)}>
                <div className="modal-dialog modal-dialog-centered" role="document">
                    <div className="modal-content" onClick={(e) => e.stopPropagation()}>
                        {renderModal()}
                    </div>
                </div>
            </div>
        </div>
    );
};

export default Modal;