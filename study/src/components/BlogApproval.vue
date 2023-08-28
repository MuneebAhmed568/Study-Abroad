<template> 
    <div class="main-card mb-3 card">
        <div class="card-body">
        <h3><b>Blog Handling</b></h3>
        <div class="position-relative row form-group mt-2"><label for="exampleFile" class="col-sm-2 col-form-label" style="color:black">Upload your picture:</label>
                        <img src="assets/images/avatars/4.jpg" height="100px" width="100px"/>
                        <div class="col-sm-4"><input id="upload-pic" name="file" ref="fileInput" accept="image/*" @change="onFilePicked($event)" type="file" class="form-control-file" required>
                        </div>
                        <div class="col-sm-4">
                            <h5>Main Image Graphics:</h5>
                        </div>
                        
        </div>
        <form class="mt-4">
            <div class="position-relative row form-group"><label for="exampleEmail" class="col-sm-2 col-form-label">Category</label>
            <div class="col-sm-10"><input name="Category" id="Category" placeholder=" Category" type="text" class="form-control"></div>
            </div>
            <div class="position-relative row form-group"><label for="exampleEmail" class="col-sm-2 col-form-label">Heading_1</label>
            <div class="col-sm-10"><input name="Heading_1" id="Heading_1" placeholder="Sub heading" type="text" class="form-control"></div>
            </div>
            <div class="position-relative row form-group"><label for="exampleEmail" class="col-sm-2 col-form-label">Para_1</label>
            <div class="col-sm-10"><input name="Para_1" id="Para_1" placeholder=" Description for heading" type="text" class="form-control"></div>
            </div>
            <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-2 col-form-label">Heading_2</label>
            <div class="col-sm-10"><input name="Heading_2" id="Heading_2" placeholder="Sub heading" type="text" class="form-control"></div>
            </div>
            <div class="position-relative row form-group"><label for="exampleEmail" class="col-sm-2 col-form-label">Para_2</label>
            <div class="col-sm-10"><input name="Para_2" id="Para_2" placeholder=" Description for heading" type="text" class="form-control"></div>
            </div>
            <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-2 col-form-label">Heading_3</label>
            <div class="col-sm-10"><input name="Heading_3" id="Heading_3" placeholder="Sub heading" type="text" class="form-control"></div>
            </div>
            <div class="position-relative row form-group"><label for="exampleEmail" class="col-sm-2 col-form-label">Para_3</label>
            <div class="col-sm-10"><input name="Para_3" id="Para_3" placeholder=" Description for heading" type="text" class="form-control"></div>
            </div>
            <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-2 col-form-label">Heading_4</label>
            <div class="col-sm-10"><input name="Heading_4" id="Heading_4" placeholder="Sub heading" type="text" class="form-control"></div>
            </div>
            <div class="position-relative row form-group"><label for="exampleEmail" class="col-sm-2 col-form-label">Para_4</label>
            <div class="col-sm-10"><input name="Para_4" id="Para_4" placeholder=" Description for heading" type="text" class="form-control"></div>
            </div>
            <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-2 col-form-label">Heading_5</label>
            <div class="col-sm-10"><input name="Heading_5" id="Heading_5" placeholder="Sub heading" type="text" class="form-control"></div>
            </div>
            <div class="position-relative row form-group"><label for="exampleEmail" class="col-sm-2 col-form-label">Para_5</label>
            <div class="col-sm-10"><input name="Para_5" id="Para_5" placeholder=" Description for heading" type="text" class="form-control"></div>
            </div>
            <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-2 col-form-label">Heading_6</label>
            <div class="col-sm-10"><input name="Heading_6" id="Heading_6" placeholder="Sub heading" type="text" class="form-control"></div>
            </div>
            <div class="position-relative row form-group"><label for="exampleEmail" class="col-sm-2 col-form-label">Para_6</label>
            <div class="col-sm-10"><input name="Para_6" id="Para_6" placeholder="Description for heading" type="text" class="form-control"></div>
            </div>
            <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-2 col-form-label">Heading_7</label>
            <div class="col-sm-10"><input name="Heading_7" id="Heading_7" placeholder="Sub heading" type="text" class="form-control"></div>
            </div>
            <div class="position-relative row form-group"><label for="exampleEmail" class="col-sm-2 col-form-label">Para_7</label>
            <div class="col-sm-10"><input name="Para_7" id="Para_7" placeholder="Description for heading" type="text" class="form-control"></div>
            </div>
            <div class="position-relative row form-check mt-3">
            <div class="col-sm-7 offset-sm-5">
            <button v-on:click.prevent="Submit()" class="btn btn-secondary">Submit</button>
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
            img_array:[]
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
        async onFilePicked (event) {
        this.file = event.target.files[0]
        await this.uploadToIpfs(this.file )
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
    async Submit() {
            const fd =new FormData()
            this.token= localStorage.getItem("token");
            this.Category = document.getElementById('Category').value
            this.Heading_1 = document.getElementById('Heading_1').value
            this.Para_1 = document.getElementById('Para_1').value
            this.Heading_2 = document.getElementById('Heading_2').value
            this.Para_2 = document.getElementById('Para_2').value
            this.Heading_3 = document.getElementById('Heading_3').value
            this.Para_3 = document.getElementById('Para_3').value
            this.Heading_4 = document.getElementById('Heading_4').value
            this.Para_4 = document.getElementById('Para_4').value
            this.Heading_5 = document.getElementById('Heading_5').value
            this.Para_5 = document.getElementById('Para_5').value
            this.Heading_6 = document.getElementById('Heading_6').value
            this.Para_6 = document.getElementById('Para_6').value
            this.Heading_7 = document.getElementById('Heading_7').value
            this.Para_7 = document.getElementById('Para_7').value
            fd.append("Category",this.Category)
            fd.append("Heading_1",this.Heading_1)
            fd.append("Para_1",this.Para_1)
            fd.append("Heading_2",this.Heading_2)
            fd.append("Para_2",this.Para_2)    
            fd.append("Heading_3",this.Heading_3)
            fd.append("Para_3",this.Para_3)
            fd.append("Heading_4",this.Heading_4)
            fd.append("Para_4",this.Para_4)
            fd.append("Heading_5",this.Heading_5)
            fd.append("Para_5",this.Para_5)
             fd.append("Heading_6",this.Heading_6)
            fd.append("Para_6",this.Para_6)
             fd.append("Heading_7",this.Heading_7)
            fd.append("Para_7",this.Para_7)
             fd.append("Imageipfs",this.Ipfs_path)
           
            await this.axios.post(config.hostname+'api/Blogs/PostBLog',fd, {headers:{
                    Accept: 'application/json',
                    'Content-type':'application/json',
                    Authorization:`Bearer ${this.token}`
                }})
              .then((response) => {
                //Alert for Change Pass Verification
                response
                alert("Add Succesfully!")
                 })
        }
        
    }
}
</script>
