<template>
<div>
  <div class="container-fluid" style="padding:50px;">
    <div class="row">
		<div class="col-sm-3 mt-2">
        <div class="card" style="padding:20px">
            <div class="app-sidebar__inner">
               <div v-for="s in graphvalues" :key="s" style="display:none;">
                                
                            <div id="consultantview">{{this.graphvalueconsultant=s.ViewcurrentmonthPagetype1}}</div>
                            <div id="addsview">{{this.graphvalueconsultantads=s.ViewcurrentmonthPagetype2}}</div>
                            <div id="Newsview">{{this.graphvalueconsultantnews=s.ViewcurrentmonthPagetype3}}</div>
                        </div>
              <div v-for="d in emailsession" :key="d">
            <img :src="d.companylogobase64" class="center mb-3"  style="border-radius:50%;center;height:250px;width:100%">
            <ul class=" text-center">
              <li>{{this.email}}</li>
              
               <li >{{this.status=d.statuscheck}}</li>
               
            </ul>
            </div>
            <ul class="vertical-nav-menu">
            <li class="app-sidebar__heading text-center"><h5><b>Dashboards</b></h5></li>


            <li v-if="this.status != 'pending'">
            <a @click="togglebar1">
            <i class="metismenu-icon fa fa-user"></i>
            My Profile
            </a>
            </li>
            <li>
            <a  @click="togglebar2">
            <i class="metismenu-icon fa fa-building-o"></i>
            Consultant Profile
            </a>
            </li>
            <li>
            <a @click="togglebar3">
            <i class="metismenu-icon fa fa-key"></i>
            Change Password
            </a>
            </li>
            <li v-if="this.status != 'pending'">
            <a  @click="togglebar4">
            <i class="metismenu-icon fa fa-users"></i>
            Student Database
            </a>
            </li>
            <li v-if="this.status != 'pending'">
            <a @click="togglebar5">
            <i class="metismenu-icon fa fa-plus"></i>
            AddAds / ManageAds
            </a>
            </li>
            <li v-if="this.status != 'pending'">
            <a @click="togglebar6">
            <i class="metismenu-icon fas fa-edit"></i>
           AddNews/ManageNews
            </a>
            </li>
            </ul>
		</div>
        </div>
        </div>
    <div class="col-sm-9 mt-2">
    <div class="app-main__inner"> 
      <div>
      <Myprofile 
            v-if="showmy"
             :toggle="togglebar1"
             :leads="leads"
             :emailss="emaillod"
             :graphvalueconsultant="graphvalueconsultant"
            :graphvalueconsultantads="graphvalueconsultantads"
            :graphvalueconsultantnews="graphvalueconsultantnews" />
    <Comprofile
            v-if="showcom"
            :toggle="togglebar2"
            :emailsession="emailsession"  />
    <ChangePas
             v-if="showpass"
            :toggle="togglebar3"
            :emails="emaillod" />
    <Studentdb
             v-if="showstudb"
            :toggle="togglebar4"
            :leads="leads"
            :emailsession="emailsession" />
    <Yourads
             v-if="showads"
            :toggle="togglebar5"
            :emails="emaillod" />
    <Yournews
             v-if="showmanageads"
            :toggle="togglebar6"
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
import Myprofile from '@/components/MyProfile'
import Comprofile from '@/components/CompanyProfile'
import ChangePas from '@/components/ChangePass'
import Studentdb from '@/components/StudentDatabase'
import Yourads from '@/components/YourAds'
import Yournews from '@/components/YourNews'
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
      leads: dataleads,
      emailsession: [{"CompanyName":"","Conatctno":"","Email":"","Address":"","City":"","websitelink":"","companylogo":"","consultancyservices":"","services":"","Detail":"","Password":"","statuscheck":"","Phoneno":"","Personname":"","companylogobase64":"","mapaddress":"","id":""}],
      emaillod: this.email,
      status:"",
      image:undefined,
       graphvalueconsultant:0,
            graphvalueconsultantads:0,
            graphvalueconsultantnews:0,
            graphvalues: "",
      
     token:""
    }
  },
  computed: {
  },
	components: {
        Myprofile,
        Comprofile,
        ChangePas,
        Studentdb,
        Yourads,
        Yournews
  },
 async mounted () {
  this.token= localStorage.getItem("token");
    if(this.email != ""){
      await this.axios.get(config.hostname+'api/Consultantinfo/GetbyEmail/'+ this.email,
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
        .then((response) => {
          this.emailsession = response.data 
          console.log(this.emailsession)
        }) 
         await this.axios.get(config.hostname+'api/ViewsCounter/Getconsultantbyemail/'+ this.email,
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
              .then((response) => {
                 this.graphvalues= response.data  
                 ////console.log(this.graphvalues) 
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
      // //////console.log(pic)
      // this.axios.post(config.hostname+'api/Consultantinfo/pickpic/',{
      //   companylogo: pic
      // })
       // .then((response) => {
        this.image =   pic
      //  })   
        ////////console.log(this.image)
      return this.image
    }
    else{
      // //////console.log(pic)
      this.image= 'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY';
      return this.image
    }
    },
    togglebar1 () {
      this.showcom=false
      this.showstudb=false
      this.showpass=false
      this.showads=false
      this.showmanageads=false
      this.showmy=true
      ////console.log(this.graphvalueconsultant)
      ////////console.log("my prfile open")
      ////////console.log(this.showmy)
    },
    togglebar2 () {
      this.showcom=true
      this.showmy=false
      this.showstudb=false
      this.showpass=false
      this.showads=false
      this.showmanageads=false
      //console.log("my companyprfile open")
      //console.log(this.showcom)
      
    },
    togglebar3 () {
      this.showmy=false
      this.showcom=false
      this.showstudb=false
      this.showads=false
      this.showmanageads=false
      this.showpass=true
      // //////console.log("my changepass open")
      // //////console.log(this.showmy)
      // //////console.log(this.status)
      
    },
    togglebar4 () {
      this.showmy=false
      this.showcom=false
      this.showpass=false
      this.showads=false
      this.showmanageads=false
      this.showstudb=true
      // //////console.log("studb open")
      // //////console.log(this.showmy)
      
    },
    togglebar5 () {
      this.showmy=false
      this.showcom=false
      this.showpass=false
      this.showstudb=false
      this.showmanageads=false
      this.showads=true
      // //////console.log("your adss open")
      // //////console.log(this.showads)
      
    },
    togglebar6 () {
      this.showmy=false
      this.showcom=false
      this.showpass=false
      this.showstudb=false
      this.showads=false
      this.showmanageads=true
      // //////console.log("manage ads open")
      // //////console.log(this.showmanageads)
      
    }
  }
}
</script>
