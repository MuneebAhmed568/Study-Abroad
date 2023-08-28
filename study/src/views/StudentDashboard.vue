.<template>
    <div class="container-fluid" style="padding:50px">
        <div class="row">
            <div class="col-sm-3 mt-2">
                <div class="card" style="padding:20px">
                    <div class="app-sidebar__inner">
                        <div v-for="d in emailsession" :key="d">
                       <img :src="d.imageurlbase64" class="center mb-3"  style="border-radius:50%;center;height:250px;width:100%">
                            <ul class="text-center">
                                <li>{{this.email}}</li>
                                
                                <li >{{this.status=d.statuscheck}}</li>
                                
                            </ul>
                        </div>
                        
                        <ul class="vertical-nav-menu">
                          <li class="text-center"><h5><b>Dashboards</b></h5></li>
                            <li>
                                <a @click="togglebar1">
                                <i class="metismenu-icon fa fa-user"></i>
                                My Profile
                                </a>
                            </li>
                            <li v-if="this.status != 'pending'">
                                <a @click="togglebar2">
                                <i class="metismenu-icon fa fa-edit"></i>
                                Study Profile
                                </a>
                            </li>
                            <li >
                                <a @click="togglebar3">
                                <i class="metismenu-icon fa fa-key"></i>
                                Change Password
                                </a>
                            </li>

                        </ul>

                    </div>
                </div>
            </div>
            <div class="col-sm-9 mt-2">
                <div class="app-main__inner">
                    <StudentProfile 
                        v-if="showmyprofile"
                        :emailsession="emailsession"
                        :toggle="togglebar1"
                    />
                    <StudentStudyProfile
                    v-if="showstudyprofile"
                    :toggle="togglebar2"
                    :emailsession="emailsession"
                    :emails="emaillod"  
                    />

                    <ChangePas
                    v-if="showmchangepass"
                    :toggle="togglebar3"
                    :emails="emaillod" 
                    />


                </div>
            </div>

        </div>
    </div>
    
</template>

<script>
import config from '@/../config'
import StudentStudyProfile from '@/components/StudentStudyProfile'
import StudentProfile from '@/components/StudentProfile'
import ChangePas from '@/components/ChangePassStudent'
export default {
    props: ['email'],

    data () {
	return {
       showmyprofile: true,
       showstudyprofile: false,
       showmchangepass: false,
       image:undefined,
       status:"",
       emailsession: [],
       emaillod: this.email,
        token:""
		
	}
  },
	components: {
	StudentStudyProfile,
    StudentProfile,
    ChangePas
	},

    async mounted () 
    {
        this.token= localStorage.getItem("token");
        if(this.email != ""){
            ////console.log(this.email)
    ////console.log("working")
     await this.axios.get(config.hostname+'api/Studentinfo/GetbyEmail/'+ this.email,
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
         .then((response) => {
           this.emailsession = response.data
         
         })   
        }
        else{
      this.$router.push({name: '/'});
    }
     
         
    },

    methods:
    {
    getImage (pic) {
      if(pic!=undefined && pic!=null)
      {   
        this.image =   pic 
      return this.image
    }
    else{
      this.image= 'https://abroadstudy.infura-ipfs.io/ipfs/Qme6iTwd7izSNc6xpxNykYGSmsAVGUNgiZBw3FbotE5DJY'
      return this.image
    }
    },
    togglebar1 () {
      this.showmyprofile=true
      this.showstudyprofile=false
      this.showmchangepass=false
    //   ////console.log("my Student prfile open")
    //   ////console.log(this.showmyprofile)
    },
    togglebar2 () {
      this.showmyprofile=false
      this.showstudyprofile=true
      this.showmchangepass=false
    //   ////console.log("my Student Study prfile open")
    //   ////console.log(this.showstudyprofile)
    },
    togglebar3 () {
      this.showmyprofile=false
      this.showstudyprofile=false
      this.showmchangepass=true
    //   ////console.log("my Student Change Pass open")
    //   ////console.log(this.showmchangepass)
    },

    }

}
</script>
