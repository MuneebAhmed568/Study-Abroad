<template>
  


  <div class="container-fluid" style="padding: 20px 20px;">
    <div class="row">
      <div v-for="d in datas" :key="d" class="col-sm-8">
        <Adds :from_page="from_page" />
        <div class="card" style="padding: 20px">
          <div class="single-blog mb-5 wow fadeInUp animated">
            <div align="center" class="mt-2">
              <img
                :src="d.embassylogobase64"
                style="width: 40%"
                class=""
              />
              <h4>{{ d.embassyname }}</h4>
            </div>
          </div>
          <div align="left">
            <div align="left" class="col-sm-12">
              <p>{{ d.detail }}</p>
            </div>
          </div>
          <div class="row">
            <div class="col-sm-3">
              <h6>Date :</h6>
            </div>
            <div class="col-sm-9">
              <label>{{ d.dates }}</label>
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
      id: this.$route.params.idname,
      datas: "",
      image: undefined,
      from_page:"guide"

    };
  },
  components: {
    Adds,
    SideAdds,
    Form

  },

  mounted() {
    this.from_page="guide"

    ////console.log(this.$route.params)
    if (this.id != "" && this.id != undefined) {
      {
        {
          this.$route.params.emailid;
        }
      }
      this.axios
        .get(config.hostname + "api/embassyinfo/Getbyid/" + this.id)
        .then((response) => {
          this.datas = response.data;
        });
    } else {
      this.$router.push({ path: "/embassy" });
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