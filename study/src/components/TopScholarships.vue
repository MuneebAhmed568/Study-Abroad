<template>
<div class="container-fluid">
	 <div class="row">
         <div class="col-sm-2 mt-2" v-for="s in TopSco" :key="s">
            <div style="card;padding:10px 10px 10px 10px;border-radius:10px;height:100%;box-shadow:0 2px 5px 1px #403c4329;">
                <a href="" class="a">
                    <img :src="s.cover" style="border-radius: 100%" class="h-25"  >
                    <br><label class="mt-4" style="color:black">{{s.text}} <br> Services</label>
                </a>
            </div>
        </div>
    </div>
    <button class="btn mt-4" style="background-color: #1EA1F3;color:white;padding:10px 70px;border-radius: 10px">See More Details</button>
</div>
    
</template>
<script>
import config from '@/../../config'

  export default {
      props: ['TopSco']
}
</script>