<template>
   <fragment>
     
     <div class="container-fluid" style="padding: 20px 20px;">
               <div class="row">
                   <div class="col-sm-8" >
                        <Adds :from_page="from_page" />
                        <!-- <div class="card mt-3" style="padding: 20px" v-for="d in datas" :key="d">
                         
                            
                             <div class="row">
                                <div class="col-sm-12">
                                    <h1 align="center" class="text-dark">{{d.Heading_1}}</h1>
                                </div>
                             </div>
                             <div class="row">
                                <div class="col-sm-12">
                                    <p align="center" style="font-size:25px;" >{{d.Para_1}}</p>
                                </div>
                             </div>
                             <div class="row">
                                <div class="col-sm-6">
                                    <h3 align="center" class="text-dark">{{d.Heading_2}}</h3>
                                    <p  style="font-size:15px;" >{{ d.Para_2 }}</p>
                                </div>
                                <div class="col-sm-6">
                                    <h3 align="center" class="text-dark">{{d.Heading_3}}</h3>
                                    <p  style="font-size:15px;" >{{ d.Para_3 }}</p>
                                </div>
                             </div>
                             <div class="row">
                                <div class="col-sm-6">
                                    <h3 align="center" class="text-dark">{{d.Heading_4}}</h3>
                                    <p  style="font-size:15px;" >{{ d.Para_4 }}</p>
                                </div>
                                <div class="col-sm-6">
                                    <h3 align="center" class="text-dark">{{d.Heading_5}}</h3>
                                    <p  style="font-size:15px;" >{{ d.Para_5 }}</p>
                                </div>
                             </div>
                             <div class="row">
                                <div class="col-sm-12">
                                    <h3 align="center" class="text-dark">{{d.Heading_7}}</h3>
                                    <p   align="center" style="font-size:15px;" >{{ d.Para_7 }}</p>
                                </div>
                                
                             </div>
                             <div class="row">
                                <div class="col-sm-12">
                                    <h5 align="center" class="text-dark">{{d.Dates}}</h5>
                                </div>
                             </div>
                             
                       </div> -->
                       <Topblog :datas="datas" />
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
import Topblog from '@/components/TopBlogPost'

export default {
  props:['data'],
    data () {
	return {
        datas:"",
        from_page:"Blogs"
	}
  }, 
	components: {
	Adds,
	SideAdds,
	Form,
    Topblog
    
	
	
	
	},
  async mounted () {
    this.from_page="Blogs"
    await this.axios
        .get(config.hostname + "api/Blogs/Getall/")
        .then((response) => {
         
          this.datas = response.data;
          //console.log(this.datas)
         
        });
  }
}
</script>
