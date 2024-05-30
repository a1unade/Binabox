import PageTitle from "../../components/page-title";
import SubscriptionTypes from "../../components/payments/subscription-types.tsx";
import {useSiteTypedSelector} from "../../hooks/useTypedSelector.ts";

const Payments = () => {
    const {language} = useSiteTypedSelector(state => state.site);

    return (
        <>
            <PageTitle title={language === 'EN' ? 'PAYMENTS' : 'ПЛАТЕЖИ'}/>
            <SubscriptionTypes/>
        </>
    );
};

export default Payments;