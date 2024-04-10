import ILogoProps from "../../interfaces/logo/ILogoProps.ts";

const Logo = (props: ILogoProps) => {
    const {data} = props;

    return (
        <section className="logo-slider">
            <div className="logo-slider-wrap">
                <div className="logo-slider-inner">
                    { data.map(idx => (<h3 key={idx.id}>{idx.name}</h3>)) }
                </div>
                <div className="logo-slider-inner style-2">
                    { data.map(idx => (<h3 key={idx.id}>{idx.name}</h3>)) }
                </div>
            </div>
        </section>
    );
}

export default Logo;