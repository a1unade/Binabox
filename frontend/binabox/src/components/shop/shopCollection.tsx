import {Link} from "react-router-dom";
import IShopData from "../../interfaces/shop/IShopData.ts";
import noResults from "../../assets/images/icon/no-results.png";

const ShopCollection = (props: {shopItems: IShopData[]}) => {
    const {shopItems} = props;

    if (!shopItems) return <div>Loading...</div>;

    if(shopItems.length === 0) return <div><img src={noResults} alt={'no-results'}/><p>No results...</p></div>;

    return (
        <div className="items-list">
            {
                shopItems.map(idx => (
                    <div key={idx.id}>
                        <Link to={`/shop/item/${idx.id}`}>
                            <div className="col-lg-4 col-md-6 col-sm-6 col-12 ">
                                <div className="item">
                                    <div className="image">
                                        <img src={idx.image} alt="Binabox"/>
                                    </div>
                                    <h6 className="name"><Link
                                        to={`/shop/item/${idx.id}`}>{idx.title}</Link>
                                    </h6>
                                </div>
                            </div>
                        </Link>
                    </div>
                ))
            }
        </div>
    );
};

export default ShopCollection;