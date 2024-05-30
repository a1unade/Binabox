import React, {useState} from "react";
import {useSiteTypedSelector, useUserTypedSelector} from "../../hooks/useTypedSelector.ts";
import {useUserActions} from "../../hooks/useActions.ts";

const Modal = (props: { active: boolean, setActive: React.Dispatch<React.SetStateAction<boolean>> }) => {
    const {active, setActive} = props;
    const {language} = useSiteTypedSelector(state => state.site);
    const {balance} = useUserTypedSelector(state => state.user);
    const [funds, setFunds] = useState(0);
    const {addBalance} = useUserActions();

    return (
        <div className={active ? "modal fade popup show show-modal" : "hidden"}>
            <div id="popup_bid" tabIndex={-1} aria-modal="true" role="dialog" onClick={() => setActive(false)}>
                <div className="modal-dialog modal-dialog-centered" role="document">
                    <div className="modal-content" onClick={(e) => e.stopPropagation()}>
                        <div className="modal-body">
                            <a className="btn-close" data-dismiss="modal" onClick={() => setActive(false)}><i
                                className="fal fa-times"></i></a>
                            <h3>{language === 'EN' ? 'Add funds to your wallet' : 'Пополнение баланса'}</h3>
                            <p className="sub-heading">{language === 'EN' ?
                                'Select value you want to add to wallet below' :
                                'Введите сумму пополнения ниже'}</p>
                            <div>
                                <div className="nickname-settings">
                                    <span style={{
                                    textAlign: 'left',
                                    marginBottom: 10
                                    }}>{language === 'EN' ? 'Current balance' : 'Текущий баланс'}</span>
                                    <div className="settings-values">{balance}</div>
                                </div>
                                <div style={{height: 20}}></div>
                                <div className="nickname-settings">
                                    <span style={{
                                        textAlign: 'left',
                                        marginBottom: 10
                                    }}>{language === 'EN' ? 'Value you want to add' : 'Сумма пополнения'}</span>
                                    <select value={funds} onChange={(e) => setFunds(parseInt(e.target.value))} required>
                                        <option value={0} disabled defaultValue={0} hidden>0 ETC</option>
                                        <option value={5}>5 ETC</option>
                                        <option value={10}>10 ETC</option>
                                        <option value={15}>15 ETC</option>
                                        <option value={25}>25 ETC</option>
                                        <option value={50}>50 ETC</option>
                                        <option value={100}>100 ETC</option>
                                    </select>
                                </div>
                            </div>
                            <div style={{height: 20}}></div>
                            <div className="tf-button opensea"
                                 onClick={() => addBalance(funds)}>{language === 'EN' ? 'SUBMIT' : 'ПОДТВЕРДИТЬ'}</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default Modal;