<template>
    <div>
        <list-actions :show-search="false" btn-text="New Section" @create="create"/>
        <br>
        <section-card
                v-for="(section, i) in sections"
                :key="i"
                :section-index="i"
                :section="section"
                @remove="get"
                @edit="edit(i)" />
        <section-form-modal
                ref="sectionFormModal"
                :visible="formVisible"
                :exam-id="examId"
                @cancel="hideSectionFormModal"
                @success="get"/>
        <question-form-modal />
    </div>
</template>

<script>
    import ListActions from '../../shared/ListActions.vue';
    import SectionCard from '../section/SectionCard.vue';
    import SectionFormModal from './SectionFormModal.vue';
    import QuestionFormModal from '../questions/QuestionFormModal.vue';
    const sectionMixing = require('../../../mixins/sections.mixing.js').default;
    let examId = 0;
    export default {
        name: 'section-cards-view',
        mixins: [sectionMixing],
        data(){
            return {
                examId: this.$route.params.id,
                sections: [],
                formVisible: false
            };
        },
        components: {
            ListActions,
            SectionCard,
            SectionFormModal,
            QuestionFormModal
        },
        methods: {
            create(){
                this.formVisible = true;
                this.$refs.sectionFormModal.setCreateMode();
            },
            edit(i){
                console.log('edit');
                this.formVisible = true;
                this.$refs.sectionFormModal.setEditMode(this.sections[i]);
            },
            get(){
                this.getSections(examId).then(response => {
                    this.sections = response.data;
                }).catch(err => {
                    console.log(err);
                })
            },
            hideSectionFormModal(){
                this.formVisible = false;
                this.get();
            }
        },
        created() {
            examId = this.examId;
            this.get();
        }
    }
</script>