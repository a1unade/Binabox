import React, {useEffect, useState} from "react";
import {useSiteTypedSelector, useUserTypedSelector} from "../../hooks/useTypedSelector.ts";
import {useUserActions} from "../../hooks/useActions.ts";
import apiClient from "../../utils/axiosClient.ts";
import IAvatar from "../../interfaces/avatar/IAvatar.ts";

// Модальное окно для смены аватарки
const AvatarModal = (props: {
    setActive: React.Dispatch<React.SetStateAction<boolean>>,
    active: boolean
}) => {
    const {setActive, active} = props;
    const {avatar} = useUserTypedSelector(state => state.user);
    const [userAvatar, setUserAvatar] = useState(avatar);
    const [avatars, setAvatars] = useState<IAvatar[]>([]);
    const {changeAvatar} = useUserActions();
    const {language} = useSiteTypedSelector(state => state.site);

    useEffect(() => {
        apiClient.get('Site/getAvatarsList')
            .then(res => setAvatars(res.data))
    }, [setAvatars])

    if (!avatars) return null;

    return (
        <div className={active ? "modal fade popup show show-modal" : "hidden"}>
            <div id="popup_bid" tabIndex={-1} aria-modal="true" role="dialog" onClick={() => setActive(false)}>
                <div className="modal-dialog modal-dialog-centered" role="document">
                    <div className="modal-content" onClick={(e) => e.stopPropagation()}>
                        <div className="modal-body">
                            <a className="btn-close" data-dismiss="modal" onClick={() => setActive(false)}>
                                <i className="fal fa-times"></i>
                            </a>
                            <h3>{language === 'EN' ? 'Choose Your Avatar' : 'Выберите новую аватарку'}</h3>
                            <div className="profile-modal-avatars">
                                {
                                    avatars.slice(0, 9).map((a) =>
                                        <div key={a.id}
                                            className={a.url === userAvatar ? "profile-avatar avatar-active" : "profile-avatar"}
                                            style={{cursor: "pointer"}}
                                            onClick={() => setUserAvatar(a.url)}>
                                            <img src={a.url} alt='avatar'/>
                                        </div>
                                    )}
                            </div>
                            <div></div>
                            <div className="tf-button opensea" onClick={() => {
                                changeAvatar(userAvatar);
                                setActive(false)
                            }}>{language === 'EN' ? 'SUBMIT' : 'ПОДТВЕРДИТЬ'}</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default AvatarModal;