<template>
  <div class="container-fluid">
    <div class="row">

        <div class="col-sm-4 mt-3" v-for="s in topnew" :key="s">
             
            <div @click="ToSinglePage(s.id)">
                <div class="card text-center" style="border-radius:10px;height:auto;box-shadow:0 2px 5px 1px #403c4329;">
                    <div  style="padding:10px 10px">
                            <img :src="s.imageurlbase64" height="auto" width="100%">
                        <div style="color:black" class="col-sm-12 mt-1">
                            <h6>{{s.title}}</h6>
                           
                            <div class="row">
                                <div align="center" class="col-sm-12">
                                    <p style="color:#1EA1F3;font-size:13px"><i class="fa fa-globe"></i>{{s.countries}}</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
</template>

<script>
// import config from '@/../config'

export default {
    props: ['topnew'],
      data(){
          return{
            image1:undefined
            

          }
      },
      
      methods:{
          
        getImage1 (pic) {     
                this.image1 =   pic
                    return this.image1           
                },
      
     ToSinglePage (id) {
        this.$router.push({name: '/newsPage', params: { emailid: id}});
      }
  }
}
</script>
