<template>
  <div>
    <account-view>
      <account-center-card>
        <login-form></login-form>
        <button class="btn btn-secondary btn-block">Register</button>
      </account-center-card>
    </account-view>
  </div>
</template>

<script>
import AccountView from '@/components/utilities/AccountView'
import AccountCenterCard from "@/components/account/AccountCenterCard";
import LoginForm from "@/components/account/LoginForm";

export default {
  name: "login",
  components: {
    AccountCenterCard,
    AccountView,
    LoginForm
  }
}
</script>

<style>

</style>
