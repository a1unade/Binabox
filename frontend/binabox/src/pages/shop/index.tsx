import {Link, useLocation, useNavigate} from 'react-router-dom';
import PageTitle from "../../components/page-title";
import FilterType from "../../components/shop/filterType.tsx";
import {useEffect, useState} from "react";
import apiClient from "../../utils/axiosClient.ts";
import {filtersInitialState, toQueryString} from "../../types/shop/filtersInitialState.ts";
import IShopData from "../../interfaces/shop/IShopData.ts";
import ShopCollection from "../../components/shop/shopCollection.tsx";
import {useSiteTypedSelector} from "../../hooks/useTypedSelector.ts";

const Shop = () => {
    const [shopItems, setShopItems] = useState<IShopData[]>([]);
    const location = useLocation();
    const navigate = useNavigate();
    const searchParams = new URLSearchParams(location.search);
    const [usedFilters, setUsedFilters] = useState<{ [key: string]: string }>(filtersInitialState);
    const [searchInput, setSearchInput] = useState("");
    const {language} = useSiteTypedSelector(state => state.site);
    const [pagination, setPagination] = useState({ offset: 0, limit: 9 });

    useEffect(() => {
        const updatedFilters: { [key: string]: string } = {...filtersInitialState};

        for (const [key, value] of searchParams) {
            if (key.toUpperCase() in updatedFilters) updatedFilters[key.toUpperCase()] = value;
        }

        setUsedFilters(updatedFilters);
    }, [location.search]);

    useEffect(() => {
        if (!Object.keys(usedFilters).some(category => usedFilters[category] !== '')) {
            apiClient.get(`/shop/getShopItemsPaginated?offset=${pagination.offset}&limit=${pagination.limit}`)
                .then(res => {
                    setShopItems(res.data);
                });
        }
        else {
            apiClient.get(`/shop/getFilteredShopItems?${searchParams}`)
                .then(res => {
                    setShopItems(res.data)
                });
        }
    }, [location.search, pagination]);

    const handleNextPage = () => {
        setPagination((prev) => ({ ...prev, offset: prev.offset + prev.limit }));
    };

    const handlePrevPage = () => {
        setPagination((prev) => ({
            ...prev,
            offset: Math.max(0, prev.offset - prev.limit),
        }));
    };

    return (
        <div className='page-collection'>
            <PageTitle title={language === 'EN' ? 'SHOP' : 'МАГАЗИН'}/>
            <section className="tf-collection-inner">
                <div className="tf-container">
                    <div className="shop">
                        <div className="col-lg-3 col-md-4">
                            <div className="sidebar sidebar-collection">
                                <div className="widget widget-clothing widget-accordion">
                                    <FilterType title='CLOTHING' className='active'
                                                setUsedFilters={setUsedFilters}
                                                currentFilter={usedFilters['CLOTHING']}/>
                                </div>
                                <div className="widget widget-eyes widget-accordion">
                                    <FilterType title='EYES' className=''
                                                setUsedFilters={setUsedFilters}
                                                currentFilter={usedFilters['EYES']}/>
                                </div>
                                <div className="widget widget-face widget-accordion">
                                    <FilterType title='FACE' className=''
                                                setUsedFilters={setUsedFilters}
                                                currentFilter={usedFilters['FACE']}/>
                                </div>
                                <div className="widget widget-skin widget-accordion">
                                    <FilterType title='SKIN' className=''
                                                setUsedFilters={setUsedFilters}
                                                currentFilter={usedFilters['SKIN']}/>
                                </div>
                                <div className="widget widget-background widget-accordion">
                                    <FilterType title='BACKGROUND' className=''
                                                setUsedFilters={setUsedFilters}
                                                currentFilter={usedFilters['BACKGROUND']}/>
                                </div>
                                <div className="widget widget-special widget-accordion">
                                    <FilterType title='SPECIAL' className=''
                                                setUsedFilters={setUsedFilters}
                                                currentFilter={usedFilters['SPECIAL']}/>
                                </div>
                                <button style={{width: '70%'}} className="tf-button"
                                        onClick={() => navigate(`/shop?${toQueryString(usedFilters)}`)}>{language === 'EN' ? 'CONFIRM' : 'ПРИМЕНИТЬ'}
                                </button>
                            </div>
                        </div>
                        <div className="col-lg-9 col-md-8" style={{minWidth: 800}}>
                            <div className="top-option">
                                <h2 className="heading">{language === 'EN' ? 'All Items' : 'Все предметы'}</h2>
                                <div className="widget widget-search">
                                    <form method={'GET'} action={`/shop?`}>
                                        <input name={'search'} type="text" value={searchInput}
                                               onChange={(e) => {
                                                   setSearchInput(e.target.value)
                                                   setUsedFilters(prevState => ({
                                                       ...prevState,
                                                       ['SEARCH']: e.target.value
                                                   }))
                                               }}
                                               placeholder={language === 'EN' ? 'Search NFT' : 'Поиск NFT'}/>
                                        <a className="btn-search"><i className="icon-fl-search-filled"></i></a>
                                    </form>
                                </div>
                            </div>
                            {Object.keys(usedFilters).some(category => usedFilters[category] !== '') && (
                                <ul className="filter-content">
                                    {Object.entries(usedFilters).map(([category, filter]) => (
                                        filter !== '' && (
                                            <li key={category}>
                                                <Link to={''} onClick={() => setUsedFilters(prevState => ({
                                                    ...prevState,
                                                    [category]: ''
                                                }))}>
                                                    {category}: {filter} <i className="fal fa-times"></i>
                                                </Link>
                                            </li>
                                        )
                                    ))}
                                    <li>
                                        <Link to={''}
                                              onClick={() => setUsedFilters(filtersInitialState)}>{language === 'EN' ? 'CLEAR ALL' : 'ОЧИСТИТЬ'}</Link>
                                    </li>
                                </ul>
                            )}
                            <ShopCollection shopItems={shopItems}/>
                            <div style={{display: "flex", alignItems: 'center', justifyContent: 'center', gap: 100, marginTop: 50 }}>
                                <button style={{width: 150}} onClick={handlePrevPage}>Previous</button>
                                <button style={{width: 150}} onClick={handleNextPage}>Next</button>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    );
}

export default Shop;