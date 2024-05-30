import PageTitle from "../../../components/page-title";
import ReviewIcon from "../../../components/tsx-icons/review/ReviewIcon.tsx";
import IReviewsProps from "../../../interfaces/reviews/IReviewsProps.ts";
import {useEffect, useState} from "react";
import {useSiteTypedSelector, useUserTypedSelector} from "../../../hooks/useTypedSelector.ts";
import apiClient from "../../../utils/axiosClient.ts";

const Reviews = () => {
    const [data, setData] = useState<IReviewsProps>();
    const {language} = useSiteTypedSelector(state => state.site);
    const [comment, setComment] = useState("");
    const [isReviewed, setIsReviewed] = useState(false);
    const {isAuthenticated, nickname, avatar} = useUserTypedSelector(state => state.user);

    useEffect(() => {
        apiClient.get(`Site/reviews?lang=${language}`)
            .then(res => {
                setData(res.data);
                setIsReviewed(false);
            })
            .catch(err => console.log(err));
    }, [language, isReviewed]);

    const leaveComment = async () => {
        try {
            if(comment.length > 0){
                const response = await apiClient.post('Site/addReview', {
                        nickname: nickname,
                        avatar: avatar,
                        text: comment,
                        language: language
                    },
                    {
                        headers: {
                            'Accept': '*/*',
                            'Content-Type': 'application/json'
                        }
                    });

                if(response.data.responseType === 0) {
                    setIsReviewed(true);
                    setComment('');
                }
            }
        } catch (error) {
            console.error('Ошибка при входе в аккаунт:', error);
        }
    }

    if (!data) return null;

    return (
        <div>
            <PageTitle title={language === 'EN' ? 'REVIEWS' : 'ОТЗЫВЫ'}/>
            <section className="tf-testimonial-page ">
                <div className="tf-container">
                    <div className="row">
                        <div className="col-md-12">
                            <div className="tf-heading">
                                <h2 className="heading">{data.title}</h2>
                                <p className="sub-heading">{data.description}</p>
                            </div>
                        </div>
                        <div className='reviews-list'>
                            {
                                data.reviews.map(idx => (
                                    <div key={idx.id} className="col-lg-4 col-md-6">
                                        <div className="tf-testimonial" style={{ width: 400}}>
                                            <ReviewIcon/>
                                            <p>{idx.text}</p>
                                            <div className="author-tes">
                                                <div className="avt">
                                                    <img src={idx.avatar} alt="images"/>
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
                    {isAuthenticated ? (
                        <div style={{
                            width: '100%',
                            justifyContent: 'center',
                            alignItems: 'center',
                            display: 'flex',
                            marginTop: 60
                        }}>
                            <div style={{
                                width: '100%',
                                flexDirection: 'column',
                                gap: 40,
                                justifyContent: 'center',
                                alignItems: 'center',
                                display: 'flex',
                                marginTop: 60
                            }}>
                                <h3 className="heading">{language === 'EN' ? 'LEAVE A REVIEW' : 'ОСТАВЬТЕ ОТЗЫВ'}</h3>
                                <textarea value={comment} onChange={(e) => setComment(e.target.value)} id="message"
                                          name="message" rows={4}
                                          style={{width: 600}}
                                          placeholder={language === 'EN' ? 'Your review' : 'Ваш отзыв'} tabIndex={4}
                                          aria-required="true"></textarea>
                                <div className="btn-submit mg-t-36">
                                    <button className="tf-button" onClick={async () => await leaveComment()}
                                            type="submit">{language === 'EN' ? 'SEND REVIEW' : 'ОТПРАВИТЬ ОТЗЫВ'}</button>
                                </div>
                            </div>
                        </div>
                    ) : null}
                </div>
            </section>
        </div>
    );
}

export default Reviews;