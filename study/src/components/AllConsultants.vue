<template>
 <div class="container-fluid">
		<div class="row">
    
    <div class="col-sm-2" v-for="s in ConsultantsData" :key="s">
  
                    <div class="card" style="padding:10px 10px 10px 10px;border-radius:10px;height:100%;box-shadow:0 2px 5px 1px #403c4329;">
                         
                        <div @click="ToSinglePage(s.Email)" class="text-center">
                       
                        <img :src="s.companylogobase64"  class="mb-3"  style="border-radius:100%;height:auto;width:100%;box-shadow:0 2px 5px 1px #403c4329">
                        <br>
                        <label  class="mt-4" style="color:black">{{s.CompanyName}}</label>
                         </div>   
                       
                        
                    </div>
            
    </div>
    
    </div>
    <router-link to="/Consultant">
     <button class="btn mt-4 center" style="background-color: #1EA1F3;color:white;height:auto;padding:10px 80px;border-radius: 10px">See More Details</button>
     </router-link>
    </div>
       
    
</template>
<script>
//import config from '@/../../config'

  export default {
      props: ['ConsultantsData'],
      data(){
          return{
            image:undefined

          }
      },
     mounted () {
      
     },
      
      methods:{
          
          getImage (pic) {     
                this.image =   pic
                    return this.image           
                },
      
      ToSinglePage (email) {
        // this.$router.push({path: '/ConsultantPage', params: { username: email }});
        // this.$router.push({name:'ConsultantPage', params: { param: email } })
        this.$router.push({name: 'ConsultantPage', params: { idconsult: email}});
      }
  }
}
</script>