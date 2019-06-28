
import axios from 'axios';
const baseUrl = require('../globalVariables').baseUrl;


export default class AccountManager {

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

        console.log(baseUrl, "BASE");
        let promise = new Promise( (resolve, reject) => {
            axios.post(`${baseUrl}/account`, {
                email: email,
                password: password
            }).then(res => {
                console.log(res, "RESULT");
                this.token = res.data.token;
                this.user = res.data.user;
                this.user["token"] = this.token;
                this.saveUserDataToLocalStorage();
                resolve(this.user);
            }).catch(err => {
                reject(err);
                console.log("There was an error during the login process");
        }) });

        return promise;
    }

    saveUserDataToLocalStorage(){
        localStorage.setItem("userData", JSON.stringify(this.user));
    }

    getUserDataFromLocalStorage() {
        this.user = JSON.parse(localStorage.getItem("userData"));
    }

    getUserToken(){
        this.getUserDataFromLocalStorage();
        return this.user.token;
    }

    getUserData() {
        this.getUserDataFromLocalStorage();
        return this.user;
    }

    checkIfLoggedIn(){
       return localStorage.getItem("userData") !== "";
    }

    signOutUser(){
        localStorage.removeItem("userData");
    }

}