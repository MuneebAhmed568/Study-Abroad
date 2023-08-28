.<template>
  

  <div class="container-fluid" style="padding: 20px 20px;">
    <div class="row">
      <div class="col-sm-8">
        <Adds :from_page="from_page" />

        <div class="card mt-3" style="padding: 20px" v-for="d in datas" :key="d" >
          <div class="single-blog mb-5 wow fadeInUp animated">
            <div align="center" class="mt-2">
              <img
                :src="d.CountryLogo_Ipfs"
                style="width: 50%"
                class=""
              />
              <h2 class="mt-3"><b>{{ d.Country_Name }}</b></h2>
            </div>
          </div>
          <!-- <div align="left">
            <div align="left" class="col-sm-12">
              <p>{{ d.Five_Points }}</p>
            </div>
          </div> -->
          <div v-if="d.Five_Points != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">Five Quick Points About {{d.Country_Name}}:</h3>
              </div>
          </div>
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.Five_Points}}</p>
              </div>
          </div>
          </div>
          <div v-if="d.Location_Geo != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">Location and Geography:</h3>
              </div>
          </div>
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.Location_Geo}}</p>
              </div>
          </div>
           </div>
          <div v-if="d.Climate != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">Climate:</h3>
              </div>
          </div>
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.Climate}}</p>
              </div>
          </div>
           </div>
          <div v-if="d.History_Population != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">History and Population :</h3>
              </div>
          </div>
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.History_Population}}</p>
              </div>
          </div>
           </div>
          <div v-if="d.Society_Culture != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">Society and Culture :</h3>
              </div>
          </div>
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.Society_Culture}}</p>
              </div>
          </div>
           </div>
          <div v-if="d.Economy != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">Economy:</h3>
              </div>
          </div>
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.Economy}}</p>
              </div>
          </div>
           </div>
          <div v-if="d.Government != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">Government:</h3>
              </div>
          </div>      
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.Government}}</p>
              </div>
          </div>
          </div>
          <div v-if="d.Living_Cost != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">Living Conditions & Cost of Living:</h3>
              </div>
          </div>
         
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.Living_Cost}}</p>
              </div>
          </div>
          </div>
          <div v-if="d.Education_System != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">Education System:</h3>
              </div>
          </div>
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.Education_System}}</p>
              </div>
          </div>
        </div>
        <div v-if="d.EducationIn_Country != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">Education in {{d.Country_Name}}:</h3>
              </div>
          </div>
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.EducationIn_Country}}</p>
              </div>
          </div>
        </div>
        <div v-if="d.Structure != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">Structure:</h3>
              </div>
          </div>
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.Structure}}</p>
              </div>
          </div>
        </div>
        <div v-if="d.Local_Control != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">Local Control:</h3>
              </div>
          </div>
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.Local_Control}}</p>
              </div>
          </div>
        </div>
        <div v-if="d.College != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">College:</h3>
              </div>
          </div>
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.College}}</p>
              </div>
          </div>
        </div>
        <div v-if="d.University != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">University:</h3>
              </div>
          </div>
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.University}}</p>
              </div>
          </div>
        </div>
        <div v-if="d.InfoSpecific_Student != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">Information Specific to International Students:</h3>
              </div>
          </div>
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.InfoSpecific_Student}}</p>
              </div>
          </div>
        </div>
        <div v-if="d.ImpGovernment_Agencies != null">  
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">Important {{d.Country_Name}} Government Agencies/Departments:</h3>
              </div>
          </div>
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.ImpGovernment_Agencies}}</p>
              </div>
          </div>
        </div>
        <div v-if="d.Immigration_Visa != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">Immigration and Visas:</h3>
              </div>
          </div>
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.Immigration_Visa}}</p>
              </div>
          </div>
        </div>
        <div v-if="d.MoreInfo_Specialization != null">
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <h3 style="font-weight: bold">More Inforamtion about each Specialization can be found at:</h3>
              </div>
          </div>
          <div class="row" >
              <div class="col-sm-12"  align="left">
                <p>{{d.MoreInfo_Specialization}}</p>
              </div>
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
import Form from "@/components/MainForm";
import Adds from "@/components/CorousalSlide";
import SideAdds from "@/components/SideCorousalSlide";
export default {
  props: ["data"],
  data() { 
    return {
      // slides: this.data,
      datas: undefined,
      countryid: this.$route.params.idguide,
      countr12: this.$route.params.idguide,
      image: undefined,
      Education_System:false,
      from_page:"guide"
    };
  },
  components: {
    Adds,
    SideAdds,
    Form
  },
  created(){
    this.countryid=this.$route.params.idguide;
  },

  async mounted() {
    this.from_page="guide"
    if (this.countryid != "" && this.countryid != undefined) {
      {
        {
          this.$route.params.idguide;
        }
      }
      await this.axios
        .get(config.hostname + "api/countryinfo/Getbyid/" + this.countryid)
        .then((response) => {
          if(response.data.length >0){
          this.datas = response.data;
          //console.log(this.datas)
          }
          else{
            console.log(response,"error")
            this.$router.push({name: 'notFound'});
          }
        });
    } else {
      this.$router.push({ path: "/guide" });
    }
  },
  methods: {
    getImage(pic) {
      this.image =   pic;
      return this.image;
    },
  },
};
</script>