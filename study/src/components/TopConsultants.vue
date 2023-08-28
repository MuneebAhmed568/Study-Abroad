<template>
 <div class="container-fluid">
		<div class="row">
    
    <div class="col-sm-2 a mt-2" v-for="s in ConsultantsData.slice(0,7)" :key="s">
  
                    <div class="card" style="padding:10px 10px 10px 10px;border-radius:10px;height:100%;box-shadow:0 2px 5px 1px #403c4329;">
                         
                        <div @click="ToSinglePage(s.Email)" class="text-center">
                       
                        <img :src="s.companylogobase64"  class=""  style="border-radius:100%;height:auto;width:100%;box-shadow:0 2px 5px 1px #403c4329">
                        <br>
                        <label  class="mt-2" style="color:black; font-size: 15px">{{s.CompanyName}}</label>
                         </div>   
                       
                        
                    </div>
            
    </div>
    
    </div>
    <router-link to="/Consultant">
     <button class="btn mt-4 center" style="background-color: #1EA1F3;color:white;height:auto;width:200px;border-radius: 10px">See More Details</button>
     </router-link>
    </div>
       
    
</template>
<script>
import config from '@/../config'

  export default {
      // props: ['ConsultantsData'],
      data(){
          return{
            image:undefined,
            ConsultantsData: [{"CompanyName":"Company Name","Conatctno":"","Email":"","Address":"","City":"","websitelink":"","companylogo":"","consultancyservices":"","services":"","Detail":"","Password":"","statuscheck":"","Phoneno":"","Personname":"","companylogobase64":'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY',"mapaddress":"","id":""}],


          }
      },
    async  mounted () {
      //console.log("testing7")
      await this.axios.get(config.hostname+'api/Consultantinfo/Getall/')
        .then((response) => {
			//console.log("testing8",response)
			
           this.ConsultantsData = response.data
		   //console.log(this.ConsultantsData) 
        }) 
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