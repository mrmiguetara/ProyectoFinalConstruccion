import axios from 'axios';


const baseUrl = require('../globalVariables.js').baseUrl;
const accountManager = require('../managers/account.manager.js').default;

let user;

const examsMixing = {
    data(){
      return {
          user: {}
      }
    },
    methods: {
        getUserExams: async () => {
           return checkHasToken(async () => {
               const endPoint = `${baseUrl}/exams/user/${user["id"]}`;
               return await axios.get(endPoint);
           });
        },

        createExam: async (examRequest) => {
            return checkHasToken(async () => {
                const endPoint = `${baseUrl}/exams`;
                return await axios.post(endPoint, examRequest);
            })
        },

        updateExam: async (examRequest) => {
            return checkHasToken( async () => {
                const endPoint = `${baseUrl}/exams`;
                return await axios.put(endPoint, examRequest);
            })
        },

        deleteExam: async (examId) => {
            return checkHasToken(async () => {
                const endPoint = `${baseUrl}/exams/${examId}`;
                return await axios.delete(endPoint);
            })
        }
    },
    created: () => {
        accountManager.getUserDataFromLocalStorage();
        user = accountManager.getUserData();
    }
};

function checkHasToken(callback){
    if(accountManager.checkIfLoggedIn()){
        return callback();
    }
}


export default examsMixing;