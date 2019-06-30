<template>
    <div>
        <list-actions :show-search="false" btn-text="New Section" @create="create"/>
    </div>
</template>

<script>
    import ListActions from '../../shared/ListActions.vue';
    export default {
        name: 'section-cards-view',
        data(){
            return {

            };
        },
        components: {
            ListActions
        },
        methods: {
            create(){

            }
        }
    }
</script>