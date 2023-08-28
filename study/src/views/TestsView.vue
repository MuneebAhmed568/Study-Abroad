<template>
  <fragment>
    
    <div class="container-fluid" style="padding: 20px 20px;">
            <div class="row">
                <div class="col-sm-8" >
                    <Adds :from_page="from_page" />

                    <div class="container-fluid mt-3" style="background-color:white">
                        <div style="text-align: center" class="pt-2 pb-2">
                            <h2 class="mt-5"><b>Tests</b></h2>
                            <p style="font-size: 20px">See the top trending Tests you need on our website</p>	
                        </div>
                        <section class="pb-5 mt-3">
	                        <div class="container-fluid">
							    <div class="row">
                                    <Test/>
                                </div>
                            </div>
                        </section>
                    </div>
                </div> 
                <div class="col-sm-2">
        <Form />
      </div>
                <div class="col-sm-2">
                    <SideAdds :slides="data" />
			</div>
            </div>
        </div>
    </fragment>
</template>

<script>
//import config from '@/../config'
import Adds from '@/components/CorousalSlide'
import SideAdds from '@/components/SideCorousalSlide'
import Form from '@/components/MainForm'
import Test from '@/components/TestCard'

export default {
    props:['data'],
    data () {
	return {
		from_page:"test"
	}
    },
    components:
    {
        Adds,
	    SideAdds,
	    Form,
        Test,
    },
    mounted() {
    this.from_page="test"
    }
}
</script>
