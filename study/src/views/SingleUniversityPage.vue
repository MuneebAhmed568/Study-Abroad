.<template>


<div class="container-fluid" style="padding: 20px 20px;">
    <div class="row">
      <div class="col-sm-8">
        <Adds :from_page="from_page" />
        <div class="card mt-3" v-for="d in datas" :key="d"  style="padding: 20px">
          <div style="text-align:center" class="single-blog mb-3 wow fadeInUp animated">
            <img
              :src="d.mainpicurlbase64"
              style="border-radius: 100%; width: 50%;height:auto"
              class=""
            />
          </div>
          <div align="center" class="mt-2">
              <h2 class=""><b>{{ d.institutename }}</b></h2>
            </div>
          <div align="left">
            <div align="left" class="col-sm-12">
              <p>{{ d.Detail }}</p>
            </div>
            <h5 class="mt-3">Services Countries :</h5>
            <div align="left" class="col-sm-12">
              {{ d.country }}
            </div>
            <h5 class="mt-3">QS World Ranking :</h5>
            <div align="left" class="col-sm-12">
              <span style="color: #1ea1f3; font-size: 17px">{{
                d.Qsworldranking
              }}</span>
            </div>
            <h5 class="mt-3">For Best Ranking :</h5>
            <div align="left" class="col-sm-12">
              <span style="color: #1ea1f3; font-size: 17px">{{
                d.Forbestranking
              }}</span>
            </div>
            <h5 class="mt-3">Times Higher Education Ranking :</h5>
            <div align="left" class="col-sm-12">
              <span style="color: #1ea1f3; font-size: 17px">{{
                d.Timeshighereducationranking
              }}</span>
            </div>
            <h5 class="mt-3">Ratings :</h5>
            <div align="left" class="col-sm-12">
              <form class="rating">
                <input type="radio" id="star5" name="rating" value="5" /><label
                  for="star5"
                  title="Super !!"
                ></label>
                <input type="radio" id="star4" name="rating" value="4" /><label
                  for="star4"
                  title="Geil"
                ></label>
                <input type="radio" id="star3" name="rating" value="3" /><label
                  for="star3"
                  title="Gut"
                ></label>
                <input type="radio" id="star2" name="rating" value="2" /><label
                  for="star2"
                  title="So gut wie"
                ></label>
                <input type="radio" id="star1" name="rating" value="1" /><label
                  for="star1"
                  title="Schlecht"
                ></label>
              </form>
            </div>
            <br /><br />
            <h5>Overall Rewiews</h5>
            <div align="left" class="col-sm-12">
              <span style="color: #1ea1f3; font-size: 17px">{{
                d.averagecount
              }}</span>
            </div>
            <h5 class="mt-3">Contact Details :</h5>
            <div align="left" class="col-sm-12">
              <div class="row">
                <div class="col-sm-3">
                  <h6>Email :</h6>
                </div>
                <div class="col-sm-9">
                  <label>{{ d.email }}</label>
                </div>
              </div>
              <div class="row">
                <div class="col-sm-3">
                  <h6>Website :</h6>
                </div>
                <div class="col-sm-9">
                  <label>{{ d.websitelink }}</label>
                </div>
              </div>
              <div class="row">
                <div class="col-sm-3">
                  <h6>Contact Number :</h6>
                </div>
                <div class="col-sm-9">
                  <label>{{ d.Contactno }}</label>
                </div>
              </div>
              <div class="row">
                <div class="col-sm-3">
                  <h6>University Address :</h6>
                </div>
                <div class="col-sm-9">
                  <label>{{ d.Fulladdress }}</label>
                  <label>{{ d.Locationtitle }}</label>
                  <label>{{ d.Locationcountry }}</label>
                </div>
              </div>

              <div class="mt-2">
                <div id="gmap-example"></div>
              </div>
            </div>
            <div align="center" class="col-sm-12 mt-3">
              <button
                v-on:click.prevent="postToController"
                class="btn btn-secondary"
              >
                Submit
              </button>
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
      emails: this.$route.params.emailid,
      image: undefined,
      ratingValue: "",
      from_page:"university"

    };
  },
  components: {
    Adds,
    SideAdds,
    Form

  },
  mounted() {
    this.from_page="university"

    if (this.emails != "" && this.emails != undefined) {
      {
        {
          this.$route.params.emailid;
        }
      }
      this.axios
        .get(config.hostname + "api/instituteinfo/Getbyemail/" + this.emails)
        .then((response) => {
          if(response.data.length >0){
          this.datas = response.data;
        }
          else{
           // console.log(response,"eeroor")
            this.$router.push({name: 'notFound'});
          }
          ////console.log(this.data)
        });
      this.axios
        .put(
          config.hostname + "api/ViewsCounter/UniversitySinglepageviewsupdate/",
          {
            Email: this.emails,
          }
        )
        .then((response) => {
          response;
          ////console.log(response.data)
        });
    } else {
      this.$router.push({ path: "/university" });
    }
  },
  methods: {
    getImage(pic) {
      this.image =   pic;
      return this.image;
    },
    async postToController() {
      for (
        this.i = 0;
        this.i < document.getElementsByName("rating").length;
        this.i++
      ) {
        if (document.getElementsByName("rating")[this.i].checked == true) {
          this.ratingValue = document.getElementsByName("rating")[this.i].value;
          break;
        }
      }
      //console.log("working");
      await this.axios
        .put(config.hostname + "api/instituteinfo/Putreviewbyid/", {
          email: this.emails,
          rate: this.ratingValue,
        })
        .then((response) => {
          alert(response.data);
        });
    },
  },
};
</script>