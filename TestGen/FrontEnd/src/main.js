import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import BootstrapVue from 'bootstrap-vue'
import Vuelidate from 'vuelidate'
import axios from 'axios'
import { library } from '@fortawesome/fontawesome-svg-core'
import { faCogs, faFileExport, faPlus, faMinus, faTrash, faEdit } from '@fortawesome/free-solid-svg-icons'
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'
Vue.config.productionTip = process.env.NODE_ENV === 'production';

library.add(faCogs, faFileExport, faPlus, faMinus, faTrash, faEdit);
Vue.component('font-awesome-icon', FontAwesomeIcon);

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
    axios.defaults.headers.common['Authorization'] = `Bearer ${token}`;
  } else {
    delete axios.defaults.headers.common['Authorization'];
  }
})();