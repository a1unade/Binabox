const Button03 = (props: { title: string; path: string; }) => {
    const {title , path} = props;
    return (
        <a href={path} className="tf-button discord"><i className="icon-fl-vt"></i><span>{title}</span></a>
    );
}

export default Button03;