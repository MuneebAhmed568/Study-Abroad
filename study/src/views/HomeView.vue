<template>
  <div id="home" class="background-main">
    <div class="background-main-1">
      <div class="container-fluid">
        <!-- <div class="container-fluid" style="padding:0px 50px"> -->
        <div class="row">
          <div
            v-for="slide in slides.slice(start_1_min, start_1_max)"
            :key="slide"
            class="col-sm-4 mt-2"
          >
            <a href="">
              <div
                id="carouselExampleIndicators"
                class="carousel slide"
                data-ride="carousel"
              >
                <div class="carousel-inner" style="border-radius: 10px">
                  <div class="carousel-item active">
                    <div class="d-block w-100">
                      <img
                        :src="slide.img1"
                        style="height: 90px"
                        class="w-100"
                      />
                    </div>
                  </div>
                  <div class="carousel-item">
                    <div class="d-block w-100">
                      <img
                        :src="slide.img2"
                        style="height: 90px"
                        class="w-100"
                      />
                    </div>
                  </div>
                  <div class="carousel-item">
                    <div class="d-block w-100">
                      <img
                        :src="slide.img3"
                        style="height: 90px"
                        class="w-100"
                      />
                    </div>
                  </div>
                </div>
              </div>
            </a>
          </div>
        </div>
        <!-- </div> -->
        <div class="row" style="padding: 10px 0px">
          <div class="col-sm-8">
            <Adds :from_page="from_page" />
            <div
              class="card"
              style="
                padding: 10px 10px 10px 10px;
                border-radius: 10px;
                box-shadow: 0 2px 5px 1px #403c4329;
                margin-top: 5px;
              "
            >
              <h2 class="text-center"><b>Top Consultants</b></h2>
              <p style="font-size: 16" class="text-center">
                Discover a comprehensive list of study abroad consultants and education consultants in Pakistan. Our directory includes consultants based in major cities such as Lahore, Karachi, Islamabad, Peshawar, Quetta, and other prominent locations throughout the country.
              </p>
              <br />
              <div class="container-fluid">
                <div class="row">
                  <Consultants />
                </div>
              </div>
              <div class="wrapper">
                <div class="divider div-transparent div-stopper"></div>
              </div>
              <div class="container-fluid">
                <h2 class="text-center">
                  <b>Discover Your Study Abroad Opportunities with
                    AbroadStudy.pk</b>
                </h2>
                <p style="font-size: 18px">
                  Welcome to AbroadStudy.pk, your one-stop destination for all
                  things related to studying abroad. Our website is dedicated to
                  providing you with the most comprehensive and up-to-date
                  information on universities, courses, and study destinations
                  around the world. With a focus on helping you make informed
                  decisions, we provide detailed information on admission
                  requirements, costs, scholarships, and visa procedures. Our
                  expert team is always on hand to answer any questions and
                  guide you through the process of finding and applying for your
                  dream program. Whether you're looking to enhance your
                  education, expand your cultural horizons, or advance your
                  career, AbroadStudy.pk is here to support you every step of
                  the way.
                </p>
              </div>

              <div class="wrapper">
                <div class="divider div-transparent div-stopper"></div>
              </div>
              <Scholarships :Scholarshipdata="Scholarshipdata" />
              <div class="wrapper">
                <div class="divider div-transparent div-stopper"></div>
              </div>
              <CountryGuide />
              <div class="wrapper">
                <div class="divider div-transparent div-stopper"></div>
              </div>

              <h2 class="text-center"><b>Top Universities</b></h2>
              <p style="font-size: 16px" class="text-center">
                There are 23,627 schools and universities that offer study programs in the world, according to Erudera. This is the world's largest and most updated database of schools and universities available in the world.
              </p>

              <TopUniversities />
              <div class="wrapper">
                <div class="divider div-transparent div-stopper"></div>
              </div>
              <h2 class="text-center"><b>Test Preparations</b></h2>
              <p style="font-size: 16px" class="text-center">
                Here is a compilation of standardized tests that students may be required to take as part of their college or university admissions process.
              </p>
              <div class="container-fluid">
                <div class="row">
                  <TestPreparations />
                </div>
              </div>
              <router-link to="test">
                <button
                  style="
                    background-color: #1ea1f3;
                    color: white;
                    width: 200px;
                    border-radius: 10px;
                  "
                  class="btn mt-4 mb-3 center"
                >
                  See More
                </button>
              </router-link>
              <div class="wrapper">
                <div class="divider div-transparent div-stopper"></div>
              </div>
              <div class="container-fluid">
                <h2 class="text-center">
                  <b>Study Abroad Opportunities for Pakistani Students</b>
                </h2>
                <p style="font-size: 18px">
                  There are many study-abroad opportunities for Pakistani
                  students, including those in the United Kingdom, United
                  States, Canada, Australia, and other European countries. These
                  countries have a strong higher education system and offer a
                  wide range of academic programs at the undergraduate,
                  graduate, and post-graduate levels. Additionally, many of
                  these countries offer scholarships and financial assistance
                  for international students. In addition to traditional Western
                  destinations, many Pakistani students also consider studying
                  in other countries such as Malaysia, Turkey, and China, which
                  have a growing number of English-taught programs, lower
                  tuition fees, and lower cost of living compared to Western
                  countries. It is important for Pakistani students to research
                  and compare the different options available to them, and to
                  consider factors such as academic reputation, program
                  offerings, cost of living, and visa requirements. It is also
                  recommended to seek guidance from educational consultants or
                  advisers and to contact the international offices of
                  universities they are interested in attending.
                </p>
              </div>
            </div>
          </div>
          <div class="col-sm-2">
            <Form />
          </div>
          <div class="col-sm-2">
            <SideAdds :slides="slides" />
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import config from "@/../config";

