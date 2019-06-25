<template>
  <div>
    <div class="background-view"></div>

    <div class="container">
      <div class="row align-items-center" style="height: 80vh;">
        <div class="col">
          <div class="text-center">
            <img src="../assets/logo.png" width="700" class="img-fluid"> 
          </div>
          <account-center-card>
            <login-form />
            <button class="btn btn-secondary btn-block">Register</button>
          </account-center-card>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import AccountCenterCard from "../components/account/AccountCenterCard";
import LoginForm from "../components/account/LoginForm";

export default {
  name: "home",
  components: {
    AccountCenterCard,
    LoginForm
  }
};
</script>
