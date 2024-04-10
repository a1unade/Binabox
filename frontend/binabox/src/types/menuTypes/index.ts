import {IMenuItem} from "../../interfaces/menu/IMenuItem.ts";
import Home from "./items/Home.ts";
import About from "./items/About.ts";
import Shop from "./items/Shop.ts";
import Payments from "./items/Payments.ts";
import AdminPanel from "./items/AdminPanel.ts";
import Blog from "./items/Blog.ts";


const MenuItems: IMenuItem[] = [Home, About, Shop, Payments, AdminPanel, Blog]

export default MenuItems;