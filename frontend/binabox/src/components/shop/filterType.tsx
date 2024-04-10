import {Accordion} from "react-bootstrap-accordion";

const FilterType = (props: {className: string, filters: string[], title: string}) => {
    const {className, filters, title} = props;
    return (
        <div className={`widget-title ${className}`}>
            <Accordion title={title}>
                <div className="widget-content toggle-content">
                    {filters.map((filter) =>
                        <label className="checkbox-item">
                            <span className="custom-checkbox">
                                <input type="checkbox"/>
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