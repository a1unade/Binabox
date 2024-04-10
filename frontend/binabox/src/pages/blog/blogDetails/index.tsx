import {Link} from 'react-router-dom';
import PageTitle from "../../../components/pagetitle";
import BlogUserIcon from "../../../components/tsx-icons/blog/BlogUserIcon.tsx";
import BlogDateIcon from "../../../components/tsx-icons/blog/BlogDateIcon.tsx";
import IBlogDetailsProps from "../../../interfaces/blogdetails/IBlogDetailsProps.ts";
import rec1 from '../../../assets/images/blog/recent-post-1.jpg'
import rec2 from '../../../assets/images/blog/recent-post-2.jpg'
import rec3 from '../../../assets/images/blog/recent-post-3.jpg'


const BlogDetails = (props: IBlogDetailsProps) => {
    const {data} = props;
    const datarecent = [
        {
            id: 1,
            img : rec1,
            title: 'Enior Apple Employee Alleges Sexism At',
            cate: 'GAMMING',
            time: '20 Jun 2022'
        },
        {
            id: 2,
            img : rec2,
            title: 'Enior Apple Employee Alleges Sexism At',
            cate: 'LAUCHPAD',
            time: '20 Jun 2022'
        },
        {
            id: 3,
            img : rec3,
            title: 'Enior Apple Employee Alleges Sexism At',
            cate: 'ART',
            time: '20 Jun 2022'
        },
    ]

    return (
        <div>
            <PageTitle title='Blog Details'/>
            <section className="tf-blog">
                <div className="tf-container">
                    <div className="blog-details">
                        <div className="col-xl-9 col-lg-8 col-md-12">
                            <div className="detail-inner" style={{ width: '88%'}}>
                                <div className="image">
                                    <img src={data.content.images.img1} alt="Binabox"/>
                                </div>
                                <div className="title">
                                    <h3>{data.content.title1}</h3>
                                    <div className="category">{data.category}</div>
                                </div>
                                <div className="meta">
                                    <span className="admin">
                                    <BlogUserIcon/>
                                        {data.user}</span>
                                    <span className="date">
                                        <BlogDateIcon/>
                                        {data.date}</span>
                                </div>

                                <div className="content-inner mb24">
                                    <p>{data.content.p1}</p>
                                    <p>{data.content.p2}</p>
                                </div>
                                <div className="post-infor">
                                    <div className="title">{data.content.post.title}
                                    </div>
                                    <div className="content">
                                        <div className="star"><i className="fas fa-star"></i><span>{data.content.post.rating}/ 10</span></div>
                                        <h6 className="name">{data.content.post.author}</h6>
                                    </div>
                                </div>
                                <div className="image style-2">
                                    <img className="mr20" src={data.content.images.img2} alt="Binabox"/>
                                    <img src={data.content.images.img3} alt="Binabox"/>
                                </div>
                                <div className="content-inner">
                                    <h4 className="title">{data.content.title2}</h4>
                                    <p className="mb13">{data.content.p3}</p>
                                    <p>{data.content.p4}</p>
                                </div>

                                <div className="content-inner ">
                                    <h6 className="title">{data.content.title3}</h6>
                                    <p>{data.content.p5}</p>
                                </div>
                                <div className="content-bottom">
                                    <div className="widget widget-tag">
                                        <h6 className="widget-title">TAGS:</h6>
                                        <ul>
                                            <li><Link to="#">{data.tags.tag1}</Link></li>
                                            <li><Link to="#">{data.tags.tag2}</Link></li>
                                            <li><Link to="#">{data.tags.tag3}</Link></li>
                                        </ul>
                                    </div>
                                    <div className="widget widget-socical" style={{minWidth: 100, maxWidth: 120}}>
                                        <h6 className="widget-title">SHARE:</h6>
                                        <ul>
                                            <li><Link to="#" className="icon-fl-vt"></Link></li>
                                        </ul>
                                    </div>
                                </div>
                                <ul className="post-navigator">
                                    <li style={{maxWidth: '45%'}}>
                                        <div className="thump">
                                            <img src={data.previous.img} alt="Binabox"/>
                                        </div>
                                        <div className="content">
                                            <Link to={`blog/article/${data.previous.id}`} className="btn-post btn-prev">PREVIOUS</Link>
                                            <h6 className="title"><Link to={`blog/article/${data.previous.id}`}>{data.previous.title}</Link></h6>
                                        </div>
                                    </li>
                                    <li style={{maxWidth: '45%'}}>
                                        <div className="thump">
                                            <img src={data.next.img} alt="Binabox"/>
                                        </div>
                                        <div className="content">
                                            <Link to={`blog/article/${data.next.id}`} className="btn-post btn-next">NEXT</Link>
                                            <h6 className="title"><Link to={`blog/article/${data.next.id}`}>{data.next.title}</Link></h6>
                                        </div>
                                    </li>
                                </ul>

                                <div id="comments">
                                    <h3 className="heading">LEAVE A REPLY</h3>
                                    <div className="sub-heading">Your email address will not be published. Required
                                        fields are marked
                                    </div>
                                    <form method="post" id="commentform"
                                          className="comment-form" style={{alignItems: 'flex-start'}}>
                                        <div className="name-email">
                                            <fieldset className="name"><input type="text" id="name" placeholder="Name*"
                                                                              className="tb-my-input" name="name"
                                                                              tabIndex={2} aria-required="true"
                                            /></fieldset>
                                            <fieldset className="email"><input type="email" id="email"
                                                                               placeholder="Enter your email*"
                                                                               className="tb-my-input" name="email"
                                                                               tabIndex={2} aria-required="true"
                                            /></fieldset>
                                        </div>
                                        <div className="name-email">
                                            <fieldset className="message"><textarea id="message" name="message" rows={4}
                                                                                    placeholder="Comment*" tabIndex={4}
                                                                                    aria-required="true"
                                            ></textarea></fieldset>
                                        </div>
                                        <div className="btn-submit mg-t-36">
                                            <button className="tf-button" type="submit">SEND COMMENT</button>
                                        </div>
                                    </form>
                                </div>
                            </div>
                        </div>
                        <div className="col-xl-3 col-lg-4 col-md-12">
                        <div className="side-bar">
                                <div className="widget widget-search" style={{minWidth: 330, maxWidth: 350}}>
                                    <form action="#">
                                        <input style={{paddingLeft: 0, paddingTop: 10, paddingBottom: 10, paddingRight: 0, textIndent: 20}} type="text" placeholder="Search NFT" />
                                        <a className="btn-search"><i className="icon-fl-search-filled"></i></a>
                                    </form>
                                </div>
                                <div className="widget widget-category"  style={{minWidth: 330, maxWidth: 350}}>
                                    <h4 className="widget-title">CATEGORIES</h4>
                                    <ul>
                                        <li><Link to="#">NFT (12)</Link></li>
                                        <li><Link to="#">Metaverse (24)</Link></li>
                                        <li><Link to="#">Gaming (100)</Link></li>
                                        <li><Link to="#">Art (230)</Link></li>
                                        <li><Link to="#">Robot (430)</Link></li>
                                        <li><Link to="#">Lauchpad (430)</Link></li>
                                        <li><Link to="#">Cypto (430)</Link></li>
                                    </ul>
                                </div>
                                <div className="widget widget-recent-post" style={{minWidth: 330, maxWidth: 350}}>
                                    <h4 className="widget-title">RECENT POSTS</h4>
                                    <ul>
                                        {
                                            datarecent.map(idx => (
                                                <li key={idx.id}>
                                                    <div className="post-img">
                                                        <img src={idx.img} alt="Post New"/>
                                                    </div>
                                                    <div className="post-content">
                                                        <h6 className="title"><Link
                                                            to="/blog-details">{idx.title}</Link></h6>
                                                        <div className="post-meta">
                                                            <span className="category">{idx.cate}</span>
                                                            <span className="date">{idx.time}</span>
                                                        </div>
                                                    </div>
                                                </li>
                                            ))
                                        }
                                    </ul>
                                </div>
                                <div className="widget widget-tag " style={{minWidth: 330, maxWidth: 350}}>
                                    <h4 className="widget-title">TAG</h4>
                                    <ul>
                                        <li><Link to="#">NFT</Link></li>
                                        <li><Link to="#">ICO</Link></li>
                                        <li><Link to="#">CYPTO</Link></li>
                                        <li><Link to="#">LAUCHPAD</Link></li>
                                        <li><Link to="#">Robot</Link></li>
                                        <li><Link to="#">Gamming</Link></li>
                                        <li><Link to="#">Meraverse</Link></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    );
}

export default BlogDetails;