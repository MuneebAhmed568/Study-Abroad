<template>
    <div class="row">
    <div class="col-sm-4" v-for="s in eventinfodata" :key="s">
        <div class="card mt-3">
            <div class="single-blog wow fadeInUp animated">
            <div class="single-blog-image">
                <img style="width:100%;height:auto" class="img-fluid mb-3 center" :src="s.imageurlbase64" >
            </div>
            <div class="single-blog-dec"> 
                <div @click="ToSinglePage(s.id)">
                <h3>{{s.title}}</h3>
                <span class="post-date"> <i class="icofont icofont-calendar"></i> {{s.dates}} </span>
                <span class="allpost-cata"> <i class="icofont icofont-ui-tag"></i> {{s.countries}}</span>
                <p> 
                    {{s.detail}}               
                 </p>
                <div class="single-blog-admin">
                    
                    <div class="single-blog-admin-info">
                        <p>By: <span>{{s.email}}</span></p>
                    </div>
                </div>
               </div>
            </div>
            <br>
        </div>
        </div>
        </div>
        
	</div>	
</template> 
<script>
// import config from '@/../../config'

  export default {
      props: ['eventinfodata'],
      data(){
          return{
            image1:undefined,

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