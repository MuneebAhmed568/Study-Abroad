<template>
    <div>
   
        <div 
        v-for="slide in slides.slice(mid_2_min,mid_2_max)" :key="slide"
        class="">
            <a href="">
                <div
                id="carouselExampleIndicators"
                class="carousel slide"
                data-ride="carousel">
                    <div class="carousel-inner" style="border-radius:10px">
                        <div class="carousel-item active">
                            <div class="d-block">
                                <img :src="slide.img1" style="height:400px;width:100%;" >
                            </div>
                        </div>
                        <div class="carousel-item">
                            <div class="d-block">
                                <img :src="slide.img2" style="height:400px;width:100%;"  >
                            </div>
                        </div>
                        <div class="carousel-item">
                            <div class="d-block">
                                <img :src="slide.img3" style="height:400px;width:100%;" >
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
      props: ['from_page'],
      data(){
          return{
              image:undefined,
              slides:[{img1:"",img2:"",img3:""}],
            //   start_1_min:0,
            //   start_1_max:0,
              mid_2_min:5,
              mid_2_max:6,
            //   end_3_min:0,
            //   end_3_max:0,
          }
      },
     async  mounted(){
        switch(this.from_page){
            case "home":
                console.log("INSIDE HOME")
                this.mid_2_min=5;
                this.mid_2_max=6;
                //console.log("case 1 inside")
                break;
            case "news":
                this.mid_2_min=14;
                this.mid_2_max=15;
                //console.log("news success")
                break;
            case "scholarship":
                this.mid_2_min=7;
                this.mid_2_max=8;
                //console.log("news success")
                break;
            case "university":
                this.mid_2_min=8;
                this.mid_2_max=9;
                //console.log("news success")
                break;
            case "consultant":
                this.mid_2_min=11;
                this.mid_2_max=12;
                //console.log("news success")
                break;
            case "guide":
                this.mid_2_min=6;
                this.mid_2_max=7;
                //console.log("news success")
                break;
            case "embassy":
                this.mid_2_min=10;
                this.mid_2_max=11;
                //console.log("news success")
                break;
            case "courses":
                this.mid_2_min=9;
                this.mid_2_max=10;
                //console.log("news success")
                break;
            case "test":
                this.mid_2_min=12;
                this.mid_2_max=13;
                //console.log("news success")
                break;
            case "faq":
                this.mid_2_min=15;
                this.mid_2_max=16;
                //console.log("news success")
                break;
            case "studyads":
                this.mid_2_min=13;
                this.mid_2_max=14;
                //console.log("news success")
                break;
            case "Blogs":
                this.mid_2_min=16;
                this.mid_2_max=17;
                //console.log("news success")
                break;
            case "videos":
                this.mid_2_min=17;
                this.mid_2_max=18;
                //console.log("news success")
                break;
            case "aboutus":
                this.mid_2_min=4;
                this.mid_2_max=5;
                //console.log("news success")
                break;
           
            default:
                //console.log("not found muneeb ki baat");
                break;
        }
        // if(this.from_page=="home"){
        //     this.start_1_min=0;
        //     this.start_1_max=3;
        //     this.mid_2_min=3;
        //     this.mid_2_max=4;
        //     this.end_3_min=4;
        //     this.end_3_max=7;
        //     console.log("home success")
        // }
        // if (this.from_page=="news"){
        //     this.start_1_min=25;
        //     this.start_1_max=28;
        //     this.mid_2_min=28;
        //     this.mid_2_max=29;
        //     this.end_3_min=29;
        //     this.end_3_max=7;
        //     console.log("news success")
        // }
        
        // console.log("hello coursacel")
        // console.log("testing5") 
        



        this.slides = ads.ads;


        //For endpoint use the Below one (Just remove the Multi-comment only), For Local use the above line
        /*
        await this.axios.get(config.json_Api+'ads')
		.then(async (response) => {
			//console.log("fetching Data from the internet")
		this.slides = await response.data
        //console.log("sabar ka paimana test naa kro hamara")
		//console.log(response)
			}) 



            */


           // END HERE





          //console.log(this.slides)
      },
      methods: {
           getImage (pic) {
                this.image = pic
      return this.image
           }
           
      }
}
</script>
