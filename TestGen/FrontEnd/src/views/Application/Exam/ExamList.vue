<template>
    <div>
        <h1 class="display-4">Exams</h1>
        <h3 class="title">List of your exams</h3>
        <br>
        <list-actions @search="search" @create="create"/>
    </div>
</template>

<script>
import ListActions from '@/components/shared/ListActions';
export default {
    name: 'exam-list',
    components: {
        ListActions
    },
    methods: {
        search(query){

        },
        create(){
            
        }
    }
}
</script>