<template>
    <div>
        <div class="row" style="margin-left: 1px">
            <div class="col">
                <h1 class="display-4">Exam | <span class="text-muted">subject</span></h1>
                <h3 class="title">Exam generator options view</h3>
            </div>
            <div class="col">
                <button class="float-right btn btn-primary export-btn">
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
    export default {
        name: 'generator',
        data(){
            return {
                examId: 0
            };
        },
        components: {
            SectionCardsView
        },
        methods: {

        },
        mounted(){
            this.examId = this.$route.params.id;
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
