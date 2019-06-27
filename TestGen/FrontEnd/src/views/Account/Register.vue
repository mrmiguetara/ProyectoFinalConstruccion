<template>
  <div>
    <account-view>
      <account-center-card>
        <register-form />
        <button @click="goToLogin" class="btn btn-secondary btn-block">Sign In</button>
      </account-center-card>
    </account-view>
  </div>
</template>

<script>
import AccountView from '@/components/utilities/AccountView'
import AccountCenterCard from "@/components/account/AccountCenterCard";
import RegisterForm from "@/components/account/RegisterForm";

export default {
  name: "register",
  components: {
    AccountCenterCard,
    AccountView,
    RegisterForm
  },
  methods: {
      goToLogin(){
          this.$router.push({name: 'login'})
      }
  }
}
</script>

<style>
</style>
