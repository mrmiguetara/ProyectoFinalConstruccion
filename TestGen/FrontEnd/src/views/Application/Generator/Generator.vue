<template>
    <div>
        <div class="row" style="margin-left: 1px">
            <div class="col">
                <h1 class="display-4">Exam | <span class="text-muted">{{exam.subject}}</span></h1>
                <h3 class="title">Exam generator options view</h3>
            </div>
            <div class="col">
                <button class="float-right btn btn-primary export-btn" @click="exportExam">
                    Export Exam
                    <font-awesome-icon class="icon" icon="file-export"></font-awesome-icon>
                </button>
            </div>
        </div>
        <section-cards-view />
    </div>
</template>

<script>
    import SectionCardsView from '../../../components/generator/section/SectionCardsView';
    import axios from 'axios';
    const baseUrl = require('../../../globalVariables.js').baseUrl;
    const examMixing = require('../../../mixins/exams.mixing.js').default;
    export default {
        name: 'generator',
        mixins: [examMixing],
        data(){
            return {
                examId: 0,
                exam: {},
            };
        },
        components: {
            SectionCardsView
        },
        methods: {
            loadExamData() {
                this.getExam(this.examId).then(exam => {
                    this.exam = exam.data;
                });
            },
            exportExam(){
                let endpoint = `${baseUrl}/documents/${this.examId}`;
                axios.get(endpoint).then(response => {
                    const data = response.data;
                    const fileName = data.fileName;
                    this.downloadFile(data.base64, data.applicationFormat, fileName);
                })
            },
            downloadFile(base64, fileType, fileName){
                const linkSource = `data:${fileType};base64,${base64}`;
                const downloadLink = document.createElement("a");

                downloadLink.href = linkSource;
                downloadLink.download = fileName;
                downloadLink.click();
            }
        },
        created(){
            this.examId = this.$route.params.id;
            this.loadExamData();
        }
    }

</script>

<style lang="scss">
    @import '../../../theme/variables';
    .export-btn {
        margin-right: 10px;
        margin-top: 10px;
        width: 10em;
        font-size: 1.5em;
        .icon {
            display: none;
        }
        &:hover {
            background: $cyan;
            color: $white;
            transition: all 0.2s;
            .icon {
                display: inline;
            }
        }
    }
</style>
