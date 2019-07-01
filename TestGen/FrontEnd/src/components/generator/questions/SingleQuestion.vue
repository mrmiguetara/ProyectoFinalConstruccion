<template>
    <div class="container-fluid">
        <div class="row">
            <div class="alert alert-dark w-100 mb-0">
                <div class="row">
                    <div class="col-9">
                        <strong>({{index}})</strong> {{question.title}}
                    </div>
                    <div class="col text-right">
                        <button class="btn btn-sm btn-secondary" style="margin-right: 10px" @click="edit">Edit</button>
                        <confirmation-button className="btn-sm" outline="true" @confirmed="remove">Remove</confirmation-button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    import bus from '../../../mixins/EventBus.js';
    import ConfirmationButton from '../../shared/ConfirmationButton.vue';
    const questionMixin = require('../../../mixins/questions.mixing.js').default;
    export default {
        name: 'single-question',
        mixins: [questionMixin],
        props: {
            question: {
                required: true
            },
            index: {
                required: true,
                type: Number
            },
            sectionId: {
                required: true
            }
        },
        data(){
            return {

            }
        },
        components: {
            ConfirmationButton
        },
        methods: {
            remove(){
                this.removeQuestion(this.question.id).then(() => {
                    let busEvent = 'question.response.' + this.sectionId;
                    bus.$emit(busEvent);
                })
            },
            edit(){
                bus.$emit('question.edit', this.question);
            }
        }
    }
</script>