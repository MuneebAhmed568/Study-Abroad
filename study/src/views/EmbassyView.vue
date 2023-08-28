<template>
    <div class="container-fluid" style="padding: 20px 20px;">
	    <div class="row">
            <div class="col-sm-8">
                <Adds :from_page="from_page" />
                <EmbassyCard :embassydata="embassydata"/>
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



</template>
<script>
import config from '@/../config'
//import SliderImg from '@/SliderImages.json'
//import Embassy from '@/EmbassyCard.json'
import Form from '@/components/MainForm'
import Adds from '@/components/CorousalSlide'
import SideAdds from '@/components/SideCorousalSlide'
import Comment from '@/components/LeaveComment'
import showcomment from '@/components/ShowComment'
import EmbassyCard from '@/components/EmbassyCard'



export default {
    props:['data'],
    data () {
	    return {
		    slides: this.data,
            embassydata: [{"id":"","embassyname":"Embassy Name","embassylogobase64":'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY'}],
            commentsshow:"",
            pagename:"Embassy",
            from_page:"embassy"
		
	}
  }, 
	components: {
	Adds,
	SideAdds,
	Form,
	Comment,
    showcomment,
    EmbassyCard
    
	},
    methods:{
        filterSearch()
        {
            var select = document.getElementById("CountryOptions");
            var countries = select.options[select.selectedIndex].value
            ////console.log("Country is  : "+ countries);
            this.axios.get(config.hostname+'api/embassyinfo/Getbycountries/'+ countries)
            .then((response) => {
            this.embassydata = response.data
		    ////console.log(this.embassydata) 
            }) 

             
        },
    },
    mounted () {
        this.from_page="embassy"
        this.axios.get(config.hostname+'api/embassyinfo/Getallinfo/')
        .then((response) => {
          this.embassydata = response.data
		  ////console.log(this.embassydata) 
        }) 

          this.axios.get(config.hostname+'api/Commentsinfo/Getall/'+ this.pagename )
        .then((response) => {
          this.commentsshow = response.data
          ////console.log("comments")
		  ////console.log(this.commentsshow) 
          
        })

         
    }

}

</script>