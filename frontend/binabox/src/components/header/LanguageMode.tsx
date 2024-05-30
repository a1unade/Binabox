import {useEffect, useState} from "react";
import russian from "../../assets/images/icon/ru.png";
import english from "../../assets/images/icon/en.png";
import {useSiteActions} from "../../hooks/useActions.ts";

const LanguageMode = () => {
    const clickedClass = "clicked";
    const {switchLanguage} = useSiteActions()
    const [lang, setLang] = useState<string>(() => {
        return localStorage.getItem('lang') || "EN";
    });

    const switchLang = () => {
        const switcher = document.getElementById('lang-switcher');
        const enLang = "EN";
        const ruLang = "RU";

        if (lang === enLang) {
            switcher!.classList.remove(clickedClass);
            setLang(ruLang);
            localStorage.setItem('lang', ruLang);
        } else {
            switcher!.classList.add(clickedClass);
            setLang(enLang);
            localStorage.setItem('theme', enLang);
        }
        switchLanguage(lang);
    };

    useEffect(() => {
        const switcher = document.getElementById('lang-switcher');
        const enLang = "EN";
        const ruLang = "RU";

        if (lang === enLang) {
            switchLanguage(enLang);
            switcher!.classList.remove(clickedClass);
        } else {
            switchLanguage(ruLang);
            switcher!.classList.add(clickedClass);
        }


    }, [lang, clickedClass]);

    return (
        <div className="mode-switcher" id='lang-switcher' style={{cursor: 'pointer'}}>
            <div className='sun mode-switch' style={{overflow: 'hidden'}} onClick={() => switchLang()}>
                <img style={{width: '100%', height: '100%'}} src={lang === 'EN' ? english : russian} alt="russian"/>
            </div>
            <div className='moon mode-switch' style={{overflow: 'hidden'}} onClick={() => switchLang()}>
                <img style={{width: '100%', height: '100%'}} src={lang === 'EN' ? english : russian} alt="russian"/>
            </div>
        </div>
    );
}

export default LanguageMode;