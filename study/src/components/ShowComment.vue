.<template>
  <br>
    <div class="blog-comment-list mt-5  col-12">
    <h4 class="row">News Comments</h4>
    <hr class="row">
    <div class="row mt-5 blog-comment-list-one" v-for="s in commentsshow" :key="s">
        <div class="col-lg-2 col-md-2 col-4 p-0 mb-lg-0 mb-md-0 mb-4">
            <div class="author-image">
                <img class="" style="height:100%;width:100%;" src="../assets/th.jpg" alt="">
                <!-- <div class="author-image-rep">
                    
                </div> -->
            </div>
        </div>
        <div class="col-lg-10 col-md-10 col-8 p-0">
            <div class="author-desc">
                <p class=""><span class="cauthor">{{s.FirstName +" "+ s.LastName}}</span> </p>
                <span class="mb-3" style="color:#1ea1f3">{{s.dates}}</span>
                <h3>Subject: {{s.Subjects}}</h3>
                <p>{{s.Messagess}}.</p>	
            </div>
        </div>
    </div>
    
</div>
</template>

<script>
//import config from '@/../../config'


export default {
    props: ['commentsshow'],
}
</script>

<style>

</style>