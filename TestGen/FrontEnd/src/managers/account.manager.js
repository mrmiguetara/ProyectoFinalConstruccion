
import axios from 'axios';
const baseUrl = require('../globalVariables').baseUrl;


class AccountManager {

    constructor() {
        this.token = "";
        this.user = "";
    }

    /***
     * Retrieves the JSON token from the web server
     * @param email
     * @param pasword
     */
    logUserIn(email, password){

        let promise = new Promise( (resolve, reject) => {
            axios.post(`${baseUrl}/account`, {
                email: email,
                password: password
            }).then(res => {
                this.token = res.data.token;
                this.user = res.data.user;
                this.user["token"] = this.token;
                this.saveUserDataToLocalStorage();
                axios.defaults.headers.common["Authorization"] = `Bearer ${this.user.token}`;
                resolve(this.user);
            }).catch(err => {
                reject(err);
        }) });

        return promise;
    }

    saveUserDataToLocalStorage(){
        localStorage.setItem("userData", JSON.stringify(this.user));
    }

    getUserDataFromLocalStorage() {
        this.user = JSON.parse(localStorage.getItem("userData"));
        if (this.user != null) {
            axios.defaults.headers.common["Authorization"] = `Bearer ${this.user.token}`;
        } else {
            this.user = {
                id: 0,
                token: ''
            };
        }
    }

    /***
     * Gets the user token
     * @returns {string|CancelToken|*}
     */
    getUserToken(){
        this.getUserDataFromLocalStorage();
        return this.user.token;
    }

    /***
     * This methods returns the user object stored in the localStorage
     * @returns {object}
     */
    getUserData() {
        this.getUserDataFromLocalStorage();
        if (this.user == null){
            this.user = {
                id: 0
            };
        }
        return this.user;
    }

    checkIfLoggedIn(){
       if (localStorage.getItem("userData") !== null) {
           this.getUserDataFromLocalStorage();
           axios.defaults.headers.common["Authorization"] = `Bearer ${this.user.token}`;
           return true;
       }
       return false
    }

    signOutUser(){
        localStorage.removeItem("userData");
    }

}

export default new AccountManager();

export function checkHasToken(callback){
    if(accountManager.checkIfLoggedIn()){
        return callback();
    }
}