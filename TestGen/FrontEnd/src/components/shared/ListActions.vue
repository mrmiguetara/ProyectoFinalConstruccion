<template>
  <div class="list-actions">
    <div class="container-fluid">
      <div class="row">
        <div class="col-4" v-if="showSearch">
            <input type="text" name="search" id="search" class="form-control" v-model="search" placeholder="Search" @input="$emit('search', search)">
        </div>
        <div class="col-2">
          <button class="btn btn-secondary btn-block" @click="$emit('create')">{{btnText}}</button>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  name: "list-actions",
  props: {
    showSearch: {
      type: Boolean,
      default: true
    },
    btnText: {
      type: String,
      default: 'Create'
    }
  },
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