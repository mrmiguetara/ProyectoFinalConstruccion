<template>
    <div>
        <div class="background-view"></div>
        <div class="container">
            <div class="row align-items-center" style="height: 80vh;">
                <div class="col">
                    <div class="text-center">
                        <img src="../../assets/logo.png" width="700">
                    </div>
                    <account-center-card>
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
                            <button class="btn btn-primary btn-block">Register</button>
                        </div> 
                        
                    </account-center-card>
                </div>
            </div>
        </div>
        
        
    </div>
</template> 

<script>
import LoginForm from "./LoginForm";
import AccountCenterCard from "./AccountCenterCard.vue";
export default {
    name: 'register-form'
};
</script>
