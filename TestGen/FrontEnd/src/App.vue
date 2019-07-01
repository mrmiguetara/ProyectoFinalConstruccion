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
        if (error.response.status !== undefined) {
          if (401 === error.response.status) {
            this.$bvToast.toast(`Your session has expired`, {
              title: 'Expired Session',
              autoHideDelay: 5000,
              appendToast: true
            });
            //accountManager.signOutUser();
            //this.$router.push({name: 'login'});
          } else if (405 === error.response.status) {
            this.$bvToast.toast(`${JSON.stringify(error.response)}`, {
              title: 'Bad request from server',
              autoHideDelay: 5000,
              appendToast: true
            });
          } else if (!error.status) {
            const message = error.response.data.length > 0 ? error.response.data : 'Error trying to reach server';

            this.$bvToast.toast(`${message}`, {
              title: 'Server error',
              autoHideDelay: 5000,
              appendToast: true
            });
          }
        }
      })
    }
  }
</script>

<style lang="scss">
@import "./theme/style.scss";




</style>
