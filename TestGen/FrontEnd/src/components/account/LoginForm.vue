<template>
  <div class="mb-3">
    <div class="form-group">
      <label>Email</label>
      <input type="email" class="form-control" placeholder="Email">
    </div>
    <div class="form-group">
      <label>Password</label>
      <input type="password" class="form-control" placeholder="Write your password">
    </div>
    <div class="text-center mb-3">
        <a href="#">Forgot your password?</a>
    </div>
    <button class="btn btn-primary btn-block">Login</button>
  </div>
</template>


<script>
export default {
  name: "login-form"
};
</script>
