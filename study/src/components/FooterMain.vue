<template>
<div>
    
		<div class="" style="background-color:#222533">
			<div class="container-fluid">
						<div class="container-fluid" style="padding:20px 50px">
						<div class="row">
							<div class="col-sm-12">
								<div class="row">
									<div class="col-sm-8">
										<img class="" src="../../public/image/logo.png"  width="150px" height="60px" />
												<br><br><a align="center" href=""><img src="../../public/image/facebook.png" height="30px" width="30px"></a> &nbsp;
												<a align="center" href=""><img src="../../public/image/youtube.png" height="30px" width="30px"></a> &nbsp;
												<a align="center" href=""><img src="../../public/image/in2.png" height="30px" width="30px"></a> &nbsp;
												<a align="center" href=""><img src="../../public/image/insta.png" height="30px" width="30px"></a> &nbsp;
												<a align="center" href=""><img src="../../public/image/twitter.png" height="30px" width="30px"></a> &nbsp;
													
									</div>
							<div class="col-lg-4 col-md-6 col-sm-12 col-12 mb-lg-0 mb-md-0 footer-widget">
								<div class="footer-section-title col-12 no-padding">
									<h3>latest Blogs</h3>
								</div>
								<!-- END SECTION TITLE -->
								<div class="col-12 footer-widget-inner recentPost">
									<div class="singleRecpost" v-for="d in data" :key="d" >
										<div v-on:click.prevent="ToSinglePage(d.Id)">
											<img  :src="d.Imageipfs" alt="" class="img-fluid">
											
												<a href="#">{{d.Heading_1}}</a>
											
											<p class="posted-on" >{{d.Dates}}</p>
										</div>
									</div>
								</div>
							</div>
							</div>
							</div>
						</div>
						
					</div>
						
					
			</div>
	</div>
</div>
</template>
<script>
 import config from '@/../config'

export default {
    data() {
        return{
            data:""
        }
    },
    mounted () {
        this.axios.get(config.hostname+'api/Blogs/GetTopone/')
              .then((response) => {
                this.data = response.data
                 })
    },
    methods: {
		 ToSinglePage (Id) {
           // this.$router.push({path: '/ConsultantPage', params: { username: email }});
           // this.$router.push({name:'ConsultantPage', params: { param: email } })
           this.$router.push({name: 'blogpage', params: { Id: Id}});
         },
        // Verify(id){
        //      //////console.log(id)
        //     this.axios.put(config.hostname+'api/addsinfo/Putupdatestatus/', {            
        //     Id: id,
        // })
        //   .then((response) => {
        //     //Alert for Verification
        //     alert(response.data)
        //   })
        // },
        Unverify(){
            
        }
    }
}
</script>