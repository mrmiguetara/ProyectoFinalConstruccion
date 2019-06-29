<template>
  <div id="app">
    <transition name="fade" mode="out-in">
      <router-view/>
    </transition>
  </div>
</template>


<script>
  import axios from 'axios';
  const accountManager = require('./managers/account.manager.js').default;
  export default {
    name: 'App',
    created() {
      axios.interceptors.response.use((response) => response, error => {
        if (401 === error.response.status) {
          this.$bvToast.toast(`Your session has expires`, {
            title: 'Expired Session',
            autoHideDelay: 5000,
            appendToast: true
          });
          accountManager.signOutUser();
          this.$router.push({name: 'login'});
        } else if (!error.status){
          this.$bvToast.toast(`An error occurred trying to establish server connection`, {
            title: 'Server connection error',
            autoHideDelay: 5000,
            appendToast: true
          });
        }
      })
    }
  }
</script>

<style lang="scss">
@import "./theme/style.scss";

.fade-enter-active,
.fade-leave-active {
  transition: opacity 0.3s;
}
.fade-enter, .fade-leave-to /* .fade-leave-active below version 2.1.8 */ {
  opacity: 0;
}


</style>
