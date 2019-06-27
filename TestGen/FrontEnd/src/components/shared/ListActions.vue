<template>
  <div>
    <div class="container-fluid">
      <div class="row">
        <div class="col-5">
          <div class="form-group">
            <label for="search">Search: &nbsp;</label>
            <input type="text" name="search" id="search" class="form-control" v-model="search" placeholder="Search" @change="$emit('search', search)">
          </div>
        </div>
        <div class="col-4">
          <button class="btn btn-secondary" style="margin-top: 35px"  @click="$emit('create')">Create</button>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
/**
 * Emittions
 * -create
 * -search
 */
export default {
  name: "list-actions",
  data(){
    return {
      search: ''
    };
  },
  methods: {

  }
};
</script>