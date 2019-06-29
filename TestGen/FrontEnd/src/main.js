import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import BootstrapVue from 'bootstrap-vue'
import Vuelidate from 'vuelidate'
import axios from 'axios'

Vue.config.productionTip = process.env.NODE_ENV === 'production';

Vue.use(BootstrapVue);
Vue.use(Vuelidate);

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app');



(function() {
  let token = require("./managers/account.manager.js").default.getUserToken();
  if (token) {
    console.log('hello');
    axios.defaults.headers.common['Authorization'] = token;
  } else {
    delete axios.defaults.headers.common['Authorization'];
  }
})();