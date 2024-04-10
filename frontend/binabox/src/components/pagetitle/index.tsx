import { Link } from 'react-router-dom';
import IPageTitleData from "../../interfaces/pagetitle/IPageTitleData.ts";

const PageTitle = (props: IPageTitleData) => {
    const {title} = props

    return (
        <section className="tf-page-title">
            <div className="tf-container">
                <div className="row">
                    <div className="col-md-12">
                        <h2 className="page-title-heading">{title}</h2>
                        <ul className="breadcrumbs">
                            <li><Link to="/">HOME</Link></li>
                            <li>{title}</li>
                        </ul>
                    </div>
                </div>
            </div>
        </section>
    );
}

export default PageTitle;