//import data from '../../data.json'
import test from "@/test.json";
//import Universities from '@/topuniversities.json'
//import countryGuide from '@/country.json'
//import scholarship from '@/latestscholarship.json'
//import ConsultantsImg from '@/TopConsultants.json'
import Adds from "@/components/CorousalSlide";
import SideAdds from "@/components/SideCorousalSlide";
import Form from "@/components/MainForm";
import Consultants from "@/components/TopConsultants";
import Scholarships from "@/components/HomeLatestScholarships";
import CountryGuide from "@/components/TopGuideCard";
import TopUniversities from "@/components/TopUniversities";
import TestPreparations from "@/components/TestCard";
import ads from '../../data.json'

export default {
  props: ["toggle"],
  data() {
    return {
      from_page: "home",
      ConsultantsData: [
        {
          CompanyName: "Company Name",
          Conatctno: "",
          Email: "",
          Address: "",
          City: "",
          websitelink: "",
          companylogo: "",
          consultancyservices: "",
          services: "",
          Detail: "",
          Password: "",
          statuscheck: "",
          Phoneno: "",
          Personname: "",
          companylogobase64:
            "https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY",
          mapaddress: "",
          id: "",
        },
      ],
      Scholarshipdata: [
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
            "https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY",
          totalreviewscount: "",
          totalusercount: "",
          averagecount: "",
          expiretime: "",
          activatetime: "",
          activatedate: "",
          expiredates: "",
        },
      ],
      countryImg: [
        {
          id: "",
          Country_Name: "Country Name",
          CountryLogo_Ipfs:
            "https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY",
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
            "https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY",
        },
      ],
      test: test,
      maindata: "",
      slides: [{ img1: "", img2: "", img3: "" }],
      start_1_min: 1,
      start_1_max: 4,
    };
  },
  components: {
    Adds,
    SideAdds,
    Form,
    Consultants,
    Scholarships,
    CountryGuide,
    TopUniversities,
    TestPreparations,
  },
  async mounted() {
    //console.log("home")
    this.from_page = "home";

    this.slides = ads;


    //For endpoint use the Below one (Just remove the Multi-comment only), For Local use the above line
   /*


    //console.log("testing3")
    await this.axios.get(config.json_Api + "ads").then(async (response) => {
      //console.log("fetching Data from the internet")
      this.slides = await response.data;
      //console.log("sabar ka paimana test naa kro hamara")
      //console.log(response)
    });


    */



    //not by email just all  scholarship data(image,date,title and shortdescripton) each and every scholarship must be retrieve and storeed below value

    //not by email just all  University data(image,universityname) each and every university must be retrieve and storeed below value

    await this.axios
      .put(config.hostname + "api/ViewsCounter/Mainpageviewsupdate/")
      .then((response) => {
        //console.log("testing12")
        response;
        ////console.log(response.data)
      });
    // await this.axios.get(config.json_Api+'ads')
    // .then((response) => {
    // 	//console.log("fetching Data from the internet")
    // // this.data = response.data
    // //console.log(response)
    // 	})
    //console.log("hello muneeb")
    ////console.log(this.maindata)

    //console.log("testing4")
  },
};
</script>
