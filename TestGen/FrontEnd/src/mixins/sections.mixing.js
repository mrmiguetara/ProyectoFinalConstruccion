import axios from 'axios';
const baseUrl = require('../globalVariables.js').baseUrl;
const baseEndpoint = `${baseUrl}/sections`;

const sectionsMixin = {
    methods: {
        async addSection(instruction, examId){
            await axios.post(baseEndpoint, {
                instruction: instruction,
                examId: examId
            });
        },


        async updateSection(id, instruction, examId){
            await axios.put(baseEndpoint, {
                id: id,
                instruction: instruction,
                examId: examId
            });
        },

        async removeSection(id){
            await axios.delete(`${baseEndpoint}/${id}`);
        },

        async getSections(examId){
            const endPoint = `${baseEndpoint}/exam/${examId}`;
            return await axios.get(endPoint);
        }

    }
};

export default sectionsMixin;