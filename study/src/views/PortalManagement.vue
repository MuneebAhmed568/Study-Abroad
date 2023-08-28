<template>
<div >
  <div class="container-fluid" style="padding:50px;">
    <div class="row">
		<div class="col-sm-3 mt-2">
        <div class="card" style="padding:20px">
            <div class="app-sidebar__inner">
              <div v-for="d in emailsession" :key="d">
              <ul>
                <li>{{this.email}}</li>
                
              </ul>
            </div>
            <ul class="vertical-nav-menu">
            <li class="text-center"><h5><b>Dashboards</b></h5></li>



            <li v-if="this.status != 'pending'">
            <a @click="togglebar1">
              <i class="metismenu-icon fa fa-user"></i>
            Student Approval
            </a>
            </li>



            <li>
            <a  @click="togglebar2">
              <i class="metismenu-icon fa fa-user"></i>
            Consultant Approval
            </a>
            </li>
            <li>
            <a @click="togglebar3">
              <i class="metismenu-icon fa fa-user"></i>
            University Approval
            </a>
            </li>
            <li v-if="this.status != 'pending'">
            <a  @click="togglebar4">
              <i class="metismenu-icon fa fa-user"></i>
            Blogs
            </a>
            </li>
           <!--  <li v-if="this.status != 'pending'">
            <button @click="togglebar5" class="metismenu-icon fa fa-newspaper-o">
            <i ></i>
            New's Approval
            </button>
            </li>
            <li v-if="this.status != 'pending'">
            <button @click="togglebar6" class="metismenu-icon fas fa-graduation-cap">
            Scholarship's Approval
            </button>
            </li> -->
            <li v-if="this.status != 'pending'">
            <a @click="togglebar7">
              <i class="metismenu-icon fa fa-user"></i>
            Ad's Approval
            </a>
            </li>
            </ul>
		</div>
        </div>
        </div>
    <div class="col-sm-9 mt-2">
    <div class="app-main__inner"> 
      <div>
      <Studentapproval 
            v-if="showmy"
             :toggle="togglebar1"
             :leads="leads" />
    <Consultantapproval
            v-if="showcom"
            :toggle="togglebar2"
            :emailsession="emailsession"  />
    <Universityapproval
             v-if="showpass"
            :toggle="togglebar3"
            :emails="emaillod" />
    <Blogapproval

             v-if="showstudb"
            :toggle="togglebar4"
            :emails="emaillod" />
    <!-- <NewsApproval
             v-if="showads"
            :toggle="togglebar5"
            :emails="emaillod" />
    <Scholarshipapproval
             v-if="showmanageads"
            :toggle="togglebar6"
            :emails="emaillod" /> -->
            <AdsManage
             v-if="showaddads"
            :toggle="togglebar7"
            :emails="emaillod" />
      </div>
      </div>
      </div>
    </div>
    </div>
  </div> 
</template>
<script>
//import config from '@/../config'
// import dataleads from '@/LeadDatabase.json'
import AdsManage from '@/components/AddsManagement.vue'
import Studentapproval from '@/components/StudentApproval'
import Consultantapproval from '@/components/ConsultantApproval'
import Universityapproval from '@/components/UniversityApproval'
import Blogapproval from '@/components/BlogApproval'
export default {
  props: ['email'],
  data () {
    return {
      showmy: false,
      showcom: true,
      showpass: false,
      showstudb: false,
      showads: false,
      showmanageads: false,
      showaddads: false,
      // leads: dataleads,
      emailsession: [{"CompanyName":"","Conatctno":"","Email":"","Address":"","City":"","websitelink":"","companylogo":"","consultancyservices":"","services":"","Detail":"","Password":"","statuscheck":"","Phoneno":"","Personname":"","companylogobase64":"","mapaddress":"","id":""}],
      emaillod: this.email,
      status:"",
      image:undefined,
      
     token:""
    }
  },
  computed: {
  },
	components: {
        Studentapproval,
        Consultantapproval,
        Universityapproval,
        Blogapproval,
        AdsManage
  },
  mounted () {
    this.token= localStorage.getItem("token");
     if(this.email != ""){
            ////console.log("")
        }
        else{
      this.$router.push({name: '/'});
    }
      
  },
  methods: {
    
    togglebar1 () {
      this.showcom=false
      this.showstudb=false
      this.showpass=false
      this.showads=false
      this.showmanageads=false
      this.showaddads=false
      this.showmy=true
      //////console.log("my prfile open")
      //////console.log(this.showmy)
    },
    togglebar2 () {
      this.showmy=false
      this.showstudb=false
      this.showaddads=false
      this.showpass=false
      this.showads=false
      this.showmanageads=false
      this.showcom=true
      // ////console.log("my companyprfile open")
      // ////console.log(this.showmy)
      
    },
    togglebar3 () {
      this.showmy=false
      this.showcom=false
      this.showstudb=false
      this.showads=false
      this.showmanageads=false
      this.showaddads=false
      this.showpass=true
      // ////console.log("my changepass open")
      // ////console.log(this.showmy)
      // ////console.log(this.status)
      
    },
    togglebar4 () {
      this.showmy=false
      this.showcom=false
      this.showpass=false
      this.showads=false
      this.showmanageads=false
      this.showstudb=true
      // ////console.log("studb open")
      // ////console.log(this.showmy)
      
    },
    togglebar5 () {
      this.showmy=false
      this.showcom=false
      this.showpass=false
      this.showstudb=false
      this.showmanageads=false
      this.showaddads=false
      this.showads=true
      // ////console.log("your adss open")
      // ////console.log(this.showads)
      
    },
    togglebar6 () {
      this.showmy=false
      this.showcom=false
      this.showpass=false
      this.showstudb=false
      this.showads=false
      this.showaddads=false
      this.showmanageads=true
      // ////console.log("manage ads open")
      // ////console.log(this.showmanageads)
      
    },
    togglebar7 () {
      this.showmy=false
      this.showcom=false
      this.showpass=false
      this.showstudb=false
      this.showads=false
      this.showmanageads=false
      this.showaddads=true
      // ////console.log("manage ads open")
      // ////console.log(this.showmanageads)
      
    }
  }
}
</script>
