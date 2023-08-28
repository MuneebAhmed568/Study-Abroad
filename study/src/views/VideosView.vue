<template>
  <fragment>
    <body style="background-color:#F1F1F1">
      <!-- <div class="bg-overlay" style="">
          <div class="container-fluid p-5">
              <h3 align="center">Study Abroad Videos</h3>
              <div class="row mt-4"></div>
              <div class="search-container3 col-6 offset-3">
                  <form class="bar" action="/action_page.php" style="width:auto ">
                  <input type="text" placeholder="Search for videos" style="height:40px;" name="search2">
                  <button type="submit" style="text-align:right; height:40px;"><i class="fa fa-search mr-2"></i></button>
                  </form>
              </div>
          </div>
      </div> -->
     
      <div class="container-fluid" style="padding: 20px 20px;">
        <div class="row">
              <div class="col-sm-8">
                <Adds :from_page="from_page" />
              <div class="card mt-3" style="padding: 20px;">
                  	<h2 class="text-center"><b>Top Videos</b></h2>
                      <div class="row">
                        <div class="col-sm-4 mt-2" height="auto">
                        <div class="card">
                            <iframe width="100%" height="100%"
                              src="https://www.youtube.com/embed/tgbNymZ7vqY?loop=1&mute=1">
                          
                              </iframe>
                          <h6 class="text-center">Name of the Video </h6>
                        </div>
                        </div>
                        <div class="col-sm-4 mt-2"  height="auto">
                          <div class="card">
                              <iframe width="100%" height="100%"
                                src="https://www.youtube.com/embed/tgbNymZ7vqY?loop=1&mute=1">
                            
                              </iframe>
                              <h6 class="text-center">Name of the Video </h6>
                          </div>
                        </div>
                        <div class="col-sm-4  mt-2"  height="auto">
                          <div class="card">
                              <iframe width="100%" height="100%"
                                src="https://www.youtube.com/embed/tgbNymZ7vqY?loop=1&mute=1">
                            
                              </iframe>
                              <h6 class="text-center">Name of the Video </h6>
                          </div>
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
    </body>
  </fragment>
</template>

<script>
//import config from '@/../config'
// import Form from '@/components/MainForm'
import Adds from '@/components/CorousalSlide'
import SideAdds from '@/components/SideCorousalSlide'
import Form from "@/components/MainForm";

export default {
  props:['data'],
   data () {
	    return {
		   
        from_page:"videos"
	}
  }, 
	components: {
	Adds,
	SideAdds,
  Form,
     
	
	},
    mounted() {
    this.from_page="videos"
    }

}
</script>

<style>

</style>