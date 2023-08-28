<template>
  <div class="" style="text-align: center;background-color:white">

        
    <div class="container-fluid" style="padding: 20px 20px;">
	        <div class="row">
	            <div class="col-sm-8">
                    <Adds :from_page="from_page" />
                    <h2 class="mt-5"><b> Consultants</b></h2>
	                <p style="font-size: 16px">We offer a variety of consultants to our valuable customers, find your favourite consultants</p>
                    <div style="margin-top: 40px">
                        <div class="container-fluid">
		                    <div class="row">
                                <TopConsultant :ConsultantsData=" ConsultantsData" />
                            </div>
                            
                        </div>

                    </div>
                    <!-- <div class="container-fluid mt-3" style="background-color:white">
	                    <div style="text-align: center" class="pt-2 pb-2">
		                    <h2 class="mt-5"><b>News And Events</b></h2>
		                    <p style="font-size: 20px">See the top trending News and book your services now.</p>	
	                    </div>
                        <section class="pb-5 mt-3">
                              <TopNews  :topnew="topnew"/>
                        </section>
                    </div> -->
                    <showcomment :commentsshow="commentsshow"/>
                    <Comment :pagename="pagename"/>
                </div>
                <div class="col-sm-2">
        <Form />
      </div>
                <div class="col-sm-2">
                    <SideAdds :slides="data" />
                </div>
            </div>
        </div>

</div>
</template>

<script>
import config from '@/../config'
//import SliderImg from '@/SliderImages.json'
import Adds from '@/components/CorousalSlide'
import TopConsultant from '@/components/AllConsultants'
import SideAdds from '@/components/SideCorousalSlide'
import Form from '@/components/MainForm'
// import TopNews from '@/components/TopNews'
import Comment from '@/components/LeaveComment'
//import ConsultantsImg from '@/TopConsultants.json'
//import ConsultantCards from '@/ConsultantCard.json'
import showcomment from '@/components/ShowComment'

export default {
    props:['data'],
    data () {
	return {
		slides: this.data,
        ConsultantsData: [{"CompanyName":"Company Name","Conatctno":"","Email":"","Address":"","City":"","websitelink":"","companylogo":"","consultancyservices":"","services":"","Detail":"","Password":"","statuscheck":"","Phoneno":"","Personname":"","companylogobase64":'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY',"mapaddress":"","id":""}],
	
        topnew: [{"title":"Event Title","id":"","shortdiscription":"Discription","countries":"Counteries","detail":"","imageurl":"","email":"","dates":"","statuscheck":"","expiretime":"","activatetime":"","activatedate":"","expiredates":"","imageurlbase64":'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY'}],
       
        pagename:"Consultant",
        commentsshow:"",
        from_page:"consultant"

		 
		
		
	}
  }, 
	components: {
	 Adds,
	 SideAdds,
	 Form,
     TopConsultant,
    //  TopNews,
     Comment,
      showcomment
	
	
	},
    methods: {
        filterSearch()
        {
            var select = document.getElementById("CountryOptions");
            var countries = select.options[select.selectedIndex].value
            //////console.log("Country is  : "+ countries);
            this.axios.get(config.hostname+'api/Consultantinfo/Getbycountries/'+ countries)
            .then((response) => {
            this.ConsultantsData = response.data
		    //////console.log(this.ConsultantsData) 
            }) 
        },
    },
	  mounted () {
        this.from_page="consultant"
        this.axios.get(config.hostname+'api/Consultantinfo/Getallinfo/')
        .then((response) => {
          this.ConsultantsData = response.data
		  //////console.log(this.ConsultantsData) 
        }) 
        
        this.axios.get(config.hostname+'api/Commentsinfo/Getall/'+ this.pagename )
        .then((response) => {
          this.commentsshow = response.data
          //////console.log("comments")
		  //////console.log(this.commentsshow) 
          
        })
	    this.axios.get(config.hostname+'api/eventsinfo/Getall/')
        .then((response) => {
          this.topnew = response.data 
          
        }) 
          this.axios.put(config.hostname+'api/ViewsCounter/MainConsultantpageviewsupdate/')
        .then((response) => {
            response
		  ////console.log(response.data) 
        })	
  }
  
}
</script>

<style>

</style>