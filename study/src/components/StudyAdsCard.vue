<template>
<div class="container-fluid mt-3" style="background-color:white">
	<div style="text-align: center" class="pt-2 pb-2">
		<h2 class="mt-5"><b>Study Ads</b></h2>
		<p style="font-size: 20px">See the top trending Study Ads on our website</p>	
	</div>
	<section class="pb-5 mt-3">
	    <div class="container-fluid">
            <div class="row">
                <div class="col-sm-4 mt-3" v-for="s in adsdata" :key="s">
                <div @click="ToSinglePage(s.Id,s.Email)">
                        <div class="card" style="border-radius:10px;height:auto;box-shadow:0 2px 5px 1px #403c4329;">
                            <div  style="padding:10px 10px">
                                <img :src="s.imageurlbase64" style="width:100%;height:auto" />
                                <div style="color:black" class="col-sm-12 mt-1 text-center">
                                    <h6>{{s.Title}}</h6>
                                     <label style="font-size:12px;margin:-8px 0px">{{s.Detail}}</label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                
            </div>
	    </div>
	</section>
</div>
</template>

<script>
//import config from '@/../../config'

export default {
    props: ['adsdata'],
      data(){
          return{
            image:undefined,
            emailid: ""
            

          }
      },
      
      methods:{
          
          getImage (pic) {     
                this.image =   pic
                    return this.image           
                },
                ToSinglePage (id,email) {
        // this.$router.push({path: '/ConsultantPage', params: { username: email }});
        // this.$router.push({name:'ConsultantPage', params: { param: email } })
        this.$router.push({name: '/studyadspage', params: { emailid:id, mainemail:email}});
      }
  }
}
</script>

<style>

</style>