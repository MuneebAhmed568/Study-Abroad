<template>
  <fragment>
     
      <div>
       
      </div>
      <div class="container-fluid" style="padding:  20px 20px;">
        <div class="row">
          <div class="col-sm-8">
            <Adds :from_page="from_page" />
           
            <div class="mt-2">
              <div class="row">
                <Card  />
              </div>
            </div>
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
import Adds from "@/components/CorousalSlide";
import SideAdds from "@/components/SideCorousalSlide";
import Form from "@/components/MainForm";
import Card from "@/components/ScholarshipCard";
//import TopScholarshipsJSON from '@/ScholarshipJson.json'
//import Scholarshipcard from '@/Card.json'
import Comment from "@/components/LeaveComment";
import showcomment from "@/components/ShowComment";

export default {
  props: ["data"],
  data() {
    return {
      Scholarshipcard: [
        {
          id: "",
          title: "Scholarship Title",
          shortdiscription: "Discription",
          countries: "",
          detail: "",
          imageurl: "",
          email: "",
          dates: "01-01-2000",
          statuscheck: "",
          imageurlbase64:
          'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY',
          totalreviewscount: "",
          totalusercount: "",
          averagecount: "",
          expiretime: "",
          activatetime: "",
          activatedate: "",
          expiredates: "",
        },
      ],
      pagename: "scholarship",
      commentsshow: "",
      from_page:"scholarship"
    };
  },
  components: {
    Adds,
    SideAdds,
    Form,
    Card,
    Comment,
    showcomment,
  },
  mounted() {
    this.from_page="scholarship"
    
    this.axios
      .get(config.hostname + "api/scholarshipinfo/Getallinfo/")
      .then((response) => {
        this.Scholarshipcard = response.data;
        console.log(this.Scholarshipcard)
      });

    this.axios
      .get(config.hostname + "api/Commentsinfo/Getall/" + this.pagename)
      .then((response) => {
        this.commentsshow = response.data;
        ////console.log("comments")
        ////console.log(this.commentsshow)
      });
    this.axios
      .put(config.hostname + "api/ViewsCounter/MainScholarshippageviewsupdate/")
      .then((response) => {
        response;
        ////console.log(response.data)
      });
  },
  methods: {
    Search() {
      var select = document.getElementById("CountryOptions");
      var countries = select.options[select.selectedIndex].value;
      ////console.log("Country is  : "+ countries);

      this.axios
        .get(config.hostname + "api/scholarshipinfo/countries/" + countries)
        .then((response) => {
          this.Scholarshipcard = response.data;
          ////console.log(this.Scholarshipcard)
        });
    },
  },
};
</script>
