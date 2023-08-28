<template>
  <fragment>
    <!-- <div class="bg-overlay" style="">
      <div class="container-fluid p-5">
        <h3 align="center">Abroad Study Ads</h3>
        <div class="row mt-4">
          <div class="col-md-4"></div>
          <div class="col-md-4">
            <div class="position-relative form-group">
              <select id="CountryOptions" name="select" class="custom-select">
                <option id="ckh0" value="All">Select Country</option>
                <option id="ckh1" value="Austria">Austria</option>
                <option id="ckh2" value="China">China</option>
                <option id="ckh3" value="UK">UK</option>
                <option id="ckh4" value="France">France</option>
                <option id="ckh5" value="Germany">Germany</option>
                <option id="ckh6" value="Canada">Canada</option>
              </select>
            </div>
          </div>
        </div>
        <div class="text-center mt-2">
          <button
            v-on:click.prevent="filterSearch"
            class="mb-2 mr-2 btn btn-primary"
          >
            <i class="pe-7s-search"> </i> Search
          </button>
        </div>
      </div>
    </div> -->
    <div class="container-fluid" style="padding: 20px 20px;">
      <div class="row">
        <div class="col-sm-8">
          <Adds :from_page="from_page" />
          <StudyAdCard :adsdata="adsdata" />
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
import Form from '@/components/MainForm'
import Adds from "@/components/CorousalSlide";
import SideAdds from "@/components/SideCorousalSlide";
//import StudyAd from '@/StudyAdsCard.json'
import StudyAdCard from "@/components/StudyAdsCard";
import Comment from "@/components/LeaveComment";
import showcomment from "@/components/ShowComment";

export default {
  props: ["data"],
  data() {
    return {
      adsdata: [
        {
          Title: "Add Title",
          id: "",
          Country: "Country",
          Educationlevel: "Education level",
          Detail: "",
          imageurl: "",
          Email: "",
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

      commentsshow: "",
      from_page:"studyads",
      pagename: "StudyAds",
      adsfilter: "",
    };
  },
  components: {
    Adds,
    SideAdds,
    Form,
    StudyAdCard,
    Comment,
    showcomment,
  },
  methods: {
    filterSearch() {
      var select = document.getElementById("CountryOptions");
      var Country = select.options[select.selectedIndex].value;
      ////console.log("Country is  : "+ Country);

      this.axios
        .get(config.hostname + "api/addsinfo/Getbycountries/" + Country)
        .then((response) => {
          this.adsdata = response.data;
          ////console.log(this.adsdata)
        });
    },
  },
  mounted() {
    this.from_page="studyads";
    this.axios
      .get(config.hostname + "api/addsinfo/Getall/")
      .then((response) => {
        this.adsdata = response.data;
        ////console.log(this.adsdata)
      });

    this.axios
      .get(config.hostname + "api/Commentsinfo/Getall/" + this.pagename)
      .then((response) => {
        this.commentsshow = response.data;
        ////console.log("comments")
        ////console.log(this.commentsshow)
      });
    this.axios
      .put(config.hostname + "api/ViewsCounter/MainAddspageviewsupdate/")
      .then((response) => {
        response;
        ////console.log(response.data)
      });
  },
};
</script>

<style>
</style>