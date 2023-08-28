<template> 
<div class="col-md-12 col-lg-12">
<div class="main-card mb-3 card">

<div class="card-body">
<div  v-for="d in emailsession" :key="d" >
<div class="app-main__inner">
<form class="">
      
    <h3 class="mb-3"><b>Institute Information</b></h3>
    <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-3 col-form-label">University Name:<i style="color:red">*</i></label>
    <div class="col-sm-9"><input id="institutename" v-model="d.institutename" placeholder="Enter University Name"  class="form-control" required></div>
    </div>
    <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-3 col-form-label">Website:<i style="color:red">*</i></label>
    <div class="col-sm-9"><input id="websitelink" v-model="d.websitelink"  placeholder="Enter Website" class="form-control" required></div>
    </div>
    <div class="position-relative row form-group"><label for="exampleSelect" class="col-sm-3 col-form-label">Select Country</label>
    <div class="col-sm-9">
    <select name="select" id="chkmain" class="form-control">
    <option id="ckh1" value="Select Country">Select Country</option>
    <option id="chk2" value="Pakistan">Pakistan</option>
    <option id="chk3" value="canada">canada</option>
    <option id="chk4" value="India">India</option>
    </select></div>
    </div>
    </form>
</div>

<div class="position-relative row form-group mt-2">
<div class="col-12 mt-2">
 <form method="post">
      <textarea style="width:100%" rows="5" id="Detail" v-model="d.Detail"></textarea>
    </form>
</div>
</div>
<h3 class="mb-3"><b>Contact Information</b></h3>
<div class="position-relative row form-group"><label for="examplePassword" class="col-sm-3 col-form-label">First Name:<i style="color:red">*</i></label>
<div class="col-sm-9"><input id="Firstname" v-model="d.Firstname"  placeholder="First Name"  class="form-control" required></div>
</div>
<div class="position-relative row form-group"><label for="examplePassword" class="col-sm-3 col-form-label">Last Name:<i style="color:red">*</i></label>
<div class="col-sm-9"><input id="Lastname" v-model="d.Lastname"  placeholder="Last Name"  class="form-control" required></div>
 </div>
<div class="position-relative row form-group"><label for="examplePassword" class="col-sm-3 col-form-label">Mobile Number:<i style="color:red">*</i></label>
<div class="col-sm-9"><input id="Contactno" v-model="d.Contactno"  placeholder="Enter Mobile Number" class="form-control" required></div>
 </div>
<div class="position-relative row form-group"><label for="exampleEmail" class="col-sm-3 col-form-label">Designation:<i style="color:red">*</i></label>
<div class="col-sm-9"><input id="Designation" v-model="d.Designation" name="email"  placeholder="Enter Your Designation" type="email" class="form-control" required></div>
</div>
<div class="position-relative row form-group mt-2"><label for="exampleFile" class="col-sm-2 col-form-label" >Upload Your Cover Logo:</label>
<div class="col-sm-10"><input id="upload-pic-cover" name="files" ref="fileInput" accept="image/*" @change="onFilePicked($event)" type="file" class="form-control-file" required>
<br>
</div>
</div>
<div class="position-relative row form-group mt-2"><label for="exampleFile" class="col-sm-2 col-form-label" >Upload Your Company Logo:</label>
<div class="col-sm-10"><input id="upload-pic-logo" name="file" ref="fileInput" accept="image/*" @change="onFilePicked1($event)" type="file" class="form-control-file" required>
</div>
</div>
<div class="position-relative row form-check">
<div class="col-sm-2 offset-sm-5 mt-4">
</div>
</div>
<h3 class="mb-3 mt-4"><b>WorldWide University Ranking</b></h3>
<div class="position-relative row form-group"><label for="examplePassword" class="col-sm-3 col-form-label">QS World Ranking:<i style="color:red">*</i></label>
<div class="col-sm-9"><input id="Qsworldranking" v-model="d.Qsworldranking"  placeholder="Type Here"  class="form-control" type="text" required></div>
 </div>
<div class="position-relative row form-group"><label for="exampleEmail" class="col-sm-3 col-form-label">Forbest Ranking:<i style="color:red">*</i></label>
<div class="col-sm-9"><input id="Forbestranking" v-model="d.Forbestranking" placeholder="Type Here"  class="form-control" type="text" required></div>
</div>
<div class="position-relative row form-group"><label for="examplePassword" class="col-sm-3 col-form-label">Times Higher Education Ranking:<i style="color:red">*</i></label>
<div class="col-sm-9"><input id="Timeshighereducationranking" v-model="d.Timeshighereducationranking" placeholder="Type Here"  class="form-control" type="text" required></div>
 </div>
