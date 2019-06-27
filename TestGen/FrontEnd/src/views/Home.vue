<template>
  <div>
    <user-navbar />
    <div class="exameter-background"></div>
      <div class="exameter exameter-container">
        <div class="container-fluid">
          <router-view></router-view>
        </div>
      </div>
  </div>
</template>

<script>
import UserNavbar from '../components/layout/UserNavbar'

export default {
  name: "home",
  components: {
    UserNavbar
  }
};
</script>


<style lang="scss">
  .exameter-background {
    background: #D8EBFC;
    position: fixed;
    top: 0;
    left: 0;
    height: 100vh;
    width: 100%;
    z-index: -10;
  }

  .exameter {
    &.exameter-container {
      background: white;
      min-height: 88vh;
      margin: 25px;
      box-shadow: 1px 2px 4px 3px rgba(0,0,0,0.3);

      .container-fluid {
        padding-top: 10px;
      }
    }
  }
</style>
