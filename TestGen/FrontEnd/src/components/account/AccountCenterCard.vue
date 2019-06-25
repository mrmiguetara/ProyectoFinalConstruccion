<template>
<div class="container">
    <div class="row justify-content-center">
      <div class="col-xs-12 col-sm-10 col-md-7">
        <div class="card account-card">
          <div class="card-body">
            <slot></slot>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
    name: 'account-center-card'
}
</script>


<style lang="scss">
  .card {
    &.account-card {
      border-radius: 20px !important;
      background-color: rgba(255,255,255, 0.75);
    }
  }
</style>
