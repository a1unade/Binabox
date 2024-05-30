import {ChangeEvent, useState} from 'react';
import apiClient from "../../utils/axiosClient.ts";
import {useUserActions} from "../../hooks/useActions.ts";
import {useSiteTypedSelector, useUserTypedSelector} from "../../hooks/useTypedSelector.ts";

const SellItem = () => {
    const [image, setImage] = useState<File>();
    const [title, setTitle] = useState('');
    const [description, setDescription] = useState('');
    const [price, setPrice] = useState('');
    const [face, setFace] = useState('');
    const [clothing, setClothing] = useState('');
    const [eyes, setEyes] = useState('');
    const [skin, setSkin] = useState('');
    const [background, setBackground] = useState('');
    const [special, setSpecial] = useState('');
    const {subscription} = useUserTypedSelector(state => state.user);
    const {language} = useSiteTypedSelector(state => state.site);
    const {addBalance} = useUserActions();

    const handleSubmit = async () => {
        try {
            const saveFileResponse = await apiClient.post('Site/saveFile',
                {
                    file: image
                },
                {
                    headers: {
                        'Content-Type': 'multipart/form-data'
                    }
                });

            if (saveFileResponse.data.responseType === 0) {
                const imageUrl = saveFileResponse.data.url;

                const addItemResponse = await apiClient.post('Shop/addItem', {
                    image: imageUrl,
                    title: title,
                    description: description,
                    price: price,
                    face: face,
                    clothing: clothing,
                    eyes: eyes,
                    skin: skin,
                    background: background,
                    special: special
                });

                if (addItemResponse.data.responseType === 0) {
                    console.log('Item added successfully:', addItemResponse.data);
                    setImage(undefined);
                    setTitle('');
                    setDescription('');
                    setPrice('');
                    setFace('');
                    setClothing('');
                    setEyes('');
                    setSkin('');
                    setBackground('');
                    setSpecial('');
                    if (subscription === 1) addBalance(parseInt(price) * 0.7);
                    if (subscription === 2) addBalance(parseInt(price) * 0.85);

                } else {
                    console.error('Error adding item:', addItemResponse.data.errors);
                }
            } else {
                console.error('Error saving file:', saveFileResponse.data.errors);
            }
        } catch (error) {
            console.error('Error:', error);
        }
    };

    const handleFileChange = (e: ChangeEvent<HTMLInputElement>) => {
        if (e.target.files && e.target.files.length > 0) {
            setImage(e.target.files[0]);
        }
    };

    return (
        <section className="tf-section tf-about">
            <div className="tf-container">
                <div className="tf-heading">
                    <h2 className="heading">{language === 'EN' ? 'Sell item' : 'Продать предмет'}</h2>
                </div>
                <div className="form-container">
                    <div className="form-group">
                        <label htmlFor="image">Image:</label>
                        <input id="image" type="file" onChange={handleFileChange}/>
                    </div>
                    <div className="form-group">
                        <label htmlFor="title">Title:</label>
                        <input id="title" type="text" style={{width: 770}} value={title}
                               onChange={(e) => setTitle(e.target.value)}/>
                    </div>
                    <div className="form-group">
                        <label htmlFor="description">Description:</label>
                        <textarea id="description" style={{width: 770}} value={description}
                                  onChange={(e) => setDescription(e.target.value)}/>
                    </div>
                    <div className="form-group">
                        <label htmlFor="price">Price:</label>
                        <input id="price" type="number" style={{width: 770}} value={price}
                               onChange={(e) => setPrice(e.target.value)}/>
                    </div>
                    <div className="form-group">
                        <label htmlFor="face">Face:</label>
                        <input id="face" type="text" style={{width: 770}} value={face}
                               onChange={(e) => setFace(e.target.value)}/>
                    </div>
                    <div className="form-group">
                        <label htmlFor="clothing">Clothing:</label>
                        <input id="clothing" type="text" style={{width: 770}} value={clothing}
                               onChange={(e) => setClothing(e.target.value)}/>
                    </div>
                    <div className="form-group">
                        <label htmlFor="eyes">Eyes:</label>
                        <input id="eyes" type="text" style={{width: 770}} value={eyes}
                               onChange={(e) => setEyes(e.target.value)}/>
                    </div>
                    <div className="form-group">
                        <label htmlFor="skin">Skin:</label>
                        <input id="skin" type="text" style={{width: 770}} value={skin}
                               onChange={(e) => setSkin(e.target.value)}/>
                    </div>
                    <div className="form-group">
                        <label htmlFor="background">Background:</label>
                        <input id="background" type="text" style={{width: 770}} value={background}
                               onChange={(e) => setBackground(e.target.value)}/>
                    </div>
                    <div className="form-group">
                        <label htmlFor="special">Special:</label>
                        <input id="special" type="text" style={{width: 770}} value={special}
                               onChange={(e) => setSpecial(e.target.value)}/>
                    </div>
                    <button style={{width: 717}} type="submit" onClick={handleSubmit}>{language === 'EN' ? 'Submit' : 'Продать'}</button>
                </div>
            </div>
        </section>
    );
};

export default SellItem;
