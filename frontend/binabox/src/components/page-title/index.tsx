import { Link } from 'react-router-dom';
import IPageTitleData from "../../interfaces/page-title/IPageTitleData.ts";
import {useSiteTypedSelector} from "../../hooks/useTypedSelector.ts";

const PageTitle = (props: IPageTitleData) => {
    const {language} = useSiteTypedSelector(state => state.site);
    const {title} = props

    return (
        <section className="tf-page-title">
            <div className="tf-container">
                <div className="row">
                    <div className="col-md-12">
                        <h2 className="page-title-heading">{title}</h2>
                        <ul className="breadcrumbs">
                            <li><Link to="/">{language === 'EN' ? 'HOME' : 'ГЛАВНАЯ'}</Link></li>
                            <li>{title}</li>
                        </ul>
                    </div>
                </div>
            </div>
        </section>
    );
}

export default PageTitle;