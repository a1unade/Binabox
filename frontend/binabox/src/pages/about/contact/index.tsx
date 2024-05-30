import PageTitle from "../../../components/page-title";
import {useEffect, useState} from "react";
import IContactData from "../../../interfaces/contact/IContactData.ts";
import {useSiteTypedSelector} from "../../../hooks/useTypedSelector.ts";
import apiClient from "../../../utils/axiosClient.ts";

function Contact() {
    const [data, setData] = useState<IContactData[]>([]);
    const {language} = useSiteTypedSelector(state => state.site);
    const [comment, setComment] = useState("");
    const [nickname, setNickname] = useState("");
    const [email, setEmail] = useState("");

    useEffect(() => {
        apiClient.get(`Site/contact?lang=${language}`)
            .then(res => setData(res.data));
    }, [language]);

    const sendFeedback = async () => {
        await apiClient.post(`Site/addFeedback`, {
                name: nickname,
                email: email,
                message: comment
            },
            {
                headers: {
                    'Accept': '*/*',
                    'Content-Type': 'application/json'
                },
            });
        setComment('');
        setNickname('');
        setEmail('');
    };

    if (!data) return null;

    return (
        <div>
            <PageTitle title={language == "EN" ? 'CONTACT' : 'КОНТАКТЫ'}/>
            <section className="tf-contact ">
                <div className="tf-container">
                    <div className="row">
                        <div className="col-md-12">
                            <div className="tf-infor-wrap">
                                {data.map((idx) =>
                                    <div className="tf-infor" key={idx.id}>
                                        <div className="icon">
                                            <img src={idx.image} alt="Binabox"/>
                                        </div>
                                        <h3 className="title">{idx.title}</h3>
                                        <p className="sub-title">{idx.info}</p>
                                    </div>
                                )}
                            </div>
                        </div>
                    </div>
                    <div className="row justify-content-center">
                        <div className="col-xl-6 col-lg-8 col-md-9">
                            <div className="tf-heading">
                                <h2 className="heading">{language === "EN" ? 'Get In Touch' : 'Связаться с нами'}</h2>
                                {language === "EN" ?
                                    <p className="sub-heading">Browse through the most frequently asked questions</p>
                                    :
                                    <p className="sub-heading">Пройдите через наиболее часто задаваемые вопросы</p>
                                }
                            </div>
                            <div style={{
                                display: 'flex',
                                justifyContent: 'center',
                                flexDirection: 'column',
                                alignItems: 'center'
                            }} id="commentform" className="comment-form">
                                <div className="form-inner">
                                    <fieldset className="name">
                                        <input type="text" id="name" value={nickname}
                                               onChange={(e) => setNickname(e.target.value)}
                                               placeholder={language === 'EN' ? 'Enter your name' : 'Введите ваше имя'}
                                               className="tb-my-input"
                                               name="name" tabIndex={2} aria-required="true"/>
                                    </fieldset>
                                    <fieldset className="email">
                                        <input type="email" id="email" value={email}
                                               onChange={(e) => setEmail(e.target.value)}
                                               placeholder={language === 'EN' ? 'Enter your email' : 'Введите вашу электронную почту'}
                                               className="tb-my-input" name="email" tabIndex={2} aria-required="true"/>
                                    </fieldset>
                                    <fieldset className="message">
                                        <textarea id="message" value={comment}
                                                  onChange={(e) => setComment(e.target.value)} name="message" rows={4}
                                                  placeholder={language === 'EN' ? 'Enter your message' : 'Введите ваше сообщение'}
                                                  tabIndex={4} aria-required="true"></textarea>
                                    </fieldset>
                                </div>
                                <div className="btn-submit">
                                    <button className="tf-button style-2" onClick={async () => await sendFeedback()}
                                            type="submit">{language == 'EN' ? 'SEND MESSAGE' : 'ОТПРАВИТЬ '}</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    );
}

export default Contact;