import Vue from 'vue'
import Router from 'vue-router'
import Home from './views/Home.vue'
import Login from './views/Account/Login'
import Register from './views/Account/Register'
import ExamList from './views/Application/Exam/ExamList'


Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/login',
      name: 'login',
      component: Login
    },
    {
      path: '/register',
      name: 'register',
      component: Register
    },
    {
      path: '/app',
      component: Home,
      children: [
        {
          path: '/exams',
          name: 'app.exams',
          component: ExamList
        }
      ]
    },
    {
      path: '*',
      redirect: '/login'
    }
  ]
})
