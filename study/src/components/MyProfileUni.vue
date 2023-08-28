<template> 
    <graph 
    :graphinstitutescholarship="graphinstitutescholarship"
    :graphinstituteads="graphinstitutescholarship"
    :graphinstitutenews="graphinstitutenews"
    :graphinstitute="graphinstitute"
    />
    <!-- <div class="col-md-12 col-lg-12">
        <div class="main-card mb-3 card">
            <div class="card-body">
                <h5 class="card-title">Search Filter</h5>
                    <div class="row">
                        <div class="col-md-4">
                            <div @change="onChange($event)" :key="key1" class="position-relative form-group"><label for="exampleCustomSelect" class="">FIND STUDENT EDU LEVEL</label><select type="select" id="exampleCustomSelect" name="customSelect" class="custom-select">
                            <option value="">Select</option>
                            <option value="1">Value 1</option>
                            <option value="2">Value 2</option>
                            <option value="3">Value 3</option>
                            <option value="4">Value 4</option>
                            <option value="5">Value 5</option>
                            </select>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div @change="onChangess($event)" :key="key2" class="position-relative form-group"><label for="exampleCustomSelect" class="">LIVING IN</label><select type="select" id="exampleCustomSelect" name="customSelect" class="custom-select">
                            <option value="">Select</option>
                            <option value="1">Value 1</option>
                            <option value="2">Value 2</option>
                            <option value="3">Value 3</option>
                            <option value="4">Value 4</option>
                            <option value="5">Value 5</option>
                            </select>
                            </div>
                        </div> 
                        <div class="col-md-4">
                            <div @change="onChangesss($event)" :key="key3" class="position-relative form-group"><label for="exampleCustomSelect" class="">INTERESTED IN COUNTRY</label>
                            <select  id="CountryOptions" name="select" class="custom-select">
                            <option id="ckh0" value="All">Select Country</option>
                            <option id="ckh1" value="Austria">Austria</option>
                            <option id="ckh2" value="China">China</option>
                            <option id="ckh3" value="UK">UK</option>
                            <option id="ckh4" value="France">France</option>
                            <option id="ckh5" value="Germany">Germany</option>
                            <option id="ckh6" value="Canada">Canada</option>
                            </select>
                            </div>
                        </div>
                    </div>
                <div class="text-center mt-2">
                    <button v-on:click.prevent="filterSearch" class="mb-2 mr-2 btn btn-success"><i class="pe-7s-search"> </i> Search
                    </button>
                </div>
            </div>
        </div>
    </div> 

    <div class="col-md-12 col-lg-12">
        <div class="main-card mb-3 card">
            <div class="card-body">
                <div class="app-main__inner">
                    <form class="">
                        <div  v-for="d in lead" :key="d" >
                   <h3 style="color:#555f78"><b>Student Details</b></h3>
                    <div class="row">
                    <div class="col-sm-6" style="padding:40px">
                    <div class="position-relative row form-group"><h5>Full Name :</h5><label for="examplePassword"> &nbsp; {{d.FullName}}</label>
                    </div><br>
                    <div class="position-relative row form-group"><h5>Country :</h5><label for="examplePassword"> &nbsp; {{d.countries}}</label>
                    </div><br>
                    <div class="position-relative row form-group"><h5>Field of study : </h5><label for="exampleEmail"> &nbsp; {{d.Fieldofstudy}}</label>
                    </div><br>
                    <div class="position-relative row form-group"><h5>Email :</h5><label for="examplePassword"> &nbsp; {{d.Email}}</label>
                    </div><br>
                    <div class="position-relative row form-group"><h5>Contact Number :</h5><label for="exampleSelect"> &nbsp; {{d.Contactnumber}}</label>
                    </div><br>
                     <div class="position-relative row form-group"><h5>City :</h5><label for="exampleSelect"> &nbsp; {{d.City}}</label>
                    </div><br>
                    </div>
                    <div class="col-sm-6" style="padding:40px">
                     <div class="position-relative row form-group"><h5>Score :</h5><label for="exampleSelect"> &nbsp; {{d.Score}}</label>
                    </div><br>
                     <div class="position-relative row form-group"><h5>Budget Range :</h5><label for="exampleSelect"> &nbsp; {{d.BudgetRange}}</label>
                    </div><br>
                     <div class="position-relative row form-group"><h5>Current Edu Level :</h5><label for="exampleSelect"> &nbsp; {{d.Currentedulevel}}</label>
                    </div><br>
                     <div class="position-relative row form-group"><h5>Detail :</h5><label for="exampleSelect"> &nbsp; {{d.Detail}}</label>
                    </div><br>
                     <div class="position-relative row form-group"><h5>Date :</h5><label for="exampleSelect"> &nbsp; {{d.dates}}</label>
                    </div><br>
                    </div>
                    
                    </div>

                    </div>
                    </form>
                </div>
            </div>
        </div>
 </div> -->

    
   
</template>
<script>
import config from '@/../config'

import graph from './GraphInstitutedashboard'
export default {
    props: ['toggle','graphvalueconsultant','graphvalueconsultantads','graphvalueconsultantnews','graphvalueconsultantsholarship'],
    data () {
        return {
            key1: "",
            key2: "",
            key3: "",
            key1value: "",
            key2value: "",
            key3value: "", 
            leade:"",
            lead:"",
            graphinstitute:this.graphvalueconsultant,
            graphinstituteads:this.graphvalueconsultantads,
            graphinstitutenews:this.graphvalueconsultantnews,
            graphinstitutescholarship:this.graphvalueconsultantsholarship,
            token:""
        }
    },
    components: {
        graph
    },
    async mounted () {
        this.token=localStorage.getItem("token");

        // this.axios.get(config.hostname+'api/Formdata/Getall/')
        //       .then((response) => {
        //         this.leade = response.data
        //          })
        await this.axios.get(config.hostname+'api/ViewsCounter/Getuniversitybyemail/'+ this.email,
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
              .then((response) => {
                  response
                //this.leade = response.data
                 })
       
        // ////console.log(this.leads)
    },
    methods: {
        onChange(event) {
            this.key1value=event.target.value
            ////console.log(event.target.value)
            ////console.log("key 1:")
            ////console.log(this.key1value)
        },
        onChangess(event) {
            this.key2value=event.target.value
            ////console.log(event.target.value)
            ////console.log("key 2:")
            ////console.log(this.key2value)
        },
        onChangesss(event) {
            this.key3value=event.target.value
            ////console.log(event.target.value)
            ////console.log("key 3:")
            ////console.log(this.key3value)
        },
         async Search(id){
            ////console.log(id)
            await this.axios.get(config.hostname+'api/Formdata/GetbyId/' + id,
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
              .then((response) => {
                this.lead = response.data
                ////console.log(this.lead)
                 })
            
            
        },
         async filterSearch()
        {
            var select = document.getElementById("CountryOptions");
            var countries = select.options[select.selectedIndex].value
            ////console.log("Country is  : "+ countries);

            await this.axios.get(config.hostname+'api/Formdata/countries/'+ countries,
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
            .then((response) => {
            this.leade = response.data
		    // ////console.log(this.ConsultantsData) 
            }) 
        }
    }
    
}
</script>
