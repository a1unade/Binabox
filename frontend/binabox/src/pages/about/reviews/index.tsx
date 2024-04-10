import PageTitle from "../../../components/pagetitle";
import ReviewIcon from "../../../components/tsx-icons/review/ReviewIcon.tsx";
import IReviewsProps from "../../../interfaces/reviews/IReviewsProps.ts";

const Reviews = (props: IReviewsProps) => {
    const {data, titleData} = props;
    return (
        <div>
            <PageTitle title='REVIEWS' />
            <section className="tf-testimonial-page ">
                <div className="tf-container">
                    <div className="row">
                        <div className="col-md-12">
                            <div className="tf-heading">
                                <h2 className="heading">{titleData.title}</h2>
                                <p className="sub-heading">{titleData.description}</p>
                            </div>
                        </div>
                        <div className='reviews-list'>
                            {
                                data.map(idx => (
                                    <div key={idx.id} className="col-lg-4 col-md-6">
                                        <div className="tf-testimonial">
                                            <ReviewIcon/>
                                            <p>{idx.text}</p>
                                            <div className="author-tes">
                                                <div className="avt">
                                                    <img src={idx.avatar} alt="images" />
                                                </div>
                                                <div className="content">
                                                    <h4>{idx.name}</h4>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                ))
                            }
                        </div>
                    </div>
                </div>
            </section>
        </div>
    );
}

export default Reviews;