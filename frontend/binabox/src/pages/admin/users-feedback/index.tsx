import PageTitle from "../../../components/page-title";
import AdminUsersFeedback from "../../../components/admin/feedback/AdminUsersFeedback.tsx";


const FeedbackControl = () => {
    return (
        <div className='page-about home-1'>
            <PageTitle title='FEEDBACK CONTROL'/>
            <AdminUsersFeedback/>
        </div>
    );
};

export default FeedbackControl;