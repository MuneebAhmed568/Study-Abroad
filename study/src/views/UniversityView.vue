<template>
<div >
  <div class="container-fluid" style="padding:50px;">
    <div class="row">
		<div class="col-sm-3 mt-2">
        <div class="card" style="padding:20px">
            <div class="app-sidebar__inner">
              <div v-for="s in graphvalues" :key="s" style="display:none;">
                                
                            <div id="consultantview">{{this.graphvalueconsultant=s.ViewcurrentmonthPagetype1}}</div>
                            <div id="addsview">{{this.graphvalueconsultantads=s.ViewcurrentmonthPagetype2}}</div>
                            <div id="Newsview">{{this.graphvalueconsultantnews=s.ViewcurrentmonthPagetype3}}</div>
                            <div id="Newsview">{{this.graphvalueconsultantsholarship=s.ViewcurrentmonthPagetype4}}</div>
                        </div>
              <div v-for="d in emailsession" :key="d">
            <img :src="d.mainpicurlbase64" class="center mb-3"  style="border-radius:50%;center;height:250px;width:100%">
            <ul style="text-align:center">
              <li>{{this.email}}</li>
              
               <li >{{this.status=d.statuscheck}}</li>
               
            </ul>
            </div>
            <ul class="vertical-nav-menu">
              <li class="text-center"><h5><b>Dashboards</b></h5></li>
            <li v-if="this.status != 'pending'">
            <a @click="togglebar1">
            <i class="metismenu-icon fa fa-user"></i>
            My Profile
            </a>
            </li>
            <li>
            <a  @click="togglebar2" class="">
            <i class="metismenu-icon fa fa-building-o"></i>
            University Profile
            </a>
            </li>
            <li>
            <a @click="togglebar3" class="">
            <i class="metismenu-icon fa fa-key"></i>
            Change Password
            </a>
            </li>
            <!-- <li v-if="this.status != 'pending'">
            <a  @click="togglebar4" class="">
            <i class="metismenu-icon fa fa-users"></i>
            Student Database
            </a>
            </li> -->
            <li v-if="this.status != 'pending'">
            <a @click="togglebar5" class="">
            <i class="metismenu-icon fa fa-plus"></i>
            AddAds/ManageAds
            </a>
            </li>
            <li v-if="this.status != 'pending'">
            <a @click="togglebar6" class="">
            <i class="metismenu-icon fas fa-edit"></i>
           AddNews/ManageNews
            </a>
            </li>
            <!-- <li v-if="this.status != 'pending'">
            <a @click="togglebar7">
            <i class="metismenu-icon fas fa-edit"></i>
             ScholarShips
            </a>
            </li> -->
            </ul>
		</div>
        </div>
        </div>
    <div class="col-sm-9 mt-2">
    <div class="app-main__inner"> 
      <div>
      <Myprofileuni 
            v-if="showmy"
             :toggle="togglebar1"
             :graphvalueconsultant="graphvalueconsultant"
            :graphvalueconsultantads="graphvalueconsultantads"
            :graphvalueconsultantnews="graphvalueconsultantnews"
            :graphvalueconsultantsholarship="graphvalueconsultantsholarship" />
    <UniProfile
            v-if="showcom"
            :toggle="togglebar2"
            :emailsession="emailsession"
            :emails="emaillod"  />
    <ChangePasuni
             v-if="showpass"
            :toggle="togglebar3"
            :emails="emaillod" />
    <Studentdbuni
             v-if="showstudb"
            :toggle="togglebar4"
            :leads="leads" />
    <Youradsuni
             v-if="showads"
            :toggle="togglebar5"
            :emails="emaillod" />
    <Yournewsuni
             v-if="showmanageads"
            :toggle="togglebar6"
            :emails="emaillod" />
    <ScholarShipuni
             v-if="showscholar"
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
import config from '@/../config'
import dataleads from '@/LeadDatabase.json'
import Myprofileuni from '@/components/MyProfileUni'
import UniProfile from '@/components/UniProfile'
import ChangePasuni from '@/components/ChangePassuni'
import Studentdbuni from '@/components/StudentDatabaseuni'
import Youradsuni from '@/components/YourAdsuni'
import Yournewsuni from '@/components/YourNewsuni'
import ScholarShipuni from '@/components/ScholarShipuni'
export default {
  props: ['email'],
  data () {
    return {
      showmy: false,
      showscholar: false,
      showcom: true,
      showpass: false,
      showstudb: false,
      showads: false,
      showmanageads: false,
      leads: dataleads,
      emailsession: [],
      emaillod: this.email,
      status:"",
      image:undefined,
      graphvalueconsultant:0,
            graphvalueconsultantads:0,
            graphvalueconsultantnews:0,
            graphvalueconsultantsholarship:0,
            graphvalues: "",
      
     token:""
    }
  },
  computed: {
  },
	components: {
        Myprofileuni,
        UniProfile,
        ChangePasuni,
        Studentdbuni,
        Youradsuni,
        Yournewsuni,
        ScholarShipuni
  },
 async mounted () {
  this.token=localStorage.getItem("token");
    if(this.email != ""){
       this.axios.get(config.hostname+'api/Instituteinfo/GetbyEmail/'+ this.email,
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
        .then((response) => {
          this.emailsession = response.data 
          
        })    
        // ////console.log(this.emailsession)
         await this.axios.get(config.hostname+'api/ViewsCounter/Getuniversitybyemail/'+ this.email,
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
              .then((response) => {
                 this.graphvalues= response.data  
                 //console.log(this.graphvalues) 
                }) 
    }
    else{
      this.$router.push({name: '/'});
    }
   
  },
  methods: {
    getImage (pic) {
      if(pic!=undefined && pic!=null)
      {
      
   this.image =   pic
      
        // ////console.log(this.image)
      return this.image
     }
       else{
      this.image= 'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY'
      return this.image
    }
      },
    togglebar1 () {
      this.showcom=false
      this.showstudb=false
      this.showpass=false
      this.showads=false
      this.showmanageads=false
      this.showscholar=false
      this.showmy=true
      // ////console.log("my  UNi prfile open")
      // ////console.log(this.showmy)
    },
    togglebar2 () {
      this.showmy=false
      this.showstudb=false
      this.showpass=false
      this.showads=false
      this.showmanageads=false
      this.showscholar=false
      this.showcom=true
      // ////console.log("my Universityprfile open")
      // ////console.log(this.showcom)
      
    },
    togglebar3 () {
      this.showmy=false
      this.showcom=false
      this.showstudb=false
      this.showads=false
      this.showscholar=false
      this.showmanageads=false
      this.showpass=true
      // ////console.log("Uni changepass open")
      // ////console.log(this.showpass)
      // ////console.log(this.status)
      
    },
    togglebar4 () {
      this.showmy=false
      this.showcom=false
      this.showpass=false
      this.showads=false
      this.showmanageads=false
      this.showscholar=false
      this.showstudb=true
      // ////console.log("Uni studb open")
      // ////console.log(this.showstudb)
      
    },
    togglebar5 () {
      this.showmy=false
      this.showcom=false
      this.showpass=false
      this.showstudb=false
      this.showmanageads=false
      this.showscholar=false
      this.showads=true
      // ////console.log("Uni your adss open")
      // ////console.log(this.showads)
      
    },
    togglebar6 () {
      this.showmy=false
      this.showcom=false
      this.showpass=false
      this.showstudb=false
      this.showads=false
      this.showscholar=false
      this.showmanageads=true
      // ////console.log("Uni manage ads open")
      // ////console.log(this.showmanageads)
      
    },
    togglebar7 () {
      this.showmy=false
      this.showcom=false
      this.showpass=false
      this.showstudb=false
      this.showads=false
      this.showmanageads=false
      this.showscholar=true
      // ////console.log("scholarship open")
      // ////console.log(this.showmanageads)
      
    }
  }
}
</script>
