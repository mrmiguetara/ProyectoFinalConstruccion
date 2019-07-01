<template>
    <div>
        <b-modal id="section-modal" v-model="visible" @hidden="$emit('cancel')" @close="$emit('cancel')">
            <template slot="modal-title">{{title}}</template>
            <form @submit.prevent="submit">
                <div class="form-group" :class="{'is-invalid': $v.form.instruction.$error}">
                    <label>Instruction</label>
                    <input type="text" class="form-control" v-model.trim.lazy="$v.form.instruction.$model" placeholder="Instruction"/>
                    <span class="form-text text-danger" v-if="$v.form.instruction.$error">This is a required field</span>
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
    import { required } from 'vuelidate/lib/validators';
    const sectionMixing = require('../../../mixins/sections.mixing.js').default;
    export default  {
        name: 'section-form-modal',
        mixins: [sectionMixing],
        props: {
            visible: {
                type: Boolean,
                default: false
            },
            examId: {
                required: true
            }
        },
        data(){
            return {
                editing: false,
                form: {
                    instruction: '',
                    examId: this.$route.params.id
                }
            }
        },
        validations: {
            form: {
                instruction: {
                    required
                }
            }
        },
        methods: {
            submit(){
                this.$v.form.$touch();
                if(!this.$v.form.$invalid){
                    if(!this.editing) {
                        this.addSection(this.form.instruction, this.examId).then(() => {
                            this.$emit('success');
                            this.cancel();
                        })
                    }else {
                        this.updateSection(this.form['id'], this.form.instruction, this.examId).then(() => {
                            this.$emit('success');
                            this.cancel();
                        })
                    }
                }
            },
            cancel(){
                this.$v.form.$reset();
                this.$emit('cancel');
            },
            setEditMode(section){
                this.editing = true;
                this.form.instruction = section.instruction;
                this.form.examId = section.examId;
                this.form['id'] = section.id;
            },
            setCreateMode(){
                this.editing = false;
                this.form.instruction = '';
                this.form.examId = this.examId;
                delete this.form['id'];
            }
        },
        computed: {
            title() {
                return this.editing ? `Edit Section` : `Create Section`;
            },
            buttonText(){
                return this.editing ? 'Update' : 'Create';
            }
        }
    }
</script>