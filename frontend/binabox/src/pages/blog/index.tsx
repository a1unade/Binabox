import {Link} from 'react-router-dom';
import PageTitle from "../../components/pagetitle";
import IBlogProps from "../../interfaces/blog/IBlogProps.ts";
import BlogUserIcon from "../../components/tsx-icons/blog/BlogUserIcon.tsx";
import BlogDateIcon from "../../components/tsx-icons/blog/BlogDateIcon.tsx";

const Blog = (props: IBlogProps) => {
    const {data} = props;
    return (
        <div>
            <PageTitle title='BLOG'/>
            <section className="tf-blog">
                <div className="tf-container">
                    <div className="blog-list">
                        {
                            data.map(idx => (
                                <div key={idx.id} className="blog-item">
                                    <article className="tf-blog-item">
                                        <div className="image">
                                            <Link to={`/blog/article/${idx.id}`}><img src={idx.img} alt="Binabox"/></Link>
                                            <Link to="#" className="category">NFT</Link>
                                        </div>
                                        <div className="meta">
                                            <span className="admin">
                                                <BlogUserIcon/>
                                                {idx.user}
                                            </span>
                                            <span className="date">
                                                <BlogDateIcon/>
                                                {idx.time}
                                            </span>
                                        </div>
                                        <h3 className="title"><Link to="/blog-details">{idx.title}</Link></h3>
                                        <p className="content">{idx.text}</p>
                                        <Link to={`/blog/article/${idx.id}`} className="btn-readmore">READ MORE <i
                                            className="fal fa-long-arrow-right"></i></Link>
                                    </article>
                                </div>
                            ))
                        }
                        <div className="col-md-12 ">
                            <div className="tf-pagination">
                                <ul>
                                    <li className="btn-page"><Link to="#"><i className="fas fa-angle-left"></i></Link>
                                    </li>
                                    <li className="active"><Link to="#">2</Link></li>
                                    <li><Link to="#">3</Link></li>
                                    <li><Link to="#">4</Link></li>
                                    <li className="continue"><Link to="#">...</Link></li>
                                    <li className="btn-page btn-next"><Link to="#"><i
                                        className="fas fa-angle-right"></i></Link></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    );
}

export default Blog;