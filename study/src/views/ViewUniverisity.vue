<template>
  <fragment>
   
   
     
      <div class="container-fluid" style="padding: 20px 20px;">
        <div class="row">
          <div class="col-sm-8">
            <Adds :from_page="from_page" />
            <h2 class="text-center mt-3"><b> Universities</b></h2>
            <p style="font-size: 16px" class="text-center">
              Lorem Ipsum is simply dummy text of the printing and typesetting
              industry.
            </p>

            <TopUniversities :topuni="topuni" />
            <!-- <div class="container-fluid mt-3" style="background-color: white">
              <div style="text-align: center" class="pt-2 pb-2">
                <h2 class="mt-5"><b>News And Events</b></h2>
                <p style="font-size: 20px">
                  See the top trending News and book your services now.
                </p>
              </div>
              <section class="pb-5 mt-3">
                <TopNews :topnew="topnew" />
              </section>
            </div> -->
            <showcomment :commentsshow="commentsshow" />
            <Comment :pagename="pagename" />
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
import config from "@/../config";
//import SliderImg from '@/SliderImages.json'
//import Universities from '@/TopUni.json'
//import Carduni from '@/UniCard.json'
import Adds from "@/components/CorousalSlide";
import SideAdds from "@/components/SideCorousalSlide";
import Form from "@/components/MainForm";
import TopUniversities from "@/components/AllUniversity";
// import TopNews from "@/components/TopNews";
import Comment from "@/components/LeaveComment";
import showcomment from "@/components/ShowComment";

export default {
  props: ["data"],
  data() {
    return {
      topnew: [
        {
          title: "Event Title",
          id: "",
          shortdiscription: "Discription",
          countries: "Counteries",
          detail: "",
          imageurl: "",
          email: "",
          dates: "",
          statuscheck: "",
          expiretime: "",
          activatetime: "",
          activatedate: "",
          expiredates: "",
          imageurlbase64:
          'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY',
        },
      ],
      topuni: [
        {
          id: "",
          institutename: "University Name",
          email: "Email",
          country: "",
          Detail: "",
          mainpicurlbase64:
          'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY',
        },
      ],
      pagename: "University",
      commentsshow: "",
      from_page:"university"
    };
  },
  components: {
    Adds,
    SideAdds,
    Form,
    TopUniversities,
    // TopNews,
    Comment,
    showcomment,
  },
  methods: {
    filterSearch() {
      var select = document.getElementById("CountryOptions");
      var countries = select.options[select.selectedIndex].value;
      ////console.log("Country is  : "+ countries);

      this.axios
        .get(config.hostname + "api/instituteinfo/countries/" + countries)
        .then((response) => {
          this.topuni = response.data;
        });
    },
  },
  mounted() {
    this.from_page="university"
    this.axios
      .get(config.hostname + "api/eventsinfo/Getall/")
      .then((response) => {
        this.topnew = response.data;
      });

    this.axios
      .get(config.hostname + "api/Commentsinfo/Getall/" + this.pagename)
      .then((response) => {
        this.commentsshow = response.data;
        ////console.log("comments")
        ////console.log(this.commentsshow)
      });

    this.axios
      .get(config.hostname + "api/instituteinfo/Getallinfo/")
      .then((response) => {
        this.topuni = response.data;
      });
    this.axios
      .put(config.hostname + "api/ViewsCounter/MainUniversitypageviewsupdate/")
      .then((response) => {
        response;
        ////console.log(response.data)
      });
  },
};
</script>