<template>
    <div class="container-fluid">
		<div class="row">
			<div class="col-sm-2 mt-2" v-for="t in countryImg" :key="t" >
				<div style="card; padding:10px 10px 10px 10px;border-radius:10px;height:auto;box-shadow:0 2px 5px 1px #403c4329;">
					<a href="" class="a">
					<img style="width:100px;height:100px;box-shadow:0 2px 5px 1px #403c4329" class="mt-3 " :src="t.CountryLogo_Ipfs" >
					<label class="mt-2" style="color:black">{{t.Country_Name}}</label>
					</a>
				</div>
			</div>
		</div>
		<button style="background-color: #1EA1F3;color:white;height:auto;width:200px;border-radius: 10px" class="btn mt-4">See More</button>
	</div>
	
</template>
<script>
import config from '@/../../config'

  export default {
      props: ['countryImg']
}
</script>
