<template> 
    <div class="main-card mb-3 card">
        <div class="card-body">
        <h3><b>Change Password</b></h3>
        <form class="mt-4">
        <div class="position-relative row form-group"><label for="exampleEmail" class="col-sm-2 col-form-label">Current Password</label>
        <div class="col-sm-10"><input name="password" id="Passwords" placeholder="Current Password" type="text" class="form-control"></div>
        </div>
        <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-2 col-form-label">New Password</label>
        <div class="col-sm-10"><input name="password" id="newPasswords" placeholder="New Password" type="text" class="form-control"></div>
        </div>
        <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-2 col-form-label">Confirm New Password</label>
        <div class="col-sm-10"><input name="password" id="connewPasswords" placeholder="Confirm New Passowrd" type="text" class="form-control"></div>
        </div>
        <div class="position-relative row form-check mt-3">
        <div class="col-sm-7 offset-sm-5">
        <button v-on:click.prevent="changepass" class="btn btn-secondary">Submit</button>
        </div>
        </div>
        </form>
        </div>
    </div>
</template>
<script>
import config from '@/../config'

export default {
    props: ['emails'],
    data () {
        return {
            Email:"",
            Password:"",
            newPassword: "",
            token:""
        }
    },
    methods: {
        async changepass () {
            this.token= localStorage.getItem("token");
            this.Passwords = document.getElementById('Passwords').value
            this.newPasswords = document.getElementById('newPasswords').value
            this.connewPasswords= document.getElementById('connewPasswords').value
            if(this.newPasswords != null && this.newPasswords == this.connewPasswords && this.newPasswords != "" && this.newPasswords !="" &&this.connewPasswords!=""){
            //////console.log(this.Passwords,this.emails,this.newPasswords,this.connewPasswords)
            this.Email = this.emails
            //////console.log(this.Email)
            this.axios.put(config.hostname+'api/Consultantinfo/PutbyPassword/',{
                Email:this.Email,
                password:this.Passwords,
                newpassword:this.newPasswords
            },
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
              .then((response) => {
                //Alert for Change Pass Verification
                alert(response.data)
                 })
            }
            else{
                alert("All Fields are Required or Password Doesn't Match")
            }
        }
    }
}
</script>
