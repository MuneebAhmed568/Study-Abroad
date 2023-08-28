<template>
  <fragment>
     
      <div class="container-fluid" style="padding: 20px 20px;">
			    <div class="row">
				    <div class="col-sm-8" >
              <Adds :from_page="from_page" />
                        <div class="card mt-3" style="padding: 20px">
                            <!-- <div class="single-blog mb-5 wow fadeInUp animated"></div> -->
                            <div>
                              <h2 class="text-center"><b>Study Abroad Courses</b></h2>
                              <dl>
                                  <dt  v-for="dat in datas" :key="dat">•	{{dat.Course_Name}}</dt>
                              </dl>
                              
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
  props:['data'],
    data () {
	return {
		slides: this.data,
		from_page:"courses",
		datas:""
	}
  }, 
	components: {
	Adds,
	SideAdds,
	Form,
    
	
	
	
	},
  mounted () {
    this.from_page="courses"
    this.axios.get(config.hostname+'api/Coursesinfo/Getall/')
        .then((response) => {
          this.datas = response.data
		  console.log(this.datas) 
        }) 
  }
}
</script>
