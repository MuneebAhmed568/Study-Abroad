.<template>
  

  <div class="container-fluid" style="padding: 20px 20px;">
    <div class="row">
      <div  class="col-sm-8">
        <Adds :from_page="from_page" />
        <div class="card mt-3" v-for="d in datas" :key="d" style="padding: 20px">
          <div style="text-align:center" class="mb-3 wow fadeInUp animated">
            <img
              :src="d.imageurlbase64"
              style="border-radius: 100px; height: auto; width: 60%"
              class=""
            />
          </div>
          <div align="center" class="mt-2">
              <h2><b>{{ d.title }}</b></h2>
            </div>
          <div align="left">
            <div align="left" class="col-sm-12">
              <p>{{ d.shortdiscription }}</p>
              <p>{{ d.detail }}</p>
            </div>
            <h5 class="mt-3">Services Countries :</h5>
            <div align="left" class="col-sm-12">
              {{ d.countries }}
            </div>

            <h5 class="mt-3">Contact Details :</h5>
            <div align="left" class="col-sm-12">
              <div class="row">
        
                <div class="col-sm-12">
                  <label ><strong> Please,Fill the form attached above on the page</strong></label>
                </div>
              </div>

              <div class="mt-2">
                <div id="gmap-example"></div>
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
      datas: undefined,
      id: this.$route.params.emailid,
      image: undefined,
      ratingValue: "",
      mainEmail:"",
      from_page:"news"

    };
  },
  components: {
    Adds,
    SideAdds,
    Form

  },
  async mounted() {
    this.from_page="news"

    if (this.id != "" && this.id != undefined) {
      
      {
        {
          this.$route.params.emailid;
        }
      }
      await this.axios
        .get(config.hostname + "api/eventsinfo/Getbyid/" + this.id)
        .then((response) => {
          if(response.data.length >0){

          this.datas = response.data;
          //console.log(this.datas)
          this.mainEmail= this.datas[0].email
        }
          else{
           // console.log(response,"eeroor")
            this.$router.push({name: 'notFound'});
          }
        });
      await this.axios
        .put(config.hostname + "api/ViewsCounter/NewsSinglepageviewsupdate/", {
          Email: this.mainEmail,
        })
        .then((response) => {
          response;
          ////console.log(response.data)
        });
    } else {
      this.$router.push({ path: "/news" });
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