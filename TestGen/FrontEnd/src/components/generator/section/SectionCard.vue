<template>
    <div>
        <div class="card exameter-card" style="margin-bottom: 15px;">
            <div class="card-header">
                <div class="row">
                    <div class="col-9">
                        <h5 class="card-title">
                            <button class="btn btn-light" @click="open = !open">
                                <font-awesome-icon :icon="btnIcon"/>
                            </button>
                            &nbsp;
                            Section {{sectionIndex + 1}} -- {{section.instruction}}

                        </h5>
                    </div>
                    <div class="col-3">
                        <button class="text-light badge-btn float-right" v-click-outside="stopConfirmDelete" @click="remove" :class="removeBtnClass">
                            <font-awesome-icon icon="trash" /> &nbsp;
                            <span v-if="deleteConfirm">Confirm</span>
                            Remove
                        </button>
                        <button class="btn btn-light float-right text-secondary edit"
                                @click="$emit('edit')"
                                style="margin-right: 10px;">
                            <font-awesome-icon icon="edit"/>
                        </button>

                    </div>
                </div>

            </div>
            <div class="card-body" v-show="open">
                <section-questions :section-id="section.id"/>
            </div>
        </div>
    </div>
</template>


<script>
    import SectionQuestions from '../questions/SectionQuestions.vue';
    import ClickOutside from 'vue-click-outside';
    const sectionMixin = require('../../../mixins/sections.mixing.js').default;
    const questionsMixin = require('../../../mixins/questions.mixing.js').default;
    export default {
        name: 'section-card',
        props: {
          section: {
              required: true,
              type: Object
          },
          sectionIndex: {
              required: true,
              type: Number,
              default: 1
          }
        },
        mixins: [sectionMixin, questionsMixin],
        data(){
            return {
                open: false,
                deleteConfirm: false,
            };
        },
        components: {
          SectionQuestions
        },
        computed: {
            btnIcon() {
                if(this.open) {
                    return 'minus';
                } else {
                    return 'plus';
                }
            },
            removeBtnClass(){
                if(!this.deleteConfirm){
                    return 'bg-info';
                }else {
                    return 'bg-danger';
                }
            }
        },
        methods: {
            remove(){
                if(this.deleteConfirm){
                    this.removeSection(this.section.id).then(() => {
                        this.$emit('remove');
                    }).catch(err => {
                        this.$bvToast.toast(`${JSON.stringify(error.response)}`, {
                            title: 'Application Error',
                            autoHideDelay: 5000,
                            appendToast: true
                        });
                    });
                }else {
                    this.deleteConfirm = true;
                }
            },
            stopConfirmDelete(){
                this.deleteConfirm = false;
            }
        },
        directives: {
            ClickOutside
        }
    }
</script>

<style lang="scss">
    .exameter-card {
        .card-header {
            height: 70px;
            padding-top: 15px;
            .btn {
                box-shadow: none;
            }
        }
        box-shadow: 2px 3px 4px  rgba(0,0,0,0.3);

        .card-body {
            padding: 20px;
        }
    }
</style>