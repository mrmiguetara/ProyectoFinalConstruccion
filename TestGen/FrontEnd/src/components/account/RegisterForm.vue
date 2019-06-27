<template>
  <div>
    <div class="mb-3">
      <div class="form-group">
        <label>Email</label>
        <input type="email" class="form-control" placeholder="Email">
      </div>
      <div class="form-group">
        <label>Password</label>
        <input type="password" class="form-control" placeholder="Write your password">
      </div>
      <div class="form-group">
        <label>Confirm Passowrd</label>
        <input type="password" class="form-control" placeholder="Confirm Password">
      </div>
      <button class="btn btn-primary btn-block">Register</button>
    </div>
  </div>
</template>

<script>
export default {
  name: "register-form",
};
</script>
