<template>
    <div class="">
           <div class="row">
       
       <div class="col-sm-6 mt-3" v-for="s in datas" :key="s">
     
                       <div class="card" style="padding:10px 10px 10px 10px;border-radius:10px;height:100%;box-shadow:0 2px 5px 1px #403c4329;">
                            
                           <div @click="ToSinglePage(s.Id)" class="text-center">
                          
                           <img :src="s.Imageipfs"  class="mb-3"  style="border-radius:100%;height:100px;width:100px;box-shadow:0 2px 5px 1px #403c4329">
                           <br/>
                           <label  class="mt-2" style="color:black">{{s.Heading_1}}</label>
                           <p class="text-center">{{s.Para_1}} </p>
                            </div>   
                          
                           
                       </div>
               
       </div>
       
       </div>
       </div>
          
       
   </template>
   <script>
   //import config from '@/../../config'
   
     export default {
         props: ['datas'],
         data(){
             return{
               image:undefined
   
             }
         },
        mounted () {
         
        },
         
         methods:{
             
             getImage (pic) {     
                   this.image =   pic
                       return this.image           
                   },
         
         ToSinglePage (Id) {
           // this.$router.push({path: '/ConsultantPage', params: { username: email }});
           // this.$router.push({name:'ConsultantPage', params: { param: email } })
           this.$router.push({name: 'blogpage', params: { Id: Id}});
         }
     }
   }
   </script>