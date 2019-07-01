<template>
  <div class="mb-3">
    <form @submit.prevent="submit">
      <div class="form-group" :class="{'is-invalid': $v.form.userEmail.$error}">
        <label>Email</label>
        <input type="email"  v-model.trim.lazy="$v.form.userEmail.$model" class="form-control" placeholder="Email" required>
        <div v-if="$v.form.userEmail.$error">
          <span class="form-text text-danger" v-if="!$v.form.userEmail.required">Email is required</span>
          <span class="form-text text-danger" v-if="!$v.form.userEmail.email">You must enter a valid email</span>
        </div>
      </div>
      <div class="form-group" :class="{'is-invalid': $v.form.password.$error}">
        <label>Password</label>
        <input type="password" class="form-control" v-model.trim.lazy="$v.form.password.$model" placeholder="Write your password" required>
        <div v-if="$v.form.password.$error">
          <span class="form-text text-danger">You must enter a password</span>
        </div>
      </div>
      <div class="text-center mb-3">
          <a href="#">Forgot your password?</a>
      </div>
      <button class="btn btn-primary btn-block" type="submit">Login</button>
    </form>
  </div>
</template>


<script>
  import { required, email } from 'vuelidate/lib/validators'

  const accountManager = require('../../managers/account.manager').default;

  export default {
    name: "login-form",
    data() {
      return {
        form: {
          userEmail: '',
          password: ''
        }
      }
    },
    validations: {
      form: {
        userEmail: {
          required,
          email
        },
        password: {
          required
        }
      }
    },
    methods: {
      goToHome(){
        this.$router.push({name: 'app.exams'})
      },
      submit(){
        this.$v.form.$touch();
        if(!this.$v.form.$invalid) {

          accountManager.logUserIn(this.form.userEmail, this.form.password)
                  .then((user) => {
                    console.log(user, "INFORMATION");
                    this.goToHome();
                  }).catch(err => {
                    console.log(err, "ERROR");
                  }).finally(() => {
                    this.$v.form.$reset;
                  });

        }
      }
    },
    created(){
      if (accountManager.checkIfLoggedIn()) {
        this.goToHome();
      }
    }
  };
</script>


<style lang="scss">
  @import '../../theme/variables';


</style>