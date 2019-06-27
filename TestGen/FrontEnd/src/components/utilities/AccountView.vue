<template>
  <div>
    <div class="background-view"></div>

    <div class="container">
      <div class="row align-items-center" style="height: 80vh;">
        <div class="col">
          <div class="text-center">
            <img src="../../assets/logo.png" width="700" class="img-fluid">
          </div>
          <slot></slot>
        </div>
      </div>
    </div>
  </div>
</template>

<script>

export default {
    name: 'account-view'
};
</script>

<style>
</style>
