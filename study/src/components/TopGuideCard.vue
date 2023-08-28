<template>
						<h2 class="text-center"><b>Study Destinations</b></h2>
						<p style="font-size: 16px" class="text-center">While some individuals may have a clear idea of the country, continent, or even specific university they wish to study in, there are also instances where students are open to exploring various options based on their study plans and budget. By actively scrolling through available choices, students can expand their possibilities and discover destinations that align with their desired study abroad experience. This process allows for a broader exploration of potential opportunities, facilitating the discovery of the ideal destination for studying abroad.</p>
						<div class="container-fluid">
						<div class="row">
						
            <div class="col-sm-2 a mt-2" v-for="s in countryImg.slice(0,6)" :key="s">
                <div class="card" style="padding:10px 10px 10px 10px;border-radius:10px ;height:100%;box-shadow:0 2px 5px 1px #403c4329;">
                  <div @click="ToSinglePage(s.id)" class="text-center">
                    <img :src="s.CountryLogo_Ipfs" style="width:100%;height:auto" class=""  >
                    <br><label class="mt-2" style="color:black"><br> {{s.Country_Name}}</label>
                    </div >
                </div>
                
            </div>
						</div>
						</div>
					<router-link to="/guide">
						<button class="btn mt-4 center" style="background-color: #1EA1F3;color:white;width:200px;border-radius: 10px">See More Details</button>
					</router-link>
   
    
    
</template>
<script>
import config from '@/../config'

  export default
    {
      // props: ['countryImg'],
      data(){
          return{
            image:undefined,
            countryImg: [{"id":"","countryname":"Country Name","countrylogobase64":'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY'}],

            

          }
      },
      async mounted(){
        await this.axios.get(config.hostname+'api/countryinfo/Getall/')
        .then((response) => {
			//console.log("testing11",response)
           this.countryImg = response.data  
		  ////console.log("country data is : ") 
		   //console.log(this.countryImg) 
        }) 
      },
      methods:{
          
          getImage (pic) {     
                this.image =   pic
                    return this.image           
                },
      
      ToSinglePage (cname) {
        // this.$router.push({path: '/ConsultantPage', params: { username: email }});
        // this.$router.push({name:'ConsultantPage', params: { param: email } })
        this.$router.push({name: 'guidePage', params: { idguide: cname}});
      }
  }
    }
</script>
