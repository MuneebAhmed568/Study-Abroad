<template> 
    <div class="main-card mb-3 card">
        <div class="card-body">
        <h3><b>Add Ads</b></h3>
        <div class="position-relative row form-group mt-2"><label for="exampleFile" class="col-sm-2 col-form-label" style="color:black">Upload your picture:</label>
                        <img src="assets/images/avatars/4.jpg" height="100px" width="100px"/>
                        <div class="col-sm-4"><input id="upload-pic" name="file" ref="fileInput" accept="image/*" @change="onFilePicked($event)" type="file" class="form-control-file" required>
                        </div>
                        <div class="col-sm-4">
                            <h5>image path:</h5>
                            {{this.Ipfs_path}}
                        </div>
                        <div class="col-sm-4 offset-sm-5">
        <button v-on:click.prevent="convert()" class="btn btn-secondary">Covert Image</button>
        </div>
                    </div>
        <form class="mt-4">
            <div class="position-relative row form-group"><label for="exampleEmail" class="col-sm-2 col-form-label">ID</label>
        <div class="col-sm-10"><input name="id" id="imgid" placeholder=" base64enter" type="text" class="form-control"></div>
        </div>
        <div class="col-sm-7 offset-sm-5">
        <button v-on:click.prevent="getId()" class="btn btn-secondary">Fetch Id Data</button>
        </div>
        <div class="col-sm-10 offset-sm-2" ><p>{{this.img_array}}</p></div>
        <div class="position-relative row form-group"><label for="exampleEmail" class="col-sm-2 col-form-label">IMAGE 1</label>
        <div class="col-sm-10"><input name="img1" id="img1" placeholder=" base64enter" type="text" class="form-control"></div>
        </div>
        <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-2 col-form-label">IMAGE 2</label>
        <div class="col-sm-10"><input name="img2" id="img2" placeholder="base64enter" type="text" class="form-control"></div>
        </div>
        <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-2 col-form-label">IMAGE 3</label>
        <div class="col-sm-10"><input name="img3" id="img3" placeholder="base64enter" type="text" class="form-control"></div>
        </div>
        <div class="position-relative row form-check mt-3">
        <div class="col-sm-7 offset-sm-5">
        <button v-on:click.prevent="addads()" class="btn btn-secondary">Submit</button>
        </div>
        </div>
        </form>
        </div>
    </div>
</template>
<script>
import config from '@/../config'
import { create } from 'ipfs-http-client';
import { Buffer } from 'buffer';
export default {
    props: ['emails'],
    data () {
        return {
            token:"",
            projectId: '2DBOP6lMpJJXMfPYTHHbUprAtAA',
            projectSecret : 'c47db02a18967d4b6b1758b83a53ffb8',
            file:"",
            Ipfs_path:"",
            img_array:[],
        }
    },
    methods: {
        async getId(){
            this.ImageID = document.getElementById('imgid').value
            if(this.ImageID >0 || this.ImageID != "" || this.ImageID <102){
                await this.axios.get(config.json_Api+'ads/'+this.ImageID+'')
		.then(async (response) => {
            console.log(response.data)
            this.img_array = response.data
			})
            }
            
        },
        async convert(){
            await this.uploadToIpfs(this.file )
            // console.log(va)
        },
        onFilePicked (event) {
        this.file = event.target.files[0]
        },
        async uploadToIpfs(file){
        
        const auth ='Basic ' + Buffer.from(this.projectId + ':' + this.projectSecret).toString('base64')

        const client = await create({
            host: 'ipfs.infura.io',
            port: 5001,
            protocol: 'https',
            headers: {
            authorization: auth
            }
        })
        const added = await client.add(file)
        const url = `https://abroadstudy.infura-ipfs.io/ipfs/${added.path}`
        this.Ipfs_path = url
        return url
    }, 
        addads () {
            this.ImageID = document.getElementById('imgid').value
            this.Image1 = document.getElementById('img1').value
            this.Image2 = document.getElementById('img2').value
            this.Image3 = document.getElementById('img3').value
            this.axios.patch(config.json_Api+`ads/${this.ImageID}`,{
                img1:this.Image1,
                img2: this.Image2,
                img3: this.Image3
            })
              .then((response) => {
                //Alert for Change Pass Verification
                response
                alert("Add Succesfully!")
                 })
        }
        
    }
}
</script>
