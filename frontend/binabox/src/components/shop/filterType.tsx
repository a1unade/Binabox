import {Accordion} from "react-bootstrap-accordion";
import React, {useEffect, useState} from 'react';
import apiClient from "../../utils/axiosClient.ts";

const FilterType = (props: {
    className: string,
    title: string,
    setUsedFilters: React.Dispatch<React.SetStateAction<{ [p: string]: string }>>,
    currentFilter: string
}) => {
    const {className, title, setUsedFilters, currentFilter} = props;
    const [filters, setFilters] = useState<string[]>();
    const [selectedFilter, setSelectedFilter] = useState<string>(currentFilter);

    useEffect(() => {
        apiClient.get(`Shop/getCategoryFilters?name=${title}`)
            .then(res => {
                if (res.data.responseType === 0) setFilters(res.data.filters);
            })
    }, [title]);

    const handleFilterChange = (filter: string) => {
        setSelectedFilter(prevFilter => prevFilter === filter ? '' : filter);
        setUsedFilters(prevState => ({...prevState, [title]: filter}))
    };

    if(!filters || filters.length === 0) return null;

    return (
        <div className={`widget-title ${className}`}>
            <Accordion title={title}>
                <div className="widget-content toggle-content">
                    {filters.map((filter) =>
                        <label key={filter} className="checkbox-item">
                            <span className="custom-checkbox">
                                <input type="checkbox" checked={selectedFilter === filter || currentFilter === filter}
                                       onChange={() => handleFilterChange(filter)}/>
                                <span className="btn-checkbox"></span>
                            </span>
                            <span>{filter}</span>
                        </label>
                    )}
                </div>
            </Accordion>
        </div>
    );
};

export default FilterType;
