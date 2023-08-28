<template>
  
  
  <div class="container-fluid" style="padding: 20px 20px;">
    <div class="row">
      <div class="col-sm-8">
        <Adds :from_page="from_page" />
        <div  v-for="d in datas" :key="d"   class="card" style="padding: 20px">
          <div class="single-blog mb-5 wow fadeInUp animated">
            <div align="center" class="mt-2">
              <img
                :src="d.imageurlbase64"
                style="border-radius: 100%; height: auto; width: 30%"
                class=""
              />
              <h4>{{ d.Title }}</h4>
            </div>
          </div>
          <div align="left">
            <div align="left" class="col-sm-12">
              <p>{{ d.Detail }}</p>
            </div>
            <h5 class="mt-3">Services Countries :</h5>
            <div align="left" class="col-sm-12">
              {{ d.Country }}
            </div>
            <h5 class="mt-3">Education Levels :</h5>
            <div align="left" class="col-sm-12">
              {{ d.Educationlevel }}
            </div>

            <h5 class="mt-3">Contact Details :</h5>
            <div align="left" class="col-sm-12">
              <div class="row">
                <div class="col-sm-3">
                  <h6>Email :</h6>
                </div>
                <div class="col-sm-9">
                  <label>{{ d.Email }}</label>
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
      mainEmail: this.$route.params.mainemail,
      from_page:"studyads"

    };
  },

 async mounted() {
    this.from_page="studyads"

    if (this.id != "" && this.id != undefined) {
      {
        {
          this.$route.params.mainemail;
        }
      }
      {
        {
          this.$route.params.emailid;
        }
      }
      await this.axios
        .get(config.hostname + "api/addsinfo/Getbyid/" + this.id)
        .then((response) => {
          this.datas = response.data;
          ////console.log(this.data)
        });
      await this.axios
        .put(config.hostname + "api/ViewsCounter/AddsSinglepageviewsupdate/", {
          Email: this.mainEmail,
        })
        .then((response) => {
          response;
          ////console.log(response.data)
        });
    } else {
      this.$router.push({ path: "/studyads" });
    }
  },
  methods: {
    getImage(pic) {
      this.image =   pic;
      return this.image;
    },
    ToSinglePage() {
      // this.$router.push({path: '/ConsultantPage', params: { username: email }});
      // this.$router.push({name:'ConsultantPage', params: { param: email } })
      //this.$router.push({name: '/studyadspage', params: { emailid:id}});
    },
  },

  components: {
    Adds,
    SideAdds,
    Form

  },
};
</script>