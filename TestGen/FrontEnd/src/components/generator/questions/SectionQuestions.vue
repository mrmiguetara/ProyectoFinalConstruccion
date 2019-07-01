<template>
    <div>
        <button class="badge-btn bg-secondary text-white" @click="addQuestion">
            <font-awesome-icon icon="plus"/>
            Add Question
        </button>
        <single-question v-for="(question, key) in questions"
                         :key="key"
                         :question="question"
                         :section-id="sectionId"
                         :index="key + 1"/>
    </div>
</template>

<script>
    import bus from '../../../mixins/EventBus.js';
    import SingleQuestion from './SingleQuestion.vue'
    const questionsMixing = require('../../../mixins/questions.mixing.js').default;
    export default {
        name: 'section-questions',
        mixins: [questionsMixing],
        props: {
            sectionId: {
                required: true
            }
        },
        data(){
            return {
                questions: []
            };
        },
        components: {
          SingleQuestion
        },
        methods: {
            addQuestion(){
                bus.$emit('question.add', this.sectionId);
            },
            getAllQuestions(){
                this.getQuestionsForSection(this.sectionId).then(response => {
                    this.questions = response.data;
                });
            }
        },
        created(){
            this.getAllQuestions();
            let busEvent = 'question.response.'+this.sectionId;
            bus.$on(busEvent, this.getAllQuestions);
        }
    }
</script>

