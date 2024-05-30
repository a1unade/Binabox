import ReactDOM from 'react-dom/client'
import {Provider} from 'react-redux';
import './assets/styles/styles.css'
import Routing from "./components/routing";
import store from "./store";

ReactDOM.createRoot(document.getElementById('root')!).render(
    <Provider store={store}>
        <Routing/>
    </Provider>
)
