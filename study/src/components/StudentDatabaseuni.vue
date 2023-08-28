<template> 
<div>
    <div class="col-md-12 col-lg-12">
        <div class="main-card mb-3 card">
            <div class="card-body">
                <h5 class="card-title">Search Filter</h5>
                    <div class="row">
                        <div class="col-md-4">
                            <!-- <div @change="onChange($event)" :key="key1" class="position-relative form-group"><label for="exampleCustomSelect" class="">FIND STUDENT EDU LEVEL</label><select type="select" id="exampleCustomSelect" name="customSelect" class="custom-select">
                            <option value="">Select</option>
                            <option value="1">Value 1</option>
                            <option value="2">Value 2</option>
                            <option value="3">Value 3</option>
                            <option value="4">Value 4</option>
                            <option value="5">Value 5</option>
                            </select>
                            </div> -->
                        </div>
                        <!-- <div class="col-md-4">
                            <div @change="onChangess($event)" :key="key2" class="position-relative form-group"><label for="exampleCustomSelect" class="">LIVING IN</label><select type="select" id="exampleCustomSelect" name="customSelect" class="custom-select">
                            <option value="">Select</option>
                            <option value="1">Value 1</option>
                            <option value="2">Value 2</option>
                            <option value="3">Value 3</option>
                            <option value="4">Value 4</option>
                            <option value="5">Value 5</option>
                            </select>
                            </div>
                        </div> -->
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
 </div>

    <div class="col-md-12 col-lg-12">
        <div class="main-card mb-3 card">
            <div class="card-header">Student Info
            </div>
            <div class="table-responsive">
                <table class="align-middle mb-0 table table-borderless table-striped table-hover">
                    <thead>
                        <tr>
                        <th class="text-center">Date</th>
                        <th>Student Name</th>
                        <th class="text-center">Current Qualification</th>
                        <th class="text-center">Want To Study</th>
                        <th class="text-center">City</th>
                        <th class="text-center">Interested Countries</th>
                        <th class="text-center">Verified</th>
                        <th class="text-center">View</th>
                        <!-- <th class="text-center">Delete</th> -->
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for="s in leade" :key="s">
                            <td class="text-center text-muted">{{s.dates}}</td>
                            <td  class="text-center">{{s.FullName}}</td>
                            <td  class="text-center">{{s.Currentedulevel}}</td>
                            <td  class="text-center">{{s.Fieldofstudy}}</td>
                            <td  class="text-center">{{s.City}}</td>
                            <td  class="text-center">{{s.countries}}</td>
                            <td class="text-center">
                            <div  class="badge badge-warning">{{s.Fieldofstudy}}</div>
                            </td>
                            <td class="text-center">
                            <div class="font-icon-wrapper"><i @click="Search(s.id)" class="pe-7s-search"> </i></div>
                            </td>
                            <!-- <td class="text-center">
                            <div class="font-icon-wrapper"><i class="pe-7s-trash"> </i></div>
                            </td> -->
                        </tr>
                    </tbody>
                </table>        
            </div>
            <!-- <nav class="mt-4 ml-4 pb-4" aria-label="Page navigation example">
            <ul class="pagination">
            <li class="page-item"><a href="javascript:void(0);" class="page-link" aria-label="Previous"><span aria-hidden="true">«</span><span class="sr-only">Previous</span></a></li>
            <li class="page-item"><a href="javascript:void(0);" class="page-link">1</a></li>
            <li class="page-item active"><a href="javascript:void(0);" class="page-link">2</a></li>
            <li class="page-item"><a href="javascript:void(0);" class="page-link">3</a></li>
            <li class="page-item"><a href="javascript:void(0);" class="page-link">4</a></li>
            <li class="page-item"><a href="javascript:void(0);" class="page-link">5</a></li>
            <li class="page-item"><a href="javascript:void(0);" class="page-link" aria-label="Next"><span aria-hidden="true">»</span><span class="sr-only">Next</span></a></li>
            </ul>
            </nav> -->
        </div>
    </div>
</div>
</template>
<script>
import config from '@/../config'

export default {
    props: ['toggle','leads'],
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
            token:""
        }
    },
     mounted () {
        this.token=localStorage.getItem("token");

        // this.axios.get(config.hostname+'api/Formdata/Getall/')
        //       .then((response) => {
        //         this.leade = response.data
        //          })
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
