<template>
    <div class="col-sm-2 mt-2" v-for="s in countryImg" :key="s">
        <div style="card;padding:10px 10px 10px 10px;border-radius:10px ;height:100%;box-shadow:0 2px 5px 1px #403c4329;">
           <div @click="ToSinglePage(s.id)" class="text-center">
            <img :src="s.CountryLogo_Ipfs" style="width:100%;height:auto;box-shadow:0 2px 5px 1px #403c4329">
            <br><label class="mt-2" style="color:black"><br> {{s.Country_Name}}</label>
            </div >
        </div>
        
    </div>
   
    
    
</template>
<script>
//import config from '@/../../config'

  export default
    {
      props: ['countryImg'],
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
      
      ToSinglePage (cname) {
        // this.$router.push({path: '/ConsultantPage', params: { username: email }}); ,pathMatch: this.$route.path.substring(1).split('/')
        // this.$router.push({name:'ConsultantPage', params: { param: email } })
        console.log("cname");
        console.log(cname);
        this.$router.push({name: 'guidePage', params: { idguide: cname}});
      }
  }
    }
</script>
