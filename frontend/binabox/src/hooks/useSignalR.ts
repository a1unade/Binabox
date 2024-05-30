import React, {useEffect} from 'react';
import {HubConnectionBuilder} from '@microsoft/signalr';

export const useSignalR = (props: { setIsEmailConfirmed: React.Dispatch<React.SetStateAction<boolean>> }) => {
    const {setIsEmailConfirmed} = props;

    useEffect(() => {
        const newConnection = new HubConnectionBuilder()
            .withUrl('http://localhost:5112/emailConfirmationHub').build();

        newConnection.on('ReceiveEmailConfirmationStatus', (status) => {
            newConnection.stop().then(() => {
                setIsEmailConfirmed(status);
                console.log('connection stopped!')
            })
        });

        newConnection.start()
            .then(() => {
                console.log("Connection established");
            })
            .catch((error) => {
                console.error(error);
            });
    }, []);
};