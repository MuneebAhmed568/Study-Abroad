<template>
  <div class="container fluid mt-2">
    <div class="">
      <h2 class="text-center"><b>Latest Scholorships</b></h2>
      <div>
        <div class="btn-actions-pane-right"></div>
      </div>
      <div class="">
        <div class="table-responsive">
          <table class="table table-borderless table-hover">
            <tbody>
              <div v-for="s in Scholarshipcard.slice(0, 5)" :key="s">
                <div @click="ToSinglePage(s.id)">
                  <tr align="left" style="font-size: 12px">
                    <td width="10%" class="text-muted">
                      <img
                        :src="s.imageurlbase64"
                        style="height: 50px; width: 50px"
                      />
                    </td>
                    <td width="40%" class="">{{ s.title }}</td>
                    <td width="40%" class="">{{ s.shortdiscription }}</td>
                    <td width="10%" class="">{{ s.dates }}</td>
                  </tr>
                </div>
              </div>
            </tbody>
          </table>
          <router-link to="/scholarship">
            <button
              class="btn mt-4 center"
              style="background-color: #1ea1f3;
                color: white;
                width: 150px;
                border-radius: 10px;
              "
            >
              See More Details
            </button>
          </router-link>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
// import config from "@/../config";

export default {
  //   props: ['Scholarshipdata'],
  data() {
    return {
      image: undefined,
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
    };
  },
  async mounted() {
    // await this.axios
    //   .get(config.hostname + "api/scholarshipinfo/Getall/")
    //   .then((response) => {
    //     //console.log("testing9",response)
    //     this.Scholarshipdata = response.data;
    //     //console.log(this.Scholarshipdata)
    //   });
  },
  methods: {
    getImage(pic) {
      this.image = pic;
      return this.image;
    },

    ToSinglePage(idss) {
      // this.$router.push({path: '/ConsultantPage', params: { username: email }});
      // this.$router.push({name:'ConsultantPage', params: { param: email } })
      this.$router.push({ name: "scholarshipPage", params: { ID: idss } });
    },
  },
};
</script>