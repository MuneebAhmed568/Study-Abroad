<template>
    <h2 class="text-center"><b>Test Preparations</b></h2>
	<p style="font-size: 16px" class="text-center">Lorem Ipsum is simply dummy text of the printing and typesetting industry.</p>
	<div class="container-fluid">
		<div class="row">
            <div v-for="test in test.slice(0,3)" :key="test" class="col-sm-2 mt-2">
                <div style="card;padding:10px 10px 10px 10px;border-radius:10px;height:100%;box-shadow:0 2px 5px 1px #403c4329;">
                    <a href="" class="a">
                        <img class="mt-3 h-80 w-80" :src="test.uniImg">
                        <label class="mt-2" style="color:black">{{test.uni}}</label>
                    </a>
                </div>
            </div>
		</div>
        <router-link to="" class="a">
		<button style="background-color: #1EA1F3;color:white;padding:10px 70px;border-radius: 10px" class="btn mt-4 center" >See More</button>
        </router-link>
    </div>
</template>
<script>

  export default {
      props: ['test']
}
</script>