<template>
    <div>
        <h1 class="display-4">Exams</h1>
        <h3 class="title">List of your exams</h3>
        <br>
        <list-actions @search="search" @create="create"/>
        <br>
        <user-exams-table @edit="edit" @remove="remove" class="exam-table" :exams="examViewList" />
        <exams-form-modal ref="examFormModal" @cancel="formVisible = false" :visible="formVisible" @success="getExams"></exams-form-modal>
    </div>
</template>

<script>
import ListActions from '../../../components/shared/ListActions.vue';
import UserExamsTable from '../../../components/exams/UserExamsTable.vue';
import ExamsFormModal from '../../../components/exams/ExamsFormModal.vue';

const exams = require('../../../mixins/exams.mixing').default   ;

export default {
    name: 'exam-list',
    mixins: [exams],
    data(){
      return {
          examList: [],
          examViewList: [],
          formVisible: false
      }
    },
    components: {
        ListActions,
        UserExamsTable,
        ExamsFormModal
    },
    methods: {
        search: function (query) {
            if (query === '') {
                this.examViewList = this.examList;
            } else {
                query = query.toLowerCase();
                this.examViewList = this.examList.filter(e => e.id == query || e.teacher.toLowerCase().indexOf(query) > -1 || e.subject.toLowerCase().indexOf(query) > -1)
            }
        },
        create(){
            this.formVisible = true;
            this.$refs.examFormModal.setCreateMode();
        },
        edit(index){
            const selectedExam = this.examViewList[index];
            this.$refs.examFormModal.setCreateMode();
            this.$refs.examFormModal.setEditMode(selectedExam);
            this.formVisible = true;
        },
        remove(index){
            const selectedExam = this.examViewList[index];
            const id = selectedExam.id;
            this.deleteExam(id).then(() => {
                this.getExams();
            })
        },
        getExams(){
            this.getUserExams().then(response => {
                this.examList = response.data;
                this.examViewList = this.examList;
            }).catch(err => {
                this.$bvToast.toast(`An error has ocurred`, {
                    title: 'Error',
                    autoHideDelay: 5000,
                    appendToast: true
                });
            });
        }
    },
    created() {
        this.getExams();
    }
}
</script>
