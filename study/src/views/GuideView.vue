<template>
  <!-- <div class="bg-overlay" style="">
    <div class="container-fluid p-5">
      <h3 align="center">Study Abroad Guides for Pakistani Students</h3>
      <div class="row mt-4">
        <div class="col-md-12">
                        <div class="position-relative form-group"><input type="text" id="exampleCustomSelect" name="customSelect" class="custom-input-1" placeholder="Search Here..">
                    </div>
                    </div>
      </div>
      <div class="text-center mt-2">
                <button class="mb-2 mr-2 btn btn-primary"><i class="pe-7s-search"> </i>  Spearch</button>
            </div>
    </div>
  </div> -->
   
 
  <div class="container-fluid" style="padding: 20px 20px;">
    <div class="row">
      <div class="col-sm-8">
        
        <Adds :from_page="from_page" />
        <h2 class="text-center mt-4"><b class="text-center">Guides</b></h2>
        <p class="text-center" style="font-size: 16px">
          We will Guide you in any matter related to going abroad.
        </p>
        <p>
          Every year large number of Pakistanis search for scholarships in
          Australia for Pakistani Students because of latest reforms in their
          visa processing system. Australia Government and universities with
          regular award programs offer large number of scholarships every year
          to international students who wish to study in Australia. Australia
          have large number of universities and higher education colleges
          offering scholarships in different study programs. Students from other
          countries can also take benefit from Australian study loans and
          financial aids. Australian educational institutions follows a strict
          merit guide line for selecting students for scholarships however needy
          students don’t lose hope as Australian universities also offer need
          based scholarships to overseas students as well.
        </p>
        <div style="margin-top: 40px">
          <div class="container-fluid">
            <div class="row">
              <TopsGuide :countryImg="countryImg" />
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
</template>
<script>
import config from "@/../config";
//import SliderImg from '@/SliderImages.json'
import Form from "@/components/MainForm";
import Adds from "@/components/CorousalSlide";
import SideAdds from "@/components/SideCorousalSlide";
import TopsGuide from "@/components/AllGuide";

export default {
  props: ["data"],
  data() {
    return {
      //slides: SliderImg,
      countryImg: [
        {
          id: "",
          Country_Name: "Country Name",
          CountryLogo_Ipfs:
          'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY',
        },
      ],
      from_page:"guide"
    };
  },
  components: {
    Adds,
    SideAdds,
    Form,
    TopsGuide,
  },
  mounted() {
    this.from_page="guide"
    this.axios
      .get(config.hostname + "api/countryinfo/Getallinfo/")
      .then((response) => {
        this.countryImg = response.data;
        ////console.log(this.countryImg)
      });
  },
};
</script>