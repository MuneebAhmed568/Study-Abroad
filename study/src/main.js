import { createApp } from 'vue'
import App from './App.vue'
//import App2 from './AppAdmin.vue'
import router from './router'
import axios from 'axios'
// import loader from "vue-ui-preloader";

//import useVuelidate from '@vuelidate/core'
//import { required, email } from '@vuelidate/validators'

const app = createApp(App)
app.use(router)
    // app.use(loader)
app.config.globalProperties.axios = axios

//app.use(useVuelidate(required, email))
app.mount('#app')


//const app2 = createApp(App2)
//app2.use(router)
//app2.use(VueRouter)
//app2.mount('#app2')