import React from "react";
import {useSiteTypedSelector, useUserTypedSelector} from "../../hooks/useTypedSelector.ts";

const ProfileInfo = (props: {
    setAvatarActive: React.Dispatch<React.SetStateAction<boolean>>,
    setNicknameActive: React.Dispatch<React.SetStateAction<boolean>>
}) => {
    const {setAvatarActive, setNicknameActive} = props;
    const {avatar, nickname, balance} = useUserTypedSelector(state => state.user);
    const {language} = useSiteTypedSelector(state => state.site);

    return (
        <section className="tf-section tf-about">
            <div className="tf-container">
                <div className="row">
                    <div className="tf-heading">
                        <h2 className="heading">{language === 'EN' ? 'Configure your profile' : 'Настройте свой профиль'}</h2>
                    </div>
                    <div className="profile-settings">
                        <h3 className="sub-heading">{language === 'EN' ? 'GENERAL' : 'ОСНОВНОЕ'}</h3>
                        <div className="general-settings">
                            <div className="avatar-settings">
                                <div className="profile-avatar">
                                    <img src={avatar} alt='avatar'/>
                                </div>
                                <button className='change-avatar-button'
                                        onClick={() => setAvatarActive(true)}>{language === 'EN' ? 'Change avatar' : 'Сменить аватарку'}
                                </button>
                            </div>
                            <div className="nickname-settings">
                                <span>{language === 'EN' ? 'Nickname' : 'Никнейм'}</span>
                                <div className="settings-values">{nickname}</div>
                                <button className='change-avatar-button'
                                        onClick={() => setNicknameActive(true)}>{language === 'EN' ? 'Change nickname' : 'Сменить никнейм'}</button>
                            </div>
                            <div className="nickname-settings">
                                <span>{language === 'EN' ? 'Balance' : 'Баланс'}</span>
                                <div className="settings-values">{balance} ETC</div>
                                <div style={{height: 60}}></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    );
};

export default ProfileInfo;