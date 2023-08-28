<template>
  <div class="col-sm-9 mt-2">
    <div class="app-main__inner">
      <div class="row">
        <div class="col-md-12">
          <div class="main-card mb-3 card">
            <div class="card-header">
              <h5><b>Scholarship Approval:</b></h5>
            </div>
            <div class="table-responsive">
              <table
                class="
                  align-middle
                  mb-0
                  table table-borderless table-striped table-hover
                "
              >
                <thead>
                  <tr>
                    <th class="text-center">Title</th>
                    <th class="text-center">ID NO</th>
                    <th class="text-center">EMAIL</th>
                    <th class="text-center">Status</th>
                    <th class="text-center">Verify</th>
                    <!-- <th class="text-center">Un-verify</th> -->
                  </tr>
                </thead>
                <tbody>
                  <tr v-for="d in data" :key="d" >
                    <td class="text-center text-muted">{{d.title}}</td>
                    <td class="text-center">{{d.id}}</td>
                    <td class="text-center text-muted">{{d.email}}</td>
                    <td class="text-center text-muted">{{d.statuscheck}}</td>

                    <td class="text-center">
                      <button
                        type="button"
                        id="PopoverCustomT-1"
                        class="btn btn-primary btn-sm"
                        v-on:click.prevent="Verify(d.id)"
                      >
                        <i  class="fa fa-check"> </i> Verified
                      </button>
                    </td>

                    <!-- <td class="text-center">
                      <button
                        type="button"
                        id="PopoverCustomT-1"
                        class="btn btn-primary btn-sm bg-danger"
                      >
                        <i v-on:click.prevent="Unverify" class="fa fa-times"> </i> un-verify
                      </button>
                    </td> -->
                  </tr>
                </tbody>
              </table>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
// import config from '@/../config'

export default {
    data() {
        return{
            data:""
        }
    },
    mounted () {
        // this.axios.get(config.hostname+'api/scholarshipinfo/Getbystatuspending/')
        //       .then((response) => {
        //         this.data = response.data
        //          })
    },
    methods: {
        // Verify(id){
        //      ////console.log(id)
        //     this.axios.put(config.hostname+'api/scholarshipinfo/Putupdatestatus/', {
            
        //     Id: id,
            

        // })
        //   .then((response) => {
        //     //Alert for record update Verification
        //     alert(response.data)
        //   })
        // },
        Unverify(){
            
        }
    }
}
</script>
