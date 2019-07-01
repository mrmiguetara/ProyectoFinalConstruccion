import axios from 'axios';
const baseUrl = require('../globalVariables.js').baseUrl;
const baseEndpoint = `${baseUrl}/questions`;

const questionsMixin = {
    methods: {
        async getQuestionsForSection(sectionId){
            const endPoint = `${baseEndpoint}/section/${sectionId}`;
            return await axios.get(endPoint);
        },
        async getQuestion(id){
            return await axios.get(`${baseEndpoint}/${id}`);
        },
        async addQuestion(questionRequest){
            return await axios.post(baseEndpoint, questionRequest);
        },

        async updateQuestion(questionRequest) {
            return await axios.put(baseEndpoint, questionRequest);
        },

        async removeQuestion(id){
            return await axios.delete(`${baseEndpoint}/${id}`);
        }
    }
};

export default questionsMixin;