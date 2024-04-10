import { Link } from 'react-router-dom';
import PageTitle from "../../components/pagetitle";
import FilterType from "../../components/shop/filterType.tsx";
import IShopProps from "../../interfaces/shop/IShopProps.ts";

const Shop = (props: IShopProps) => {
    const {data} = props;
    return (
        <div className='page-collection'>
            <PageTitle title='SHOP' />
            <section className="tf-collection-inner">
                <div className="tf-container">
                    <div className="shop">
                        <div className="col-lg-3 col-md-4">
                            <div className="sidebar sidebar-collection">
                                <div className="widget widget-clothing widget-accordion">
                                   <FilterType title='CLOTHING' className='active' filters={['Combatant', 'Ninja', 'King', 'Queen', 'Robot']}/>
                                </div>
                                <div className="widget widget-eyes widget-accordion">
                                    <FilterType title='EYES' className='' filters={['Yellow', 'Mix', 'Orange', 'Glow', 'Blue']}/>
                                </div>
                                <div className="widget widget-face widget-accordion">
                                    <FilterType title='FACE' className='' filters={['Yellow', 'Green', 'Mix', 'Orange', 'Glow', 'Blue']}/>
                                </div>
                                <div className="widget widget-skin widget-accordion">
                                    <FilterType title='SKIN' className='' filters={['Yellow', 'Green', 'Mix', 'Orange', 'Glow', 'Blue']}/>
                                </div>
                                <div className="widget widget-background widget-accordion">
                                    <FilterType title='BACKGROUND' className='' filters={['Yellow', 'Green', 'Mix', 'Orange', 'Glow', 'Blue']}/>
                                </div>
                                <div className="widget widget-special widget-accordion">
                                    <FilterType title='SPECIAL' className='' filters={['Cat', 'Sakura', 'Snake', 'Eath', 'Water']}/>
                                </div>
                            </div>
                        </div>
                        <div className="col-lg-9 col-md-8 ">
                            <div className="top-option">
                                <h2 className="heading">All Items</h2>
                                <div className="widget widget-search">
                                    <form action="#">
                                        <input type="text" placeholder="Search NFT" />
                                        <a className="btn-search"><i className="icon-fl-search-filled"></i></a>
                                    </form>
                                </div>
                            </div>
                            <ul className="filter-content">
                                <li><Link to="#">King <i className="fal fa-times"></i></Link></li>
                                <li><Link to="#">Mix <i className="fal fa-times"></i></Link></li>
                                <li><Link to="#">Skacura <i className="fal fa-times"></i></Link></li>
                                <li><Link to="#">Clear All</Link></li>
                            </ul>
                            <div className="items-list">
                                {
                                    data.slice(0,9).map(idx => (
                                        <Link to={`/shop/item/${idx.id}`}>
                                            <div key={idx.id} className="col-lg-4 col-md-6 col-sm-6 col-12 ">
                                                <div className="item">
                                                    <div className="image">
                                                        <img src={idx.img} alt="Binabox"/>
                                                    </div>
                                                    <h6 className="name"><Link to={`/shop/item/${idx.id}`}>{idx.title}</Link>
                                                    </h6>
                                                </div>
                                            </div>
                                        </Link>
                                    ))
                                }
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    );
}

export default Shop;