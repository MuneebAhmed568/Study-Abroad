<template>
  
  <div id="app">
    
    <!-- <loader v-if="loade==true" object="#ff9633" color1="#ffffff" color2="#17fd3d" size="5" speed="2" bg="#343a40" objectbg="#999793" opacity="80" name="loading">
    </loader> -->
    <header class="main-header header-2">
      <!-- START TOP AREA -->
     
      <!-- END TOP AREA -->
      <!-- START LOGO AREA -->
      <div class="p-3">
        <div class="container-fluid">
          <div class="row">
            <div class="col-lg-4 col-md-3 col-sm-6 col-7 mx-auto pl-0 mb-lg-0">
              <div class="logo">
                <router-link to="/">
                <img class="img-fluid" src="../public/assets/img/logo.png" style="height:100px;width:200px" alt="">
                </router-link>
              </div>
            </div>
            <!-- end col -->
            <div class="col-lg-8 col-md-12 col-sm-12 col-12">
              <div class="" style="text-align: center;background-color:white">
                <div class="">
                  <div class="col-sm-12"  v-for="slide in slides.slice(0,1)" :key="slide">
                        <a href="">
                            <div
                            id="carouselExampleIndicators"
                            class="carousel slide"
                            data-ride="carousel">
                                <div class="carousel-inner" style="border-radius:10px">
                                    <div class="carousel-item active">
                                        <div class="d-block w-100">
                                            <img :src="slide.img1" style="height:100px" class="w-100">
                                        </div>
                                    </div>
                                    <div class="carousel-item">
                                        <div class="d-block w-100">
                                            <img :src="slide.img1" style="height:100px" class="w-100" >
                                        </div>
                                    </div>
                                    <div class="carousel-item">
                                        <div class="d-block w-100">
                                            <img :src="slide.img1" class="w-100" style="height:100px">
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>
              </div>
            </div>
            <!-- end col -->
          </div>
        </div>
      </div>
        <!-- END LOGO AREA -->
      <!-- START NAVIGATION AREA -->
      <div class="sticky-menu" style="index:0">
        <nav class="mainmenu-area navbar-expand-sm justify-content-left">
          <div class="container-fluid">
            <div style="margin:auto;text-align:center">
                    <button style="border:1px solid white !important" class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#collapsibleNavbar">
                      <i style="color:white !important" class="fa fa-bars"></i>
                    </button>
                  </div>
            <div class="collapse navbar-collapse" id="collapsibleNavbar" style="padding:0px 0px">
              <div class="">
                  <ul class="navbar-nav">
                    <li class="nav-item"><router-link to="/" class="nav-link head-link">Home</router-link></li>
                    <li class="nav-item"><router-link to="/aboutus" class="nav-link head-link">About</router-link></li>
                    <li class="nav-item"><router-link to="/guide" class="nav-link head-link">Study Destinations</router-link></li>
                    <li class="nav-item"><router-link to="/scholarship" class="nav-link head-link">Scholarship</router-link></li>
                    <li class="nav-item"><router-link to="/university" class="nav-link head-link">Universities</router-link></li>
                    <li class="nav-item"><router-link to="/courses" class="nav-link head-link">Courses</router-link></li>
                    <li class="nav-item"><router-link to="/embassy" class="nav-link head-link">Embassy</router-link></li>
                    <li class="nav-item"><router-link to="/Consultant" class="nav-link head-link">Consultant</router-link></li>
                    <li class="nav-item"><router-link to="/test" class="nav-link head-link">Test</router-link></li>
                    <li class="nav-item"><router-link to="/studyads" class="nav-link head-link">Study Ads</router-link></li>
                    <li class="nav-item"><router-link to="/news" class="nav-link head-link">News</router-link></li>
                    <li class="nav-item"><router-link to="/faqs" class="nav-link head-link">FAQs</router-link></li>
                    <li class="nav-item"><router-link to="/blog" class="nav-link head-link">Blogs</router-link></li>
                    <li class="nav-item"><router-link to="/videos" class="nav-link head-link">Videos</router-link></li>
                  </ul>
              </div>
              <div class="" style="margin-left:auto">
                <div class="dropdown">
                  <button v-if="login" onclick="myFunction()" class="dropbtn"> SignIn/SignUp <i class="fa fa-angle-down"></i></button>
                  <button v-if="dashboard" onclick="myFunction()" class="dropbtn" > Profile <i class="fa fa-angle-down"></i></button>

                  <div id="myDropdown" class="dropdown-content">
                  <ul>
                    <li v-if="login"><a data-toggle="modal" data-target="#myModal"  style="color:#1ea1f3" class="icofont icofont-login">SignIn </a></li>
                    <li v-if="dashboard"><a v-on:click="toDashboard" style="color:#1ea1f3" class="icofont  icofont-login"> {{this.email}} </a></li>
                    <li v-if="login"><a data-toggle="modal" data-target="#myModal1" style="color:#1ea1f3" class="icofont icofont-user-alt-5"> Sign Up </a></li>
                    <li v-if="dashboard"><a v-on:click="tologout" style="color:#1ea1f3" class="icofont icofont-login"> Logout </a></li>
                  </ul>
                  </div>
                </div>
              </div> 
            </div>
        </div>
      </nav>
      </div>
      <!-- END NAVIGATION AREA -->	
    </header>
    <!--login toggle -->
    <div class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog">
      <!-- Modal content-->
      <div class="modal-content" style="padding:10px">
        <div class="modal-header" style="border:none;height:45px">
          <h4 class="modal-title" style="float:left">Login</h4>
          <button type="button" class="close" data-dismiss="modal">&times;</button>
        </div>
        <div class="modal-body">
		  <h5>Email</h5>
		  					<div class="input-group mb-3 mt-4" style=";box-shadow:0 2px 5px 1px #403c4329;">
						<input type="text"  v-model="email" class="form-control" placeholder="Email Address" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
					</div>
		  <h5>Password</h5>
		  					<div class="input-group mb-3 mt-4" style=";box-shadow:0 2px 5px 1px #403c4329;">
						<input type="password" v-model="password" class="form-control" placeholder="Email Password" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
					</div>
        </div>
        <div class="" style="border:none;"><center>
			<button v-on:click="logedIn" data-dismiss="modal" style="background-color: #1EA1F3;color:white;padding:10px 70px;border-radius: 10px;width:70%" class="btn mt-4 mb-4">Continue</button>
        </center></div>
      </div>
      
    </div>
  </div>
  <!--Signup toggle -->
  <div class="modal fade" id="myModal1" role="dialog">
    <div class="modal-dialog">
      <!-- Modal content-->
      <div class="modal-content" style="padding:10px">
          <div class="modal-header" style="background:transparent;border:none;height:45px">
            <h4 class="modal-title" style="float:left"> Sign up</h4>
            <button type="button" class="close" data-dismiss="modal">&times;</button>
          </div>
          <div class="modal-body">
            <div class="row mt-2 mb-2">
              <div v-on:click="Onchange($event)" :key="value" class="col-sm-6 mt-2 mb-2 float-left" >
              <input  type="radio"  id="html" name="fav_language" class="float-left mt-1" value="1">
              <label for="Student"><b> &nbsp; Student</b></label>
              </div>
              <div v-on:click="Onchange($event)" :key="value"  class="col-sm-6 mt-2 mb-2 float-left" >
              <input type="radio" id="html"  name="fav_language" class="float-left mt-1" value="2">
              <label for="Student"><b> &nbsp; Consultant</b></label>
              </div>
              <div v-on:click="Onchange($event)" :key="value" class="col-sm-12 mt-2 mb-2 float-left" >
              <input type="radio" id="html"  name="fav_language" class="float-left mt-1" value="3">
              <label for="Student"><b> &nbsp; University / College</b></label>
              </div>
            </div>
            <h6 class="float-left">Full Name</h6>
            <div class="input-group mb-3 mt-1" style="box-shadow:0 2px 5px 1px #403c4329;">
              <input type="text" v-model="fullname" class="form-control" placeholder="Enter Name" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
            </div>
            <h6 class="float-left">Email</h6>
            <div class="input-group mb-3 mt-1" style="box-shadow:0 2px 5px 1px #403c4329;">
              <input type="text" v-model="email" class="form-control" placeholder="Email Address" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
            </div>
            <div v-if="show_radio" class="row mt-2 mb-2">
              <div v-on:click="OnchangeBranch($event)" :key="value" class="col-sm-6 mt-2 mb-2 float-left" >
              <input  type="radio"  id="html1" name="fav" class="float-left mt-1" value="Main">
              <label for="Main"><b> &nbsp; Main Branch</b></label>
              </div>
              <div v-on:click="OnchangeBranch($event)" :key="value"  class="col-sm-6 mt-2 mb-2 float-left" >
              <input type="radio" id="html1"  name="fav" class="float-left mt-1" value="Sub">
              <label for="Sub"><b> &nbsp; Sub Branch</b></label>
              </div>
            </div>
            <div v-if="show_sub">
              <h6 class="float-left">Main Branch Email</h6>
              <div class="input-group mb-3 mt-1" style="box-shadow:0 2px 5px 1px #403c4329;">
                <input type="text" v-model="Sub_Email" class="form-control" placeholder="Email Address" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
              </div>
              <select placeholder="" id="distritcname_" width="auto" style="width:100%;border:;border:1px solid #858c92;border-radius:10px;padding:4px;font-size: 13px">
								<option value="">Select City</option>
								<option v-for="distr in district" :key="distr" :value="distr.District_Id">{{distr.District_Name}}</option>
								
							</select>
            </div>
            <h6 class="float-left">Contact Number</h6>
            <div class="input-group mb-3 mt-1" style="box-shadow:0 2px 5px 1px #403c4329;">
              <input type="text" v-model="phone" class="form-control" placeholder="Enter Contact" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
            </div>
            <h6 class="float-left">Password</h6>
            <div class="input-group mb-3 mt-1" style="box-shadow:0 2px 5px 1px #403c4329;">
              <input type="text" v-model="password" class="form-control" placeholder="Enter Password" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
            </div>
            <h6 class="float-left">Confirm Password</h6>
            <div class="input-group mb-3 mt-1" style="box-shadow:0 2px 5px 1px #403c4329;">
              <input  type="text" v-model="confirmpassword" class="form-control" placeholder="Re-enter Password" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
            </div>
          </div>
          <div class="center" style="border:none;">
            <button v-on:click="Signup" data-dismiss="modal" style="background-color: #1EA1F3;color:white;padding:10px 70px;border-radius: 10px;width:70%" class="btn mt-4 mb-4">Continue</button>
          </div>
      </div>
    </div>
  </div>
     
	<div class="icon-bar">
    <router-link to="/form"><i class="fa fa-wpforms" ></i></router-link>
  </div>
    
  </div>

