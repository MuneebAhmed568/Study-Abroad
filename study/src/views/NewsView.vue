<template>
  <v-fragment>
   
      <div class="container-fluid" style="padding: 20px 20px;">
        <div class="row">
          <div class="col-sm-8">
            <Adds :from_page="from_page" />


            <div class="">
              <NewsCard
                :eventinfodata="eventinfodata"
                :newsfilter="newsfilter"
              />
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
  </v-fragment>
  <!-- <SideAdds :slides="slides" /> -->
</template>

<script>
import config from "@/../config";
//import SliderImg from '@/SliderImages.json'
import Adds from "@/components/CorousalSlide";
import SideAdds from "@/components/SideCorousalSlide";
import Form from "@/components/MainForm";
import NewsCard from "@/components/NewsCard";
//import blog from '@/NewsPageblog.json'
// import Footer from '@/components/Footer'
import Comment from "@/components/LeaveComment";
import showcomment from "@/components/ShowComment";

export default {
  props: ["data"],
  data() {
    return {
      eventinfodata: [
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
      pagename: "news",
      newsfilter: "",
      commentsshow: "",
      from_page:"news"
    };
  },
  components: {
    Adds,
    SideAdds,
    Form,
    NewsCard,
    Comment,
    showcomment,
    //   Footer
  },
  mounted() {
    this.from_page="news"
    // var currentDate = new Date();
    // ////console.log("date is : ");
    // ////console.log(currentDate);
    // var currentDateWithFormat = currentDate.toJSON().slice(0,10).replace(/-/g,'-');
    // ////console.log(currentDateWithFormat)
    // var currentDateWithFormatyear = new Date().toJSON().slice(0,4).replace(/-/g,'-');
    // ////console.log(currentDateWithFormatyear)
    // var currentDateWithFormatmonth = new Date().toJSON().slice(5,7).replace(/-/g,'-');
    // ////console.log(currentDateWithFormatmonth)
    // var currentDateWithFormatday = new Date().toJSON().slice(8,10).replace(/-/g,'-');
    // ////console.log(currentDateWithFormatday)

    //                 ////console.log("TODAY IS : ")
    //                 ////console.log(currentDateWithFormatmonth+"-"+currentDateWithFormatday+"-"+currentDateWithFormatyear)
    this.axios
      .get(config.hostname + "api/eventsinfo/Getall/")
      .then((response) => {
        this.eventinfodata = response.data;
        ////console.log(this.eventinfodata)
      });

    this.axios
      .get(config.hostname + "api/Commentsinfo/Getall/" + this.pagename)
      .then((response) => {
        this.commentsshow = response.data;
        ////console.log("comments")
        ////console.log(this.commentsshow)
      });
    this.axios
      .put(config.hostname + "api/ViewsCounter/MainNewspageviewsupdate/")
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
        .get(config.hostname + "api/eventsinfo/Getbycountries/" + countries)
        .then((response) => {
          this.eventinfodata = response.data;
          ////console.log(this.eventinfodata)
        });
    },
  },
};
</script>
