<template>
   
        <div  class="container-fluid">
            <div class="row">
                <div v-for="s in topuni" :key="s" class="col-sm-2 mt-2" >
                    <div style="padding:10px 10px 10px 10px;border-radius:10px;height:100%;box-shadow:0 2px 5px 1px #403c4329;" class="center card">
                       <div class="text-center" @click="ToSinglePage(s.email)">
                            <img class=" center" style="height:auto;width:100%;box-shadow:0 2px 5px 1px #403c4329" :src="s.mainpicurlbase64" />
                            <br>
                            <label class="mt-1 center" style="color:black">{{s.institutename}}</label>
                        </div>
                    </div>
                </div>
            </div>
            <router-link to="/university">
        <button style="background-color: #1EA1F3;color:white;width:200px;border-radius: 10px" class="btn mt-4 center">See More</button>
   </router-link>
   </div>
</template>
<script>
//import config from '@/../../config'

  export default {
      props: ['topuni'],
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
        this.$router.push({name: '/universitypage', params: { emailid: email}});
      }
  }
}
</script>
