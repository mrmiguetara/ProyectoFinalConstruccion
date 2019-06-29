<template>
  <div>
    <div class="row bg-light navbase align-items-center">
      <div class="col"></div>
      <div class="col">
        <img class="nav-img" src="../../assets/logo.png">
      </div>
      <div class="col">
        <div class="row">
            <div class="col-5"></div>
          <div class="col">
            <span class="user-email">{{username}}</span>
          </div>
          <div class="col">
            <button class="btn btn-dark btn-nav" @click="signOut">Sign Out</button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>

  const accountManager = require('../../managers/account.manager.js').default;
export default {
  name: "user-navbar",
  data(){
    return {
      username: ''
    };
  },
  methods: {
      signOut(){
          accountManager.signOutUser();
          this.$router.push({name: 'login'})
      }
  },
  created() {
    accountManager.getUserDataFromLocalStorage();
    this.username = accountManager.getUserData()['userName'];
  }
};
</script>

<style lang="scss">
.navbase {
  height: 70px;

  img.nav-img {
    width: 250px;
    position: relative;
    left: 16%;
    top: -5px;
  }

  .user-email {
  }

  .btn-nav {
    border-radius: 30px;
    height: 32px;
    padding-top: 2px;
    position: relative;
    top: -5px;
  }
}
</style>

