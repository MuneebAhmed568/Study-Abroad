<template>
        <div class=" container-fluid" >
        <!-- <div class="container-fluid"> -->
            <div 
            v-for="slide in slides.slice(mid_2_min,mid_2_max)" :key="slide"
            class="col-sm-12" >
                <a href="">
                    <div
                    id="carouselExampleIndicators"
                    class="carousel slide"
                    data-ride="carousel">
                        <div class="carousel-inner" style="border-radius:10px">
                            <div class="carousel-item active">
                                <div class="d-block">
                                    <img :src="slide.img1" style="height:450px;width:100%;" >
                                </div>
                            </div>
                            <div class="carousel-item">
                                <div class="d-block">
                                    <img :src="slide.img2" style="height:450px;width:100%;"  >
                                </div>
                            </div>
                            <div class="carousel-item">
                                <div class="d-block">
                                    <img :src="slide.img3" style="height:450px;width:100%;" >
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
        </div>
    </template>
    <script>
    import config from '../../config'
    import ads from '../../data.json'
    
      export default {
          props: ['from_page'],
          data(){
              return{
                  image:undefined,
                  slides:[{img1:"",img2:"",img3:""}],
                  start_1_min:0,
                  start_1_max:0,
                  mid_2_min:0,
                  mid_2_max:0,
                  end_3_min:0,
                  end_3_max:0,
              }
          },
         async  mounted(){
            switch(this.from_page){
                case "news":
                    this.start_1_min=25;
                    this.start_1_max=28;
                    this.mid_2_min=28;
                    this.mid_2_max=29;
                    this.end_3_min=29;
                    this.end_3_max=32;
                    //console.log("news success")
                    break;
                case "scholarship":
                    this.start_1_min=32;
                    this.start_1_max=35;
                    this.mid_2_min=35;
                    this.mid_2_max=36;
                    this.end_3_min=36;
                    this.end_3_max=39;
                    //console.log("news success")
                    break;
                case "university":
                    this.start_1_min=39;
                    this.start_1_max=42;
                    this.mid_2_min=42;
                    this.mid_2_max=43;
                    this.end_3_min=43;
                    this.end_3_max=46;
                    //console.log("news success")
                    break;
                case "consultant":
                    this.start_1_min=46;
                    this.start_1_max=49;
                    this.mid_2_min=49;
                    this.mid_2_max=50;
                    this.end_3_min=50;
                    this.end_3_max=53;
                    //console.log("news success")
                    break;
                case "guide":
                    this.start_1_min=53;
                    this.start_1_max=56;
                    this.mid_2_min=56;
                    this.mid_2_max=57;
                    this.end_3_min=57;
                    this.end_3_max=60;
                    //console.log("news success")
                    break;
                case "embassy":
                    this.start_1_min=60;
                    this.start_1_max=63;
                    this.mid_2_min=63;
                    this.mid_2_max=64;
                    this.end_3_min=64;
                    this.end_3_max=67;
                    //console.log("news success")
                    break;
                case "courses":
                    this.start_1_min=67;
                    this.start_1_max=70;
                    this.mid_2_min=70;
                    this.mid_2_max=71;
                    this.end_3_min=71;
                    this.end_3_max=74;
                    //console.log("news success")
                    break;
                case "test":
                    this.start_1_min=74;
                    this.start_1_max=77;
                    this.mid_2_min=77;
                    this.mid_2_max=78;
                    this.end_3_min=78;
                    this.end_3_max=81;
                    //console.log("news success")
                    break;
                case "faq":
                    this.start_1_min=81;
                    this.start_1_max=84;
                    this.mid_2_min=84;
                    this.mid_2_max=85;
                    this.end_3_min=85;
                    this.end_3_max=88;
                    //console.log("news success")
                    break;
                case "studyads":
                    this.start_1_min=88;
                    this.start_1_max=91;
                    this.mid_2_min=91;
                    this.mid_2_max=92;
                    this.end_3_min=92;
                    this.end_3_max=95;
                    //console.log("news success")
                    break;
                case "videos":
                    this.start_1_min=95;
                    this.start_1_max=98;
                    this.mid_2_min=98;
                    this.mid_2_max=99;
                    this.end_3_min=99;
                    this.end_3_max=102;
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
            
            //console.log("hello coursacel",this.from_page)
            //console.log("testing5")
            


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


//END HERE
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
    