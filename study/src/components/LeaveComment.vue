.<template>
    <div class="home-p-form-wrapper mt-5 mb-lg-0 mb-md-0 mb-5">
						<h4 class="row text-dark">Leave A Comment</h4>
						<hr class="row">
						<div class="home-p-form">
							<form action="#">
								<div class="row">
									<div class="form-group col-lg-6 mb-3">
										<input v-model="fname" name="aname" class="form-control" id="afirst-name" placeholder="First Name*" required="required" type="text">
									</div>
									<div class="form-group col-lg-6 mb-3">
										<input v-model="lname" name="lname" class="form-control" id="lname" placeholder="Last name" required="required" type="text">
									</div>
									<div class="form-group col-lg-6 mb-3">
										<input v-model="email" name="aemail" class="form-control" id="aemail" placeholder="Email id*" required="required" type="email">
									</div>
									<div class="form-group col-lg-6 mb-3">
										<input v-model="subject" name="asubject" class="form-control" id="asubject" placeholder="Subject" required="required" type="text">
									</div>									
									<div class="form-group col-lg-12 mb-3">
										<textarea v-model="message" rows="6" name="rmessage" class="form-control" id="adescription" placeholder="Ask Here..." required="required"></textarea>
									</div>
									<div class="form-group col-lg-5 mb-lg-0 mb-md-0 mb-2 pr-0">
										<button v-on:click.prevent="SaveComments" title="Click here to submit your message!" class="btn" style="background-color:#1ea1f3;color:#ffff">Send Comment <i class="fa fa-paper-plane"></i></button>
									</div>
									<div class="form-group col-lg-7">
										<p><strong>Note:</strong> We promise that we don't do spam &amp; your mail id is confidential. </p>
									</div>
								</div>
							</form>								
						</div>
					</div>	
</template>
<script>
import config from '@/../config'

export default {
	 props: ['pagename'],
	data () {
		return {
			fname: "",
			lname: "",
			email: "",
			subject: "",
			message: ""
		}
	},
	methods: {
		SaveComments () {
			////console.log("pagename is : "+this.pagename)
			this.axios.post(config.hostname+'api/Commentsinfo/Insertbyemail/',{
                Email:this.email,
                FirstName:this.fname,
                LastName:this.lname,
				Subjects:this.subject,
				Messagess:this.message,
				Pagename:this.pagename
            })
              .then((response) => {
				  //Alert for record inserted Verification
                alert(response.data)
                 })
		}
	}
}
</script>