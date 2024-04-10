import {Link} from "react-router-dom";

const Button = (props: { title: string; path: string; }) => {
    const {title , path} = props;
    return (
        <Link to={path} className="tf-button ">{title}</Link>
    );
}

export default Button;