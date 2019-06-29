<template>
    <table class="table table-striped table-bordered table-hover">
        <thead class="thead-light">
            <tr>
                <th>Id</th>
                <th>Last Updated</th>
                <th>Teacher</th>
                <th>Subject</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="(exam, i) in exams" :key="i">
                <td>{{exam.id}}</td>
                <td>{{exam.updated}}</td>
                <td>{{exam.teacher}}</td>
                <td>{{exam.subject}}</td>
                <td width="24%">
                    <div class="row">
                        <div class="col">
                            <confirmation-button :outline="true" className="table-btn" @confirmed="remove(i)">Delete</confirmation-button>
                        </div>
                        <div class="col">
                            <button class="table-btn btn btn-secondary" @click="edit(i)">Edit</button>
                        </div>
                    </div>
                </td>
            </tr>
            <tr v-if="exams.length === 0">
                <td colspan="5" class="text-center">No data found</td>
            </tr>
        </tbody>
    </table>
</template>

<script>
    import ConfirmationButton from '../shared/ConfirmationButton.vue';
    export default {
        name: "user-exams-table",
        props: ['exams'],
        components: {
          ConfirmationButton
        },
        methods: {
            edit(index){
                this.$emit('edit', index);
            },
            remove(index){
                this.$emit('remove', index);
            }
        }
    }
</script>

<style>
    .table-btn {
        width: 100%;
    }
</style>