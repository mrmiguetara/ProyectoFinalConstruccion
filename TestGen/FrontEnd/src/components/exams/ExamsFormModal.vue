<template>
    <div>
        <b-modal id="exam-modal" v-model="visible">
            <template slot="modal-title">{{title}}</template>

            <form @submit.prevent="submit">
                <div class="form-group" :class="{'is-invalid': $v.form.subject.$error}">
                    <label>Subject</label>
                    <input type="text" v-model.trim.lazy="$v.form.subject.$model" placeholder="Write the exam subject" class="form-control" required>
                    <span class="form-text text-danger" v-if="$v.form.subject.$error">This is a required field</span>
                </div>
                <div class="form-group" :class="{'is-invalid': $v.form.teacher.$error}">
                    <label>Teacher</label>
                    <input type="text" v-model.trim.lazy="$v.form.teacher.$model" placeholder="Write the exam teacher" class="form-control" required>
                    <span class="form-text text-danger" v-if="$v.form.teacher.$error">This is a required field</span>
                </div>
            </form>

            <template slot="modal-footer">
                <b-button @click="cancel" variant="outline-secondary">Cancel</b-button>
                <b-button @click="submit" variant="secondary">{{buttonText}}</b-button>
            </template>
        </b-modal>
    </div>
</template>

<script>
    import { required } from 'vuelidate/lib/validators'

    const accountManager = require('../../managers/account.manager.js').default;
    accountManager.getUserDataFromLocalStorage();
    const userId = accountManager.getUserData().id;

    const examMixin = require('../../mixins/exams.mixing.js').default;

    export default {
        name: 'exam-form-modal',
        mixins: [examMixin],
        props: ['visible'],
        data(){
          return {
              editing: false,
                form: {
                    subject: '',
                    teacher: '',
                    userId: userId,
                }
          };
        },
        validations: {
          form: {
              subject: {
                  required
              },
              teacher: {
                  required
              }
          }
        },
        computed: {
            title(){
                return this.editing ? `Edit Exam (${this.form['id']})` : `Create new exam`;
            },
            buttonText(){
                return this.editing ? `Update Exam` : `Create Exam`;
            }
        },
        methods: {
            cancel(){
                this.$v.form.$reset();
                this.$emit('cancel')
            },
            submit() {
                this.$v.form.$touch();
                if (!this.$v.form.$invalid) {
                    if (!this.editing){
                        this.createExam(this.form).then(() => {
                           this.$emit('success');
                           this.cancel();
                        });
                    } else {
                        this.updateExam(this.form).then(() => {
                            this.$emit('success');
                            this.cancel();
                        });
                    }
                }
            },
            setEditMode(exam){
                this.editing = true;
                this.form.subject = exam.subject;
                this.form.teacher = exam.teacher;
                this.form['id'] = exam.id;
            },
            setCreateMode(){
                this.editing = false;
                this.form.subject = '';
                this.form.teacher = '';
                delete this.form['id'];
            }
        }
    }

</script>
