<template>
  
  <div class="container-fluid">
    <div class="row">

        <div class="col-sm-4 mt-3" v-for="s in ConsultantsData" :key="s">
             <router-link to="/ConsultantPage" class="a">
                <div class="card" style="border-radius:10px;height:auto;box-shadow:0 2px 5px 1px #403c4329;">
                    <div  style="padding:10px 10px">
                            <img :src="s.companylogobase64" class="h-25 w-25">
                        <div style="color:black" class="col-sm-12 mt-1">
                            <h6>{{s.CompanyName}}</h6>
                            <label style="font-size:12px;margin:-8px 0px">{{s.Detail}}</label>
                            <div class="row">
                                <div align="center" class="col-sm-12">
                                    <p style="color:#1EA1F3;font-size:13px"><i class="fa fa-globe"></i> Country</p>
                                </div>
                                
                            </div>
                        </div>
                    </div>
                </div>
            </router-link>
        </div>
    </div>
</div>
</template>

<script>
import config from '@/../../config'

export default {
    props: ['ConsultantsData'],
    data(){
          return{
            image:undefined
            

          }
      },
      
      methods:{
          
          getImage (pic) {     
                this.image =   pic
                    return this.image           
                }
  }
}
</script>
