.<template>
  <div class="col-sm-6 a mt-3" v-for="dat in testData.slice(0,maxcount)" :key="dat">
       
            <div class="card" style="border-radius:10px;height:auto;box-shadow:0 2px 5px 1px #403c4329;" >
                <div @click="ToSinglePage(dat.test_name)" style="padding:10px 10px" >
                    <img :src="dat.Imageipfs" style="box-shadow:0 2px 5px 1px #403c4329;height:200px" class="w-100" >
                    <div style="color:black;text-align: center" class="col-sm-12 mt-1">
                        <h6><b>{{dat.test_name}}</b></h6>
                    </div>
                </div>
            </div>
    </div>
    
</template>

<script>
// import config from '@/../config'


export default {
    data () {
	return {
		
		datas:"",
    testData:[
      {
        Imageipfs: "https://abroadstudy.infura-ipfs.io/ipfs/QmUYtCuJZ5w98ZMXHHxfwyroqbksgzeaUrokQz8gS6m6XF",
        test_name:"IELTS",
      },
      {
        Imageipfs: "https://abroadstudy.infura-ipfs.io/ipfs/QmQvpFb8en837gBaqhR2TUUwpcRD117EgeKrFLCYYgVyz2",
        test_name:"PTE",
      },
      {
        Imageipfs: "https://abroadstudy.infura-ipfs.io/ipfs/QmeSQJqNTiNaphmKN7zpVSp9tMzqU2zadJ88eUguDDTwvM",
        test_name:"TOEFL",
      },
      {
        Imageipfs: "https://abroadstudy.infura-ipfs.io/ipfs/QmPTf4ZN7m6WFPKRwsaSTJjSMwi3f1eupzSLCXppRBS4rb",
        test_name:"SAT",
      },
      {
        Imageipfs: "https://abroadstudy.infura-ipfs.io/ipfs/QmNNd3XQyTm2CfChNmYc6uiZZkbtMknd2kRefAL8QJvL2P",
        test_name:"GRE",
      }
    ],
    //TESTING MR
  maxcount:4
	}
  }, 
	components: {
	
	
	
	
	},
  methods:{
          
      ToSinglePage (Test_name) {
        this.$router.push({name: '/testpage', params: { name: Test_name}});
      }  
  },
  mounted () {
    this.from_page="courses";
    // console.log(this.$route.name);
    if(this.$route.name=="/"){
      this.maxcount=4;
    }else if(this.$route.name=="/test"){
      this.maxcount=5;
    }
    // this.axios.get(config.hostname+'api/Testsinfo/Getall/')
    //     .then((response) => {
    //       this.datas = response.data
		//   console.log("hey",this.datas) 
    //     }) 
  }
}
</script>

<style>

</style>