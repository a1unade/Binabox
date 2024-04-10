import IContactData from "../interfaces/contact/IContactData.ts";
import icon1 from '../assets/images/svg/loaction.svg'
import icon2 from '../assets/images/svg/email.svg'
import icon3 from '../assets/images/svg/phone.svg'
export const dataContact: IContactData[] = [
    {
        id: 1,
        title: "Location",
        img: icon1,
        info: "2163 Phillips Gap Rd West Jefferson"
    },
    {
        id: 2,
        title: "Email",
        img: icon2,
        info: "Info.avitex@gmail.com"
    },
    {
        id: 3,
        title: "Phone",
        img: icon3,
        info: "+1 666 8888"
    }
]

