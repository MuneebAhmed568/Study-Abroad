<template >
		<div class="card imp" style="padding:5px;height:auto;border-radius:10px;">			
            <h3 class="text-center"><b>Featured Ads</b></h3>
            <div class="mt-2 " v-for="s in slides.slice(26,39)" :key="s">
            <a href="">
            <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">				  
            <div style="border-radius:10px !important" class="carousel-inner">
            <div class="carousel-item active ">
                <div class="d-block w-100">
                    <img :src="s.img1" class="w-100 " style="height:220px">
                </div>
                </div>
                <div class="carousel-item">
                    <div class="d-block w-100">
                        <img :src="s.img2" class="w-100" style="height:220px">
                    </div>
                </div>
                <div class="carousel-item">
                    <div class="d-block w-100">
                        <img :src="s.img3" class="w-100" style="height:220px">
                    </div>
                </div>
            </div>
            </div>
            </a>
            </div>
		</div>
</template>
<script>
//import config from '../../config'
import ads from '../../data.json'

  export default { 
    //   props: ['slides'],
      data(){
          return{
              image:undefined,
              slides:[{img1:"",img2:"",img3:""}]
          }
      },
      async mounted(){
        
    //console.log("testing6")

    this.slides = ads.ads;


//For endpoint use the Below one (Just remove the Multi-comment only), For Local use the above line
/*

        await this.axios.get(config.json_Api+'ads')
		.then(async (response) => {
			//console.log("fetching Data from the internet");
		this.slides = await response.data;
        //console.log("sabar ka paimana test naa kro hamara")
		//console.log(response)
			})


            */



     //END HERE



      },
      methods: {
           getImage (pic) {
                this.image = pic
      return this.image
           }
           
      }
      
}
</script>
