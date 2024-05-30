import IBlogDetailsData from "../interfaces/blog-details/IBlogDetailsData.ts";
import img1 from '../assets/images/blog/blog-details-1.jpg'
import img2 from '../assets/images/blog/blog-details-2.jpg'
import img3 from '../assets/images/blog/blog-details-3.jpg'
import img4 from '../assets/images/blog/prev-post.jpg'
import img5 from '../assets/images/blog/next-post.jpg'


export const dataBlogDetails: IBlogDetailsData = {
    id: 4,
    category: 'GAMING',
    user: 'Tony Nguyen',
    date: '20 Jun 2022',
    content: {
        id: 1,
        p1: 'The Basilisks that players collect are represented with NFTs on Ethereum’s blockchain with real-world value. Players use the Basilisks they have gathered to battle other players to win ether (ETH).',
        p2: 'In Balthazar Dragons, players are immersed in a 3D open world to explore and capture dragon-like beasts called Basilisks.  Balthazar Dragons is an upcoming fantasy role-playing game developed on the Ethereum blockchain by a decentralized autonomous organization (DAO) called the Balthazar DAO.',
        p3: 'Setting up your avatar and personalizing your nickname on Binance is quick and easy. Users can go to binance.com under Dashboard Settings My Profile Avatar and Nickname. For those of you who own NFT assets, you can select the NFT you want to use from your collection as your avatar to personalize your profile. For users who do not own any NFT avatars, check out the NFT avatar collections page to get started.',
        p4: 'Alternatively, if you are on nft.binance.com, go to User Center Settings Basic Set Avatar and Nickname, and you all be redirected to the main site. Binance NFT Creators have the option of setting their Avatars on nft.binance.com. Once you set your new unique nickname, it will be standardized and used across the Binance ecosystem.',
        p5: 'You can find a range of NFT marketplaces where you can buy existing NFTs or list your own NFTs for sale.',
        title1: 'Enior Apple Employee Alleges Sexism At',
        title2: 'NFTs Are Digital Assets That Represent Real-world Objects',
        title3: 'NFT Avatar Generators',
        post: {
            id: 1,
            title: '“The First Huge Metaverse Arena To Arrange Live Sports, Hang Out And Even Make Bets And Wagers”',
            rating: 8.5,
            author: 'Markout Corporation'
        },
        images: {
            id: 1,
            img1: img1,
            img2: img2,
            img3: img3
        }
    },
    tags: {
        tag1: 'ICO',
        tag2: 'CYPPUNK',
        tag3: 'LIGHT'
    },
    previous: {
        id: 3,
        title: 'Enior Apple Employee Alleges Sexism At',
        img: img4
    },
    next: {
        id: 5,
        title: 'Enior Apple Employee Alleges Sexism At',
        img: img5
    }
}