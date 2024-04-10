import { Link } from 'react-router-dom';
import IItemDetailsProps from "../../../interfaces/itemdetails/IItemDetailsProps.ts";
import PageTitle from "../../../components/pagetitle";
import Category from "../../../components/itemdetails/category";
import Suggestions from "../../../components/itemdetails/suggestions";

const ItemDetails = (props: IItemDetailsProps) => {
    const {data, suggestions} = props;

    return (
        <div className='page-collection'>
            <PageTitle title='ITEM DETAILS' />
            <section className=" tf-item-detail ">
                <div className="tf-container">
                    <div className="item-details">
                        <div className="item-details-img">
                            <div className="tf-item-detail-image">
                                <img src={data.img} alt="Binabox" />
                            </div>
                        </div>
                        <div className="col-lg-6 col-md-12">
                            <div className="tf-item-detail-inner">
                                <h2 className="title">{data.title}</h2>
                                <p className="des">{data.description}</p>
                                <div className="infor-item-wrap">
                                    {data.categories.map((category) =>
                                        <Category id={category.id} name={category.name} info={category.info}/>
                                    )}
                                </div>
                                <div className="price">
                                    <span className="heading">PRICE: </span>
                                    <span>{data.price} ETH</span>
                                </div>
                                <div className="group-btn">
                                    <Link to="#" className="tf-button opensea"><i className="icon-fl-bag"></i> BUY </Link>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <Suggestions data={suggestions}/>
        </div>
    );
}

export default ItemDetails;