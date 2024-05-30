import { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import sun from '../../assets/images/icon/sun.png';
import moon from '../../assets/images/icon/moon.png';

const DarkMode = () => {
    const clickedClass = "clicked";
    const [theme, setTheme] = useState<string>(() => {
        return localStorage.getItem('theme') || "is_dark";
    });

    const switchTheme = () => {
        const body = document.body;
        const switcher = document.getElementById('theme-switcher');
        const lightTheme = "is_light";
        const darkTheme = "is_dark";

        if (theme === darkTheme) {
            body.classList.replace(darkTheme, lightTheme);
            switcher!.classList.remove(clickedClass);
            setTheme(lightTheme);
            localStorage.setItem('theme', lightTheme);
        } else {
            body.classList.replace(lightTheme, darkTheme);
            switcher!.classList.add(clickedClass);
            setTheme(darkTheme);
            localStorage.setItem('theme', darkTheme);
        }
    };

    useEffect(() => {
        const body = document.body;
        const switcher = document.getElementById('theme-switcher');
        const lightTheme = "is_light";
        const darkTheme = "is_dark";

        if (theme === lightTheme) {
            body.classList.replace(darkTheme, lightTheme);
            switcher!.classList.remove(clickedClass);
        } else {
            body.classList.replace(lightTheme, darkTheme);
            switcher!.classList.add(clickedClass);
        }
    }, [theme, clickedClass]);

    return (
        <div className="mode-switcher" id='theme-switcher'>
            <Link className='sun mode-switch' to="#" onClick={() => switchTheme()}>
                <img src={moon} alt="moon"/>
            </Link>
            <Link className='moon mode-switch' to="#" onClick={() => switchTheme()}>
                <img src={sun} alt="sun"/>
            </Link>
        </div>
    );
}

export default DarkMode;
