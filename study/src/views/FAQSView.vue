<template>
  <fragment>
    <!-- <div class="bg-overlay">
		<div class="col-sm-6 offset-3 p-5" >
			<div align="center"><h2>Frequenty Ask Questions</h2></div>
		</div>
	</div> -->
    <div class="container-fluid" style="padding: 20px 20px;">
	    <div class="row">
            <div class="col-sm-8">
                <Adds :from_page="from_page" />
                <div style="margin-top: 40px">
                    <h2 class="mt-5 text-center"><b>FAQ's</b></h2>
                    <div class="">
                        <div class="card mt-3" style="padding:20px 40px">
                            <div class="row">
                                <div class="col-sm-12" align="left">
                                    <h5 class="mt-3">What are the requirements for studying abroad as a Pakistani student?</h5><hr>
                                    <label class="font">The requirements vary depending on the country and institution you choose, but generally, you will need to have a good academic record, language proficiency in the language of instruction, and possibly standardized test scores (such as TOEFL or IELTS). You may also need to provide transcripts, letters of recommendation, and a statement of purpose.</label>
                                    <h5 class="mt-3">How can I find scholarships to study abroad as a Pakistani student?</h5><hr>
                                    <label class="font">Many universities and organizations offer scholarships specifically for international students, including those from Pakistan. You can also search for grants and scholarships from government organizations and non-profits in your home country and in the country you hope to study in.</label>
                                    <h5 class="mt-3">What are the visa requirements for Pakistani students studying abroad?</h5><hr>
                                    <label class="font">The visa requirements for studying abroad vary depending on the country you choose, but generally, you will need to obtain a student visa. The process typically requires you to provide proof of admission to a school, financial support, and a clear background check, among other requirements.</label>
                                    <h5 class="mt-3">Can Pakistani students study abroad?</h5><hr>
                                    <label class="font">Yes, Pakistani students are eligible to study abroad.</label>
                                    <h5 class="mt-3">What countries allow Pakistani students to study there?</h5><hr>
                                    <label class="font">Most countries in Europe, America, Asia, and Australia allow Pakistani students to study there.</label>
                                    <h5 class="mt-3">How much does it cost to study abroad for Pakistani students?</h5><hr>
                                    <label class="font">The cost varies depending on the country and the program, but on average it can range from $10,000 to $30,000 per year.</label>
                                    <h5 class="mt-3">Can Pakistani students work while studying abroad?</h5><hr>
                                    <label class="font">It depends on the country and the student visa restrictions. Some countries allow students to work part-time during their studies, while others do not.</label>
                                    <h5 class="mt-3">How long does it take to process a student visa for Pakistanis?</h5><hr>
                                    <label class="font">It can take anywhere from 4 to 8 weeks to process a student visa.</label>
                                    <h5 class="mt-3">What is the average cost of living for Pakistani students studying abroad?</h5><hr>
                                    <label class="font">The cost of living varies depending on the country and the student's lifestyle, but it can range from $500 to $1,500 per month.</label>
                                    <h5 class="mt-3">What should Pakistani students consider when choosing a study abroad program?</h5><hr>
                                    <label class="font">Location, cost, academic program, support services, and cultural fit.</label>
                                    <h5 class="mt-3">Can Pakistani students extend their study abroad program?</h5><hr>
                                    <label class="font">Yes, Pakistani students can extend their study abroad program, but they will need to meet the visa and immigration requirements of the host country.</label>
                                    <h5 class="mt-3">How can I prepare for cultural differences when studying abroad as a Pakistani student?</h5><hr>
                                    <label class="font">Research the culture of the country you will be studying in, including social customs, communication styles, and cultural norms. Try to immerse yourself in the local culture as much as possible, and make an effort to meet people from diverse backgrounds. Be open to new experiences and perspectives, and be respectful of differences.</label>
                                </div>
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
  </fragment>
</template>

<script>
//import config from '@/../config'
//import SliderImg from '@/SliderImages.json'
import Form from '@/components/MainForm'
import Adds from '@/components/CorousalSlide'
import SideAdds from '@/components/SideCorousalSlide'

export default {
    props:['data'],
    data () {
	    return {
		    slides: this.data,
            from_page:"faq"
		
	}
  }, 
	components: {
	Adds,
	SideAdds,
	Form,
     
	
	},
    mounted() {
    this.from_page="faq"
    }

}
</script>
