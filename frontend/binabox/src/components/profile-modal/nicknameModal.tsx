import React, {useState} from "react";
import {useSiteTypedSelector, useUserTypedSelector} from "../../hooks/useTypedSelector.ts";
import {useUserActions} from "../../hooks/useActions.ts";

const NicknameModal = (props: { setActive: React.Dispatch<React.SetStateAction<boolean>>, active: boolean }) => {
    const {setActive, active} = props;
    const [newNickname, setNewNickname] = useState('');
    const {nickname} = useUserTypedSelector(state => state.user);
    const {changeNickname} = useUserActions();
    const {language} = useSiteTypedSelector(state => state.site);

    return (
        <div className={active ? "modal fade popup show show-modal" : "hidden"}>
            <div id="popup_bid" tabIndex={-1} aria-modal="true" role="dialog" onClick={() => setActive(false)}>
                <div className="modal-dialog modal-dialog-centered" role="document">
                    <div className="modal-content" onClick={(e) => e.stopPropagation()}>
                        <div className="modal-body">
                            <a className="btn-close" data-dismiss="modal" onClick={() => setActive(false)}>
                                <i className="fal fa-times"></i>
                            </a>
                            <h3>{language === 'EN' ? 'Choose Your Nickname' : 'Выберите новый никнейм'}</h3>
                            <div className="nickname-settings">
                                <span style={{
                                    textAlign: 'left',
                                    marginBottom: 10
                                }}>{language === 'EN' ? 'Current nickname' : 'Текущий никнейм'}</span>
                                <div className="settings-values">{nickname}</div>
                            </div>
                            <div style={{height: 20}}></div>
                            <div className="nickname-settings">
                                <span style={{
                                    textAlign: 'left',
                                    marginBottom: 10
                                }}>{language === 'EN' ? 'New nickname' : 'Новый никнейм'}</span>
                                <input className="settings-input" value={newNickname}
                                       onChange={(e) => setNewNickname(e.target.value)}/>
                            </div>
                            <div style={{height: 20}}></div>
                            <div className="tf-button opensea"
                                 onClick={() => changeNickname(newNickname)}>{language === 'EN' ? 'SUBMIT' : 'ПОДТВЕРДИТЬ'}</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default NicknameModal;