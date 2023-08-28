<template>
    <fragment>
      
      <div class="container-fluid" style="padding: 20px 20px;">
                <div class="row">
                    <div class="col-sm-8" >
                         <Adds :from_page="from_page" />
                         <div class="card mt-3" style="padding: 20px" v-for="d in datas" :key="d">
                          <div class="single-blog mb-3 wow fadeInUp animated">
                              <div align="center" class="mt-2">
                                <img
                                  :src="d.Imageipfs"
                                  style="width: 300px;height:200px;"
                                  class=""
                                />
                                <h4>{{ d.Country_Name }}</h4>
                              </div>
                            </div>
                             
                              <div class="row" v-if="d.Heading_1 != null">
                                 <div class="col-sm-12">
                                     <h2 align="center" class="text-dark">{{d.Heading_1}}</h2>
                                 </div>
                              </div>
                              <div class="row" v-if="d.Para_1 != null">
                                 <div class="col-sm-12">
                                     <p align="center" style="font-size:18px;" >{{d.Para_1}}</p>
                                 </div>
                              </div>
                              <div class=" mt-3" >
                                 <div class="" v-if="d.Heading_2 != null">
                                     <h3  class="text-dark">{{d.Heading_2}}</h3>
                                     <p  style="font-size:18px;" >{{ d.Para_2 }}</p>
                                 </div>
                                 <div class="" v-if="d.Heading_3 != null">
                                     <h3  class="text-dark">{{d.Heading_3}}</h3>
                                     <p  style="font-size:18px;" >{{ d.Para_3 }}</p>
                                 </div>
                              </div>
                              <div class="mt-3">
                                 <div class="" v-if="d.Heading_4 != null">
                                     <h3 class="text-dark">{{d.Heading_4}}</h3>
                                     <p  style="font-size:18px;" >{{ d.Para_4 }}</p>
                                 </div>
                                 <div class="" v-if="d.Heading_5 != null">
                                     <h3  class="text-dark">{{d.Heading_5}}</h3>
                                     <p  style="font-size:18px;" >{{ d.Para_5 }}</p>
                                 </div>
                              </div>
                              <div class="mt-3">
                                 <div class="" v-if="d.Heading_7 != null">
                                     <h3  class="text-dark">{{d.Heading_7}}</h3>
                                     <p    style="font-size:18px;" >{{ d.Para_7 }}</p>
                                 </div>
                                 
                              </div>
                              <div class="mt-3">
                                 <div class="">
                                     <h5  class="text-dark">{{d.Dates}}</h5>
                                 </div>
                              </div>
                              
                        </div>
                    </div>
                    <div class="col-sm-2">
                         <Form />
                 </div>
                     <div class="col-sm-2">
                    <SideAdds :slides="data" />
                </div>
                </div>
            </div>
        
  </fragment>
 </template>
 <script>
 //import config from '@/../config'
 //import SliderImg from '@/SliderImages.json'
 import Adds from '@/components/CorousalSlide'
 import SideAdds from '@/components/SideCorousalSlide'
 import Form from '@/components/MainForm'
 import config from '@/../config'
 
 export default {
     data () {
     return {
         datas:"",
         from_page:"Blogs",
         Id:this.$route.params.Id
     }
   }, 
     components: {
     Adds,
     SideAdds,
     Form,
     
     
     
     
     },
   async mounted () {
     this.from_page="Blogs"
     if(this.Id != "")
     {
        {
        console.log(this.Id,"ID here")
        {
          this.$route.params.Id;
        }
      }
      this.axios
        .get(config.hostname + "api/Blogs/GetbyId/" + this.Id)
        .then((response) => {
          if(response.data.length >0){
            this.datas = response.data;
            //console.log(response,"success")
          }
          else{
            console.log(response,"eeroor")
            this.$router.push({name: 'notFound'});
          }
         
          ////console.log(this.data)
        });
     }
     else {
      this.$router.push({ path: "/blog" });
    }
    
   }
 }
 </script>
 