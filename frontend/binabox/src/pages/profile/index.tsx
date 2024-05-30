import PageTitle from "../../components/page-title";
import ProfileInfo from "../../components/profile";
import {useState} from "react";
import AvatarModal from "../../components/profile-modal/avatarModal.tsx";
import NicknameModal from "../../components/profile-modal/nicknameModal.tsx";
import {useSiteTypedSelector, useUserTypedSelector} from "../../hooks/useTypedSelector.ts";
import Transactions from "../../components/profile/Transactions.tsx";
import SellItem from "../../components/profile/SellItem.tsx";

const Profile = () => {
    const [avatarModalActive, setAvatarModalActive] = useState(false);
    const [nicknameModalActive, setNicknameModalActive] = useState(false);
    const {language} = useSiteTypedSelector(state => state.site);
    const {subscription} = useUserTypedSelector(state => state.user);
    console.log(subscription)
    return (
        <>
            <PageTitle title={language === 'EN' ? 'PROFILE' : 'ПРОФИЛЬ'}/>
            <ProfileInfo setAvatarActive={setAvatarModalActive} setNicknameActive={setNicknameModalActive}/>
            <Transactions/>
            {subscription > 0 ? <SellItem/> : null}
            <AvatarModal setActive={setAvatarModalActive} active={avatarModalActive}/>
            <NicknameModal setActive={setNicknameModalActive} active={nicknameModalActive}/>
        </>
    );
};

export default Profile;