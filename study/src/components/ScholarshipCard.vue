<template>
 
    <div class="col-sm-4 mt-2" v-for="s in Scholarshipcard" :key="s">
	
				<div class="card" style="padding:10px 10px">
				<div class="row">
					<div  @click="ToSinglePage(s.id,s.email)">
					<div class="col-sm-12">
						<img :src="s.imageurlbase64" class="mb-3 w-100"/>
					</div>
					<div class="col-sm-12" >
						<h2 class="mt-2"><b>{{s.title}}</b></h2>
						<!-- <h6 class="mt-2">Level :</h6>
						<label class="font"><i class="fa fa-stair"></i>{{s.level}}</label><br> -->
						<!-- <h6 class="mt-2">Scholorship For</h6> -->
						<label class="font">{{s.shortdiscription}}</label>
						<!-- <h4 class="mt-2"> {{s.institute}}</h4> -->
						
						<h5 class="mt-2">Apply Date:</h5>
						<label class="font">{{s.dates}}</label>
					</div>
					<div class="col-sm-12">
						<h5 class="mt-2">Country:</h5>
						<h6 class="font">{{s.countries}}</h6>
					</div>
					</div>
				</div>
			</div>
	
	</div>
</template>
<script>
//import config from '@/../../config'

  export default {
      props: [],
	  data(){
          return{
            image:undefined,
			Scholarshipcard: [
				{
				id: "1",
				title: "Australian Awards Scholarship",
				shortdiscription: "Australia Awards Scholarships are awards that are issued by the Australian Government, specifically by the Department of Foreign Affairs and Trade. ",
				countries: "Australia",
				detail: "",
				imageurl: "",
				email: "",
				dates: "1st February 2023",
				imageurlbase64:
				'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY',
				expiredates: "1st May 2023",
				},
				{
				id: "2",
				title: "Turkish Burslari Scholarship",
				shortdiscription: "Turkey Bursary is a fully financed scholarship for master’s and Ph.D. studies at the undergraduate and postgraduate levels in Turkey. ",
				countries: "Turkey",
				detail: "",
				imageurl: "",
				email: "",
				dates: "10th January 2023",
				imageurlbase64:
				'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY',
				expiredates: "20th February 2023",
				},
				{
				id: "3",
				title: "Scotland’s Saltire Scholarship",
				shortdiscription: "A fantastic chance to study in a nation with renowned universities and a long history of academic distinction is Scotland's Saltire Scholarships.",
				countries: "Scotland",
				detail: "",
				imageurl: "",
				email: "",
				dates: "1st February 2023",
				imageurlbase64:
				'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY',
				expiredates: "1st April 2023",
				},
				{
				id: "4",
				title: "GREAT Scholarship",
				shortdiscription: "The GREAT Britain Campaign of the UK government and the British Council co-fund each scholarship along with partner UK higher education institutions.",
				countries: "UK",
				detail: "",
				imageurl: "",
				email: "",
				dates: "1st February 2023",
				imageurlbase64:
				'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY',
				expiredates: "1st May 2023",
				},
				{
				id: "5",
				title: "Fulbright Scholarship",
				shortdiscription: "The Fulbright programme provides funding for Masters or Ph.D. graduate studies in the United States.",
				countries: "USA",
				detail: "",
				imageurl: "",
				email: "",
				dates: "1st February 2023",
				imageurlbase64:
				'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY',
				expiredates: "12th April 2023",
				},
				{
				id: "6",
				title: "Erasmus Mundus Joint Master Degrees-2023",
				shortdiscription: "A coalition of European Universities jointly offers the Erasmus Mundus Joint Master Degree (EMJMD), a 1- or 2-year master's degree programme.",
				countries: "European",
				detail: "",
				imageurl: "",
				email: "",
				dates: "17th October 2022",
				imageurlbase64:
				'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY',
				expiredates: "15th January 2023",
				},
				{
				id: "7",
				title: "Chevening Scholarship",
				shortdiscription: "The UK government's overseas scholarship programme is called Chevening. We provide fellowships to study in the UK for a year on a fully financed master's degree programme.",
				countries: "UK",
				detail: "",
				imageurl: "",
				email: "",
				dates: "1st August 2022",
				imageurlbase64:
				'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY',
				expiredates: "1st January 2023",
				},
			],
            
 
          }
      },
      methods:{
          
        getImage1 (pic) {     
                this.image =   pic
                    return this.image           
                },
      
      ToSinglePage (id,email) {
		localStorage.setItem("id",id);
		localStorage.setItem("mainemail",email);
        // this.$router.push({path: '/ConsultantPage', params: { username: email }});
        // this.$router.push({name:'ConsultantPage', params: { param: email } })
        this.$router.push({name: 'scholarshipPage', params: { ID: id}});
      }
  }
}
</script>