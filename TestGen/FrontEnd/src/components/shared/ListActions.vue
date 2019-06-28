<template>
  <div class="list-actions">
    <div class="container-fluid">
      <div class="row">
        <div class="col-4">
            <input type="text" name="search" id="search" class="form-control" v-model="search" placeholder="Search" @change="$emit('search', search)">
        </div>
        <div class="col-2">
          <button class="btn btn-secondary btn-block" @click="$emit('create')">Create</button>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  name: "list-actions",
  data(){
    return {
      search: ''
    };
  }
};
</script>

<style lang="scss">
  .list-actions {
    .form-control {
      height: 50px;
    }
  }
</style>