<template>
    <div class="container-fluid" style="padding: 20px 20px;">
	    <div class="row">
            <div class="col-sm-8">
                <div>
                    <Adds :from_page="from_page" />
                    <h2 class="text-center mt-4"><b class="text-center">About Us</b></h2>
                    <p>This website has been created with the aim of providing complete guidance to students who want to study in any country. Our aim is to provide authentic and useful information about different countries, universities, their entry process, admission procedure and visa process. Students can get all the information about any country regarding study abroad on this website.
                    We also provide complete information about the scholarship opportunities offered by foreign universities for Pakistani students. 
                    We provide a platform to all the foreign universities to advertise about their programs/ courses in which they offer admissions. Along with this a platform is also provided to the Foreign Education Consultants to advertise about their services to the students.
                    </p>
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



</template>
<script>
//import SliderImg from '@/SliderImages.json'
//import Embassy from '@/EmbassyCard.json'
import Form from '@/components/MainForm'
import Adds from '@/components/CorousalSlide'
import SideAdds from '@/components/SideCorousalSlide'



export default {
    props:['data'],
    data () {
	    return {
		    slides: this.data,
            embassydata: [{"id":"","embassyname":"Embassy Name","embassylogobase64":'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY'}],
            commentsshow:"",
            pagename:"aboutus",
            from_page:"aboutus"
		
	}
  }, 
	components: {
	Adds,
	SideAdds,
	Form,
    
	},
    methods:{
    },
    mounted () {
        this.from_page="home"
       

          

         
    }

}

</script>