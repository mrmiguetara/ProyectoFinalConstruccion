<template>
    <div>
        <b-modal id="question-modal" size="xl" v-model="visible">
            <template slot="modal-title">{{title}}</template>
            <form @submit.prevent="">
                <div class="row">
                    <div :class="{'col-5': form.questionTypeId != 4, 'col-12': form.questionTypeId == 4}">
                        <div class="form-group">
                            <label>Question Type</label>
                            <select class="form-control" v-model="form.questionTypeId" @change="changeAnswers">
                                <option value="1">True or False</option>
                                <option value="2" selected="selected">Multiple Choice</option>
                            </select>
                        </div>
                    </div>
                    <div :class="{'col-7': form.questionTypeId != 4, 'col-12': form.questionTypeId == 4}">
                        <div class="form-group">
                            <label>Title</label>
                            <input type="text" class="form-control" v-model="form.title" required>
                        </div>
                    </div>
                </div>
                <div class="row" v-if="showOptions">
                    <div class="col">
                        <label>Options</label>
                        <div class="input-group"
                             style="margin-bottom: 5px;"
                             v-for="(option, key) in options">
                            <span class="input-group-prepend">
                                <button type="button" class="btn anti-btn">{{key}}</button>
                            </span>
                            <input type="text" class="form-control" v-model="options[key]">
                        </div>
                    </div>
                </div>
                <div class="row" v-if="form.questionTypeId != 4">
                    <div class="col">
                        <div class="form-group">
                            <label>Answer</label>
                            <select class="form-control" v-model="form.answer" required>
                                <option disabled selected="selected" value="0">Select an option</option>
                                <option v-for="(answer, i) in answers"
                                        :key="i"
                                        :value="answer">{{answer}}</option>
                            </select>
                        </div>
                    </div>
                </div>
            </form>
            <template slot="modal-footer">
                <b-button @click="visible = false" variant="outline-secondary">Cancel</b-button>
                <b-button @click="submit" variant="secondary">{{buttonText}}</b-button>
            </template>
        </b-modal>
    </div>
</template>

<script>
    import questionMixin from '../../../mixins/questions.mixing.js';
    import bus from '../../../mixins/EventBus.js';
    export default {
        name: 'question-form-modal',
        mixins: [questionMixin],
        data(){
           return {
               visible: false,
               id: 0,
               editing: false,
               answers: ["true", "false"],
               options: {
                   a: '',
                   b: '',
                   c: '',
                   d: ''
               },
               form: {
                   sectionId: 0,
                   title: '',
                   options: '',
                   questionTypeId: 1,
                   answer: ''
               }
           }
        },
        computed: {
            title(){
                return this.editing ? 'Update Question' : 'Create Question'
            },
            showOptions(){
                if(this.form.questionTypeId == 2 || this.form.questionTypeId == 3){
                    return true;
                }else {
                    return false;
                }
            },
            buttonText(){
                return this.editing ? 'Update' : 'Create';
            }
        },
        methods: {
            submit(){
                const qusetionType = this.form.questionTypeId;
                const question = this.prepareQuestionObject(qusetionType);

                if(this.formIsValid()){
                    if (!this.editing) {
                        this.addQuestion(question).then(() => {
                            this.emitSuccesMessage();
                        })
                    } else {
                        question['id'] = this.id;
                        this.updateQuestion(question).then(() => {
                            this.emitSuccesMessage();
                        })
                    }
                }

            },
            emitSuccesMessage(){
                let busEvent = 'question.response.' + this.form.sectionId;
                bus.$emit(busEvent);
                this.resetForm();
                this.visible = false;
            },
            prepareQuestionObject(type){
                const operationTypes = {
                    '1': this.setTrueOrFalse,
                    '2': this.setMutlipleChoice,
                    '3': this.setMutlipleChoice,
                    '4': this.setOpenAnswer
                };
                return operationTypes[type]();
            },
            setTrueOrFalse(){
                const question = {
                    sectionId: this.form.sectionId,
                    title: this.form.title,
                    questionTypeId: this.form.questionTypeId,
                    answer: this.form.answer
                };
                return question;
            },
            setMutlipleChoice(){
                const question = {
                    sectionId: this.form.sectionId,
                    title: this.form.title,
                    options: JSON.stringify(this.options),
                    questionTypeId: this.form.questionTypeId,
                    answer: this.form.answer
                };
                return question;
            },
            setOpenAnswer(){
              const question = {
                  sectionId: this.form.sectionId,
                  title: this.form.title,
                  questionTypeId: this.form.questionTypeId
              };
              return question;
            },
            setEditMode(question){
                this.resetForm();
                this.form['id'] = question.id;
                this.id = question.id;
                this.editing = true;

                for(let key in question){
                    if(this.form.hasOwnProperty(key)) {
                        this.form[key] = question[key];
                    }
                }
                this.changeAnswers();
                if(question.questionTypeId == 2 || question.questionTypeId == 3) {
                    this.options = JSON.parse(question.options);
                }

                this.visible = true;
            },
            setCreateMode(sectionId){
                this.resetForm();
                this.editing = false;
                this.visible = true;
                this.form.sectionId = sectionId;
                delete this.form['id'];
            },
            changeAnswers(){
                const type = this.form.questionTypeId;
                if(type == 1){
                    this.answers = ["true", "false"]
                }else{
                    this.answers = [];
                    for(let key in this.options){
                        this.answers.push(key);
                    }
                }
            },
            resetForm(){
                this.form = {
                    sectionId: 0,
                    title: '',
                    options: '',
                    questionTypeId: 1,
                    answer: ''
                };
                this.options = {
                    a: '',
                    b: '',
                    c: '',
                    d: ''
                }
            },
            formIsValid(){
                return true;
            }
        },
        created() {
            bus.$on('question.add', this.setCreateMode);
            bus.$on('question.edit', this.setEditMode);
        }
    }
</script>

<style lang="scss">
    .input-group {
        .btn {
            box-shadow: none;
            &.anti-btn {
                border: 1px solid rgba(10, 10, 10, 0.2);
                background: rgba(240, 240, 240, 0.5);
                color: rgba(150, 150, 150, 1);
                cursor: default;
                width: 70px;
                border-right: none;
            }
        }
    }
</style>