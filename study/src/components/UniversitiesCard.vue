<template>
  <div class="container-fluid">
    <div class="row">

        <div class="col-sm-4 mt-3" v-for="s in topuni" :key="s">
            <a href="#">
                <div class="card" style="border-radius:10px;height:auto;box-shadow:0 2px 5px 1px #403c4329;">
                    <div  style="padding:10px 10px">
                            <img :src="s.mainpicurlbase64" height="200px" width="250px">
                        <div style="color:black" class="col-sm-12 mt-1">
                            <h6>{{s.institutename}}</h6>
                            <label style="font-size:12px;margin:-8px 0px">{{s.Detail}}</label>
                            <div class="row">
                                <div align="center" class="col-sm-12">
                                    <p style="color:#1EA1F3;font-size:13px"><i class="fa fa-globe"></i>{{s.country}}</p>
                                </div>
                                <div align="left" class="col-sm-12">
                                <img :src="s.instituteimagebase64" class="ml-2 mt-1" height="30px" width="40px">
                                
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </a>
        </div>
    </div>
</div>
</template>

<script>
import config from '@/../../config'

export default {
    props: ['topuni'],
      data(){
          return{
            image1:undefined,
            image2:undefined
            

          }
      },
      
      methods:{
          
        getImage1 (pic) {     
                this.image1 =   pic
                    return this.image1           
                },
        getImage2 (pic) {     
                this.image2 =   pic
                    return this.image2           
                }        
  }
}
</script>
