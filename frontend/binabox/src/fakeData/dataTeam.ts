import img1 from '../assets/images/team/team-1.jpg'
import img2 from '../assets/images/team/team-2.jpg'
import img3 from '../assets/images/team/team-3.jpg'
import img4 from '../assets/images/team/team-4.jpg'
import img5 from '../assets/images/team/team-5.jpg'
import img6 from '../assets/images/team/team-6.jpg'
import img7 from '../assets/images/team/team-7.jpg'
import ITeamProps from "../interfaces/team/ITeamProps.ts";


const dataTeam: ITeamProps = {
    data: [
        {
            id: 1,
            img: img1,
            name: 'Ralph Edwards',
            position :'Founder'
        },
        {
            id: 2,
            img: img2,
            name: 'Jason Smith',
            position :'Co - Founder'
        },
        {
            id: 3,
            img: img3,
            name: 'Tony Wings',
            position :'Web Designer'
        },
        {
            id: 4,
            img: img4,
            name: 'Esther Howard',
            position :'Project Manager'
        },
        {
            id: 5,
            img: img5,
            name: 'Jenny Wilson',
            position :'Artist'
        },
        {
            id: 6,
            img: img6,
            name: 'Robert Fox',
            position :'UI/UX Designer'
        },
        {
            id: 7,
            img: img7,
            name: 'Devon Lane',
            position :'Ux Architect'
        }
    ]
}

export default dataTeam;