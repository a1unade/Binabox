import {useEffect, useState} from "react";
import ITransaction from "../../interfaces/profile/ITransaction.ts";
import apiClient from "../../utils/axiosClient.ts";
import {useSiteTypedSelector} from "../../hooks/useTypedSelector.ts";

const Transactions = () => {
    const [transactions, setTransactions] = useState<ITransaction[]>([]);
    const userId = document.cookie.split("=")[1];
    const {language} = useSiteTypedSelector(state => state.site);

    useEffect(() => {
        apiClient.get(`User/getUserTransactions?userId=${userId}`)
            .then(res => {
               if (res.status === 200) setTransactions(res.data);
               else console.log("Error getting user transactions");
            });
    }, [userId])
    return (
        <section className="tf-section tf-about">
            <div className="tf-container">
                <div className="row">
                    <div className="tf-heading">
                        <h2 className="heading">{language === 'EN' ? 'Transactions' : 'Транзакции'}</h2>
                    </div>
                    <table>
                        <thead>
                        <tr>
                            <th>ID</th>
                            <th>{language === 'EN' ? 'Name' : 'Название'}</th>
                            <th>{language === 'EN' ? 'Date' : 'Дата'}</th>
                        </tr>
                        </thead>
                        <tbody>
                        {transactions.map(transaction => (
                            <tr key={transaction.id}>
                                <td>{transaction.id}</td>
                                <td>{transaction.name}</td>
                                <td>{transaction.date}</td>
                            </tr>
                        ))}
                        </tbody>
                    </table>
                </div>
            </div>
        </section>
    );
};

export default Transactions;