<div class="background-main">
<div class="background-main-1">
  <router-view :email="email"
  :data="data"/>
</div>
</div>
  <Fotr />
</template>



<script>
import config from '@/../config'
import Fotr from '@/components/FooterMain'
import ads from '../data.json'


  export default {
  components: {
    Fotr
  },
  data () {
    return {
      hover: true,
      value: "",
      fullname: "",
      email: "",
      phone: "",
      password: "",
      confirmpassword: "",
      CompanyName: "",
      Conatctno: "",
      institutename: "",
      Contactno: "",
      login: true,
      dashboard: false,
      raspdata: '',
      numlocal:0,
      addsdata:"",
      data:"",
      slides:"",
      value_branch:"",
      district:"",
      show_radio: false,
      show_sub: false,
      Sub_Email: "",
      // loade: true
    }
  },
  methods: {
    toDashboard() {
       var raspdat = localStorage.getItem('raspdata')
      this.raspdata=raspdat
      if(this.raspdata == 1) {
         
        this.$router.push({path:'/studentdashboard'});
      }
      else if(this.raspdata == 2){
        this.$router.push({path: '/consultantportal'});
      }
       else if(this.raspdata == 4){
         this.$router.push({path: '/portal'});
       }
      else{
        
        this.$router.push({path: '/Universitys'});
      }
    },
    logedIn () {
      localStorage.setItem("emailsession", this.email)
      
      
      this.axios.get(config.hostname+'api/verify_login/' + this.email + '/' +  this.password)
              .then((response) => {
                this.raspdata = response.data.identifier
                localStorage.setItem("raspdata", this.raspdata)

                localStorage.setItem("token",response.data.token)
                if(response.data.identifier == "2")
                {
                  this.login = false
                  this.dashboard = true
                  ////console.log(response.data)
                   this.numlocal=1
                  localStorage.setItem("numlocal", this.numlocal)
                  this.$router.push({path: '/consultantportal'});
                }
                else if(response.data.identifier == "1")
                {
                    this.login = false
                  this.dashboard = true
                   this.numlocal=1
                  localStorage.setItem("numlocal", this.numlocal)
                    this.$router.push({path: '/studentdashboard'});
                }
                else if(response.data.identifier == "3")
                {
                  this.login = false
                  this.dashboard = true
                   this.numlocal=1
                  localStorage.setItem("numlocal", this.numlocal)
                  this.$router.push({path: '/Universitys'});
                }
                 else if(response.data.identifier == "4")
                 {
                   this.login = false
                   this.dashboard = true
                    this.numlocal=1
                  localStorage.setItem("numlocal", this.numlocal)
                   this.$router.push({path: '/portal'});
                 }
                else{
                    alert(response.data)
                }
                 })
    },
    Onchange (event) {
      this.value = event.target.value
      if(this.value == "2"){
        this.show_radio= true;
      }
      else{
        this.show_radio = false;
        this.show_sub = false
      }
      ////console.log(this.value)
    },
    OnchangeBranch (event) {
      this.value_branch = event.target.value
      if(this.value_branch == "Sub"){
        this.show_sub = true
      }
      else{
        this.show_sub = false
      }
      ////console.log(this.value)
    },
    tologout()
    {
                  this.login = true
                  this.dashboard = false
                  this.numlocal=0
                  this.email=""
                  localStorage.removeItem('numlocal')
                  localStorage.setItem('emailsession',"")
                  localStorage.removeItem('raspdata')
                  this.$router.push({name: '/'});
    },
   async Signup() 
    {
      if( this.value_branch == "Main" || this.value_branch == null  || this.value_branch == "")
      {
        this.DistrictSelectValue="0"
      }
      else{
        this.DistrictSelect = document.getElementById("distritcname_");
        
      //console.log(this.DistrictSelect)
			this.DistrictSelectValue = this.DistrictSelect.options[this.DistrictSelect.selectedIndex].value
      }
      if(this.email!="" && this.fullname!= "" && this.password!="" && this.phone!="" &&  this.password == this.confirmpassword && this.value!="" )
      {
      
      await this.axios.get(config.hostname+'api/verify_login/Getbyemail/' + this.email)
                    .then((response) => {
                    this.raspdata = response.data
                    ////console.log("After Check Testing")
                    ////console.log("Value retured is "+this.raspdata)
                      })
                     
                       ////console.log("Value after loop retured is "+this.raspdata)
                if(this.raspdata == '1' || this.raspdata == '2' ||this.raspdata == '3' || this.raspdata == '1' || this.raspdata == '2' ||this.raspdata == '3' || this.raspdata == 1 || this.raspdata == 2 ||this.raspdata == 3)
                {
                  ////console.log("Inside Testing")
                  ////console.log(this.raspdata)
                  alert("email already Registered !! use Different Email !")
                }
                else{
                    
                  if ( this.value == '1') {
                      this.axios.post(config.hostname+'api/studentinfo/', {
                      fullname: this.fullname,
                      email: this.email,
                      Phoneno: this.phone,
                      password: this.password
                    })
                      .then((response) => {
                        alert(response.data)
                      })

                    this.axios.post(config.hostname+'api/verify_login/', {
                      value: this.value,
                      email: this.email,
                      password: this.password
                    })
                      .then((response) => {
                        response
                        //alert(response.data)
                      })

                  }
                  else if (this.value == '2') {
                    this.Conatctno = this.phone
                    //console.log("consultant signup")
                    //console.log(this.Sub_Email,this.DistrictSelectValue,this.value_branch)
                    this.axios.post(config.hostname+'api/Consultantinfo/', {
                    CompanyName: this.fullname,
                    email: this.email,
                    Conatctno: this.Conatctno,
                    password: this.password,
                    Heads_email:this.Sub_Email,
                    District_Id:this.DistrictSelectValue,
                    Branch:this.value_branch 
                     
                  })
                    .then((response) => {
                      alert(response.data)
                    })

                  this.axios.post(config.hostname+'api/verify_login/', {
                    value: this.value,
                    email: this.email,
                    password: this.password
                  })
                    .then((response) => {
                      response
                      //alert(response.data)
                    })
                  }
                  else if (this.value == '3') {
                    this.institutename = this.fullname
                    this.Contactno = this.phone
                    ////console.log(this.Contactno)
                    this.axios.post(config.hostname+'api/Instituteinfo/', {
                    institutename: this.institutename,
                    email: this.email,
                    Contactno: this.Contactno,
                    password: this.password
                  })
                    .then((response) => {
                      alert(response.data)
                    })

                  this.axios.post(config.hostname+'api/verify_login/', {
                    value: this.value,
                    email: this.email,
                    password: this.password
                  })
                    .then((response) => {
                      response
                     // alert(response.data)
                    })
                  }
                  else {
                    ////console.log("Please Select Something")
                  }
     
     }
      }
      else{ 
        alert("All Fields are Required or Password Doesn't Match")
      }
    }
  },
   async mounted () {



    this.slides = ads.ads;


    //For endpoint use the Below one (Just remove the Multi-comment only), For Local use the above line
    /*
    //console.log("testing1",process.env.BASE_URL)
    await this.axios.get(config.json_Api+'ads')
            .then(async (response) => {
                //console.log("fetching Data from the internet")
            this.slides = await response.data
            //console.log("sabar ka paimana test naa kro hamara")
            //console.log(response)
                });


*/ 


//END HERE



    await this.axios.get(config.hostname+'api/District_info/Getall/')
		.then(async (response) => {
			//console.log("fetching Data for countries")
			this.district = await response.data
			//console.log(this.district)
			})            
    if(this.email == ""){
      var emaildata = localStorage.getItem('emailsession')
      var numdata = localStorage.getItem('numlocal')
      if(numdata==1){
        this.login=false
        this.dashboard=true
      }
      else{
        this.login=true
        this.dashboard=false
      }
     
      this.email= emaildata
      ////console.log(this.email)
    }
    else{
      ////console.log("user logged in")
    }
    
    //console.log("testing2")
    //  this.axios.get(config.hostname+'api/Mainaddsinfo/Getall/')
    //                 .then((response) => {
    //                 this.addsdata = response.data
    //                // //console.log(this.addsdata)
    //                   })
    //api/Sponseradds/Getall/
    // await this.axios.get(config.json_Api+'ads')
		// .then((response) => {
		// 	//console.log("fetching Data from the internet")
		// // this.data = response.data
		// //console.log(response)
		// 	})
  // this.loade= false
  
  }
}
</script>
<style>
</style>