<div class="position-relative row form-check">
<div class="col-sm-2 offset-sm-5">
</div>
</div>
        <h3 class="mb-3 mt-4"><b>Location</b></h3>
		<div class="position-relative row form-group"><label for="examplePassword" class="col-sm-3 col-form-label">Location Title:<i style="color:red">*</i></label>
			<div class="col-sm-9">
				<input id="Locationtitle" v-model="d.Locationtitle" placeholder="Provide a title for this university location"  class="form-control" type="text" required>
			</div>
		</div>
		<div class="position-relative row form-group"><label for="examplePassword" class="col-sm-3 col-form-label">Location Country:<i style="color:red">*</i></label>
			<div class="col-sm-9"><input id="Locationcountry" v-model="d.Locationcountry" placeholder="Type Country"  class="form-control" type="text" required></div>
		</div>
		<div class="position-relative row form-group">
			<label for="exampleEmail" class="col-sm-3 col-form-label">Location City:<i style="color:red">*</i></label>
			<div class="col-sm-9"><input id="Locationcity" v-model="d.Locationcity" placeholder="Type City"  class="form-control" type="text" required></div>
		</div>
		<div class="position-relative row form-group">
			<label for="exampleEmail" class="col-sm-3 col-form-label">Full Address:<i style="color:red">*</i></label>
			<div class="col-sm-9"><input id="Fulladdress" v-model="d.Fulladdress" placeholder="Type Address"  class="form-control" type="text" required></div>
		</div>
		<div class="position-relative row form-check">
			<div class="col-sm-2 offset-sm-5">
				<button v-on:click.prevent="updateinfo" class="btn btn-secondary">Updata Data</button>
			</div>
		</div>
</div>
</div>
</div>
</div>
</template>
<script>
import config from '@/../config'
import { create } from 'ipfs-http-client';
import { Buffer } from 'buffer';
export default {
    props: ['toggle','emailsession','emails'],
    data () {
        return {
            file:"",     //logo
            files:"",
            
            
            projectId: '2DBOP6lMpJJXMfPYTHHbUprAtAA',
            projectSecret : 'c47db02a18967d4b6b1758b83a53ffb8',
            token:""
        }
    },
    mounted () { 
      this.token=localStorage.getItem("token");
       
    },
    methods: {
      async uploadToIpfs(file){
        
        const auth ='Basic ' + Buffer.from(this.projectId + ':' + this.projectSecret).toString('base64')

        const client = await create({
            host: 'ipfs.infura.io',
            port: 5001,
            protocol: 'https',
            headers: {
            authorization: auth
            }
        })
        const added = await client.add(file)
        const url = `https://abroadstudy.infura-ipfs.io/ipfs/${added.path}`
        return url
    }, 
        async updateinfo() {
          
            var select = document.getElementById("chkmain");
            var selectedValue = select.options[select.selectedIndex].value
            ////console.log("Email is  : "+ this.emails)
            this.instname = document.getElementById('institutename').value
            this.web = document.getElementById('websitelink').value
            this.contno = document.getElementById('Contactno').value
            this.detail = document.getElementById('Detail').value
            this.fname = document.getElementById('Firstname').value
            this.lname = document.getElementById('Lastname').value
            this.design = document.getElementById('Designation').value
            this.qrank = document.getElementById('Qsworldranking').value
            this.frank = document.getElementById('Forbestranking').value
            this.trank = document.getElementById('Timeshighereducationranking').value
            this.ltitle = document.getElementById('Locationtitle').value
            this.lcountry = document.getElementById('Locationcountry').value
            this.lcity = document.getElementById('Locationcity').value
            this.address = document.getElementById('Fulladdress').value    
            if(this.selectedValue != "" && this.instname!= "" && this.web!= "" && this.contno!= "" && this.detail!= "" && this.fname!= "" && this.lname!= "" && this.design!= "" && this.qrank!= "" && this.frank != "" && this.trank != "" && this.ltitle != "" && this.lcountry != "" && this.lcity != "" && this.address != "")
            {
                      
            await this.axios.put(config.hostname+'api/Instituteinfo/Putbyemail/', {
            institutename: this.instname,
            country: selectedValue,
            websitelink: this.web,
            Email: this.emails,
            Detail: this.detail,
            Firstname: this.fname,
            Lastname: this.lname,
            Designation: this.design,
            Qsworldranking: this.qrank,
            Forbestranking: this.frank,
            Timeshighereducationranking: this.trank,
            Locationtitle: this.ltitle,
            Locationcountry: this.lcountry,
            Locationcity: this.lcity,
            Fulladdress: this.address,
            Contactno: this.contno
            
        },
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
          .then((response) => {
            alert(response.data)
          })
          var url= await this.uploadToIpfs(this.file);
            //console.log("Url from Ads Uni");
            //console.log(url);
         ////console.log(this.file)
          if(this.file != ""){
             const fd =new FormData()
            fd.append("email",this.emails)
            fd.append('Coverpicurlbase64', url)
            ////console.log(fd)
            await this.axios.post(config.hostname+'api/Instituteinfo/savepiccover/',fd,
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
            .then(res => {
              res
                //alert(res.data)
            })
          }
          var url2= await this.uploadToIpfs(this.files);
            //console.log("Url from Ads Uni");
            //console.log(url2);
        ////console.log(this.files)
          if(this.files != ""){
             const fd =new FormData()
            fd.append("email",this.emails)
            fd.append('mainpicurlbase64', url2)
            ////console.log(fd)
            await this.axios.post(config.hostname+'api/Instituteinfo/savepicmain/',fd,
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
            .then(res => {
              res
               // alert(res.data)
            })
          }
            }else
            {
              alert("All Fields are Required!")
            }
        },
        onPickFile () {
                this.$refs.fileInput.click()
        },
        onFilePicked (event) {//coverpic
        this.file = event.target.files[0]
        },onFilePicked1 (event) {//mainpic
        this.files = event.target.files[0]
        }
    }
}
</script>
