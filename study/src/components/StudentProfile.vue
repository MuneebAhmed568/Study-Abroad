.<template> 
  <div class="main-card mb-3 card">
<div class="card-body">
	<div  v-for="d in emailsession" :key="d" >
 <h3  style="color:#555f78"><b>Student Information :</b></h3>
<form class=" mt-4">

<div class="position-relative row form-group"><label for="examplePassword" class="col-sm-3 col-form-label">Email :</label>
<div class="col-sm-9"><input name="password" id="studentemail" v-model="d.Email" placeholder="abc@gmail.com" type="Text" class="form-control" readonly></div>
 </div>
<!-- <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-3 col-form-label">Password :</label>
<div class="col-sm-9"><input name="password" id="password" v-model="d.Password" placeholder="*******" type="text" class="form-control" readonly></div>
 </div> -->
 <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-3 col-form-label">Student Name :</label>
<div class="col-sm-9"><input name="password" id="studentname" v-model="d.Fullname" placeholder="" type="text" class="form-control"></div>
 </div>
<div class="position-relative row form-group"><label for="examplePassword" class="col-sm-3 col-form-label">Contact Number :</label>
<div class="col-sm-9"><input name="password" id="phonenumber" v-model="d.Phoneno" placeholder="03*********" type="text" class="form-control"></div>
 </div>
<div class="position-relative row form-group"><label for="examplePassword" class="col-sm-3 col-form-label">Your City :</label>
<div class="col-sm-9"><select name="password" id="location"   placeholder="Enter your course" type="password" class="form-control">
								<option id="ckh1" value="Select Your City">Select Your City</option>
								<option id="ckh2" value="Islamabad">Islamabad</option>
								<option id="ckh3" value="" disabled>Punjab Cities</option>
								<option id="ckh4" value="Ahmed Nager Chatha">Ahmed Nager Chatha</option>
								<option id="ckh5" value="Ahmadpur East">Ahmadpur East</option>
								<option id="ckh6" value="Ali Khan Abad">Ali Khan Abad</option>
								<option id="ckh7" value="Alipur">Alipur</option>
								<option id="ckh8" value="Arifwala">Arifwala</option>
								<option id="ckh9" value="Attock">Attock</option>
								<option id="ckh10" value="Bhera">Bhera</option>
								<option id="ckh11" value="Bhalwal">Bhalwal</option>
								<option id="ckh12" value="Bahawalnagar">Bahawalnagar</option>
								<option id="ckh13" value="Bahawalpur">Bahawalpur</option>
								<option id="ckh14" value="Bhakkar">Bhakkar</option>
								<option id="ckh15" value="Burewala">Burewala</option>
								<option id="ckh16" value="Chillianwala">Chillianwala</option>
								<option id="ckh17" value="Chakwal">Chakwal</option>
								<option id="ckh18" value="Chichawatni">Chichawatni</option>
								<option id="ckh19" value="Chiniot">Chiniot</option>
								<option id="ckh20" value="Chishtian">Chishtian</option>
								<option id="ckh22" value="Daska">Daska</option>
								<option id="ckh23" value="Darya Khan">Darya Khan</option>
								<option id="ckh24" value="Dera Ghazi Khan">Dera Ghazi Khan</option>
								<option id="ckh25" value="Dhaular">Dhaular</option>
								<option id="ckh26" value="Dina">Dina</option>
								<option id="ckh27" value="Dinga">Dinga</option>
								<option id="ckh28" value="Dipalpur">Dipalpur</option>
								<option id="ckh29" value="Faisalabad">Faisalabad</option>
								<option id="ckh30" value="Ferozewala">Ferozewala</option>
								<option id="ckh31" value="Fateh Jhang">Fateh Jang</option>
								<option id="ckh32" value="Ghakhar Mandi">Ghakhar Mandi</option>
								<option id="ckh33" value="Gojra">Gojra</option>
								<option id="ckh34" value="Gujranwala">Gujranwala</option>
								<option id="ckh35" value="Gujrat">Gujrat</option>
								<option id="ckh36" value="Gujar Khan">Gujar Khan</option>
								<option id="ckh37" value="Hafizabad">Hafizabad</option>
								<option id="ckh38" value="Haroonabad">Haroonabad</option>
								<option id="ckh39" value="Hasilpur">Hasilpur</option>
								<option id="ckh40" value="Haveli Lakha">Haveli Lakha</option>
								<option id="ckh41" value="Jatoi">Jatoi</option>
								<option id="ckh42" value="Jalalpur">Jalalpur</option>
								<option id="ckh43" value="Jattan">Jattan</option>
								<option id="ckh44" value="Jampur">Jampur</option>
								<option id="ckh45" value="Jaranwala">Jaranwala</option>
								<option id="ckh46" value="Jhang">Jhang</option>
								<option id="ckh47" value="Jhelum">Jhelum</option>
								<option id="ckh48" value="Kalabagh">Kalabagh</option>
								<option id="ckh49" value="Karor Lal Esan">Karor Lal Esan</option>
								<option id="ckh50" value="Kasur">Kasur</option>
								<option id="ckh51" value="Kamalia">Kamalia</option>
								<option id="ckh52" value="Kamoke">Kamoke</option>
								<option id="ckh53" value="Khanewal">Khanewal</option>
								<option id="ckh54" value="Khanpur">Khanpur</option>
								<option id="ckh55" value="Kharian">Kharian</option>
								<option id="ckh56" value="Khushab">Khushab</option>
								<option id="ckh57" value="Kot Addu">Kot Addu</option>
								<option id="ckh58" value="Jauharabad">Jauharabad</option>
								<option id="ckh59" value="Lahore">Lahore</option>
								<option id="ckh60" value="Lalamusa">Lalamusa</option>
								<option id="ckh61" value="Layyah">Layyah</option>
								<option id="ckh62" value="Liaquat Pur">Liaquat Pur</option>
								<option id="ckh63" value="Lodhran">Lodhran</option>
								<option id="ckh64" value="Malakwal">Malakwal</option>
								<option id="ckh65" value="Mamoori">Mamoori</option>
								<option id="ckh66" value="Mailsi">Mailsi</option>
								<option id="ckh67" value="Mandi Bahauddin">Mandi Bahauddin</option>
								<option id="ckh68" value="Mian Channu">Mian Channu</option>
								<option id="ckh69" value="Mianwali">Mianwali</option>
								<option id="ckh70" value="Multan">Multan</option>
								<option id="ckh71" value="Murree">Murree</option>
								<option id="ckh72" value="Muridke">Muridke</option>
								<option id="ckh73" value="Mianwali Bangla">Mianwali Bangla</option>
								<option id="ckh74" value="Muzaffargarh">Muzaffargarh</option>
								<option id="ckh75" value="Narowal">Narowal</option>
								<option id="ckh76" value="Nankana Sahib">Nankana Sahib</option>
								<option id="ckh77" value="Okara">Okara</option>
								<option id="ckh78" value="Renala Khurd">Renala Khurd</option>
								<option id="ckh79" value="Pakpattan">Pakpattan</option>
								<option id="ckh80" value="Pattoki">Pattoki</option>
								<option id="ckh81" value="Pir Mahal">Pir Mahal</option>
								<option id="ckh82" value="Qaimpur">Qaimpur</option>
								<option id="ckh83" value="Qila Didar Singh">Qila Didar Singh</option>
								<option id="ckh84" value="Rabwah">Rabwah</option>
								<option id="ckh85" value="Raiwind">Raiwind</option>
								<option id="ckh86" value="Rajanpur">Rajanpur</option>
								<option id="ckh87" value="Rahim Yar Khan">Rahim Yar Khan</option>
								<option id="ckh88" value="Rawalpindi">Rawalpindi</option>
								<option id="ckh89" value="Sadiqabad">Sadiqabad</option>
								<option id="ckh90" value="Safdarabad">Safdarabad</option>
								<option id="ckh91" value="Sahiwal">Sahiwal</option>
								<option id="ckh92" value="Sangla Hill">Sangla Hill</option>
								<option id="ckh93" value="Sarai Alamgir">Sarai Alamgir</option>
								<option id="ckh94" value="Sargodha">Sargodha</option>
								<option id="ckh95" value="Shakargarh">Shakargarh</option>
								<option id="ckh96" value="Sheikhupura">Sheikhupura</option>
								<option id="ckh97" value="Sialkot">Sialkot</option>
								<option id="ckh98" value="Sohawa">Sohawa</option>
								<option id="ckh99" value="Soianwala">Soianwala</option>
								<option id="ckh100" value="Siranwali">Siranwali</option>
								<option id="ckh101" value="Talagang">Talagang</option>
								<option id="ckh102" value="Taxila">Taxila</option>
								<option id="ckh103" value="Toba Tek Singh">Toba Tek Singh</option>
								<option id="ckh104" value="Vehari">Vehari</option>
								<option id="ckh105" value="Wah Cantonment">Wah Cantonment</option>
								<option id="ckh106" value="Wazirabad">Wazirabad</option>
								<option id="ckh107" value="" disabled>Sindh Cities</option>
								<option id="ckh108" value="Badin">Badin</option>
								<option id="ckh109" value="Bhirkan">Bhirkan</option>
								<option id="ckh110" value="Rajo Khanani">Rajo Khanani</option>
								<option id="ckh111" value="Chak">Chak</option>
								<option id="ckh112" value="Dadu">Dadu</option>
								<option id="ckh113" value="Digri">Digri</option>
								<option id="ckh114" value="Diplo">Diplo</option>
								<option id="ckh115" value="Dokri">Dokri</option>
								<option id="ckh116" value="Ghotki">Ghotki</option>
								<option id="ckh117" value="Haala">Haala</option>
								<option id="ckh118" value="Hyderabad">Hyderabad</option>
								<option id="ckh119" value="Islamkot">Islamkot</option>
								<option id="ckh120" value="Jacobabad">Jacobabad</option>
								<option id="ckh121" value="Jamshoro">Jamshoro</option>
								<option id="ckh122" value="Jungshahi">Jungshahi</option>
								<option id="ckh123" value="Kandhkot">Kandhkot</option>
								<option id="ckh124" value="Kandiaro">Kandiaro</option>
								<option id="ckh125" value="Karachi">Karachi</option>
								<option id="ckh126" value="Kashmore">Kashmore</option>
								<option id="ckh127" value="Keti Bandar">Keti Bandar</option>
								<option id="ckh128" value="Khairpur">Khairpur</option>
								<option id="ckh129" value="Kotri">Kotri</option>
								<option id="ckh130" value="Larkana">Larkana</option>
								<option id="ckh131" value="Matiari">Matiari</option>
								<option id="ckh132" value="Mehar">Mehar</option>
								<option id="ckh133" value="Mirpur Khas">Mirpur Khas</option>
								<option id="ckh134" value="Mithani">Mithani</option>
								<option id="ckh135" value="Mithi">Mithi</option>
								<option id="ckh136" value="Mehrabpur">Mehrabpur</option>
								<option id="ckh137" value="Moro">Moro</option>
								<option id="ckh138" value="Nagarparkar">Nagarparkar</option>
								<option id="ckh139" value="Naudero">Naudero</option>
								<option id="ckh140" value="Naushahro Feroze">Naushahro Feroze</option>
								<option id="ckh141" value="Naushara">Naushara</option>
								<option id="ckh142" value="Nawabshah">Nawabshah</option>
								<option id="ckh143" value="Nazimabad">Nazimabad</option>
								<option id="ckh145" value="Qambar">Qambar</option>
								<option id="ckh146" value="Qasimabad">Qasimabad</option>
								<option id="ckh147" value="Ranipur">Ranipur</option>
								<option id="ckh148" value="Ratodero">Ratodero</option>
								<option id="ckh149" value="Rohri">Rohri</option>
								<option id="ckh150" value="Sakrand">Sakrand</option>
								<option id="ckh151" value="Sanghar">Sanghar</option>
								<option id="ckh152" value="Shahbandar">Shahbandar</option>
								<option id="ckh153" value="Shahdadkot">Shahdadkot</option>
								<option id="ckh154" value="Shahdadpur">Shahdadpur</option>
								<option id="ckh155" value="Shahpur Chakar">Shahpur Chakar</option>
								<option id="ckh156" value="Shikarpaur">Shikarpaur</option>
								<option id="ckh157" value="Sukkur">Sukkur</option>
								<option id="ckh158" value="Tangwani">Tangwani</option>
								<option id="ckh159" value="Tando Adam Khan">Tando Adam Khan</option>
								<option id="ckh160" value="Tando Allahyar">Tando Allahyar</option>
								<option id="ckh161" value="Tando Muhammad Khan">Tando Muhammad Khan</option>
								<option id="ckh162" value="Thatta">Thatta</option>
								<option id="ckh163" value="Umerkot">Umerkot</option>
								<option id="ckh164" value="Warah">Warah</option>
								<option id="ckh165" value="" disabled>Khyber Cities</option>
								<option id="ckh166" value="Abbottabad">Abbottabad</option>
								<option id="ckh167" value="Adezai">Adezai</option>
								<option id="ckh168" value="Alpuri">Alpuri</option>
								<option id="ckh169" value="Akora Khattak">Akora Khattak</option>
								<option id="ckh170" value="Ayubia">Ayubia</option>
								<option id="ckh171" value="Banda Daud Shah">Banda Daud Shah</option>
								<option id="ckh172" value="Bannu">Bannu</option>
								<option id="ckh173" value="Batkhela">Batkhela</option>
								<option id="ckh174" value="Battagram">Battagram</option>
								<option id="ckh175" value="Birote">Birote</option>
								<option id="ckh176" value="Chakdara">Chakdara</option>
								<option id="ckh177" value="Charsadda">Charsadda</option>
								<option id="ckh178" value="Chitral">Chitral</option>
								<option id="ckh179" value="Daggar">Daggar</option>
								<option id="ckh180" value="Dargai">Dargai</option>
								<option id="ckh181" value="Darya Khan">Darya Khan</option>
								<option id="ckh182" value="Dera Ismail Khan">Dera Ismail Khan</option>
								<option id="ckh183" value="Doaba">Doaba</option>
								<option id="ckh184" value="Dir">Dir</option>
								<option id="ckh185" value="Drosh">Drosh</option>
								<option id="ckh186"  value="Hangu">Hangu</option>
								<option id="ckh187" value="Haripur">Haripur</option>
								<option id="ckh188" value="Karak">Karak</option>
								<option id="ckh189" value="Kohat">Kohat</option>
								<option id="ckh190" value="Kulachi">Kulachi</option>
								<option id="ckh191" value="Lakki Marwat">Lakki Marwat</option>
								<option id="ckh192" value="Latamber">Latamber</option>
								<option id="ckh193" value="Madyan">Madyan</option>
								<option id="ckh194" value="Mansehra">Mansehra</option>
								<option id="ckh195" value="Mardan">Mardan</option>
								<option id="ckh196" value="Mastuj">Mastuj</option>
								<option id="ckh197" value="Mingora">Mingora</option>
								<option id="ckh198" value="Nowshera">Nowshera</option>
								<option id="ckh199" value="Paharpur">Paharpur</option>
								<option id="ckh200" value="Pabbi">Pabbi</option>
								<option id="ckh201" value="Peshawar">Peshawar</option>
								<option id="ckh202" value="Saidu Sharif">Saidu Sharif</option>
								<option id="ckh203" value="Shorkot">Shorkot</option>
								<option id="ckh204" value="Shewa Adda">Shewa Adda</option>
								<option id="ckh205" value="Swabi">Swabi</option>
								<option id="ckh206" value="Swat">Swat</option>
								<option id="ckh207" value="Tangi">Tangi</option>
								<option id="ckh208" value="Tank">Tank</option>
								<option id="ckh209" value="Thall">Thall</option>
								<option id="ckh210" value="Timergara">Timergara</option>
								<option id="ckh211" value="Tordher">Tordher</option>
								<option id="ckh212" value="" disabled>Balochistan Cities</option>
								<option id="ckh213" value="Awaran">Awaran</option>
								<option id="ckh214" value="Barkhan">Barkhan</option>
								<option id="ckh215" value="Chagai">Chagai</option>
								<option id="ckh216" value="Dera Bugti">Dera Bugti</option>
								<option id="ckh217" value="Gwadar">Gwadar</option>
								<option id="ckh218" value="Harnai">Harnai</option>
								<option id="ckh219" value="Jafarabad">Jafarabad</option>
								<option id="ckh220" value="Jhal Magsi">Jhal Magsi</option>
								<option id="ckh221" value="Kacchi">Kacchi</option>
								<option id="ckh222" value="Kalat">Kalat</option>
								<option id="ckh223" value="Kech">Kech</option>
								<option id="ckh224" value="Kharan">Kharan</option>
								<option id="ckh225" value="Khuzdar">Khuzdar</option>
								<option id="ckh226" value="Killa Abdullah">Killa Abdullah</option>
								<option id="ckh227" value="Killa Saifullah">Killa Saifullah</option>
								<option id="ckh228" value="Kohlu">Kohlu</option>
								<option id="ckh229" value="Lasbela">Lasbela</option>
								<option id="ckh230" value="Lehri">Lehri</option>
								<option id="ckh231" value="Loralai">Loralai</option>
								<option id="ckh232" value="Mastung">Mastung</option>
								<option id="ckh233" value="Musakhel">Musakhel</option>
								<option id="ckh234" value="Nasirabad">Nasirabad</option>
								<option id="ckh235" value="Nushki">Nushki</option>
								<option id="ckh236" value="Panjgur">Panjgur</option>
								<option id="ckh237" value="Pishin Valley">Pishin Valley</option>
								<option id="ckh238" value="Quetta">Quetta</option>
								<option id="ckh239" value="Sherani">Sherani</option>
								<option id="ckh240" value="Sibi">Sibi</option>
								<option id="ckh241" value="Sohbatpur">Sohbatpur</option>
								<option id="ckh242" value="Washuk">Washuk</option>
								<option id="ckh243" value="Zhob">Zhob</option>
								<option id="ckh244" value="Ziarat">Ziarat</option>
							</select>
 </div>
 </div>
 <div class="col-sm-10"><input id="upload-pic" name="file" ref="fileInput" accept="image/*" @change="onFilePicked($event)" type="file" class="form-control-file" required>
                        </div>

<div class="position-relative row form-group">
	<div align="center" class="col-sm-12 mt-3">
	<button v-on:click.prevent="updateinfo" class="btn btn-secondary">Submit</button>
	</div>
</div>


</form>
 </div>
 </div>
 </div>
</template>

<script>
import config from '@/../config'

import { create } from 'ipfs-http-client';
import { Buffer } from 'buffer';

export default {
	props: ['toggle','emailsession','emails'],
	data()
	{
		return{
			file:"", 
			image: null,
			
            projectId: '2DBOP6lMpJJXMfPYTHHbUprAtAA',
            projectSecret : 'c47db02a18967d4b6b1758b83a53ffb8',
			token:""
		}
	}
		
	,
	mounted () {
		this.token= localStorage.getItem("token");
	
	},
	methods:
	{
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
        return url
    }, 
		async updateinfo() 
		{
			var url= await this.uploadToIpfs(this.file);
            //console.log("Url from Ads Uni");
            //console.log(url);
			var select = document.getElementById("location");
		    var selectedValue = select.options[select.selectedIndex].value
			this.email = document.getElementById('studentemail').value
		    this.phoneno = document.getElementById('phonenumber').value
            this.name = document.getElementById('studentname').value
		   
		   if(this.phoneno!="" && this.name!=""  && this.file!="")
		   {
            ////console.log(this.compname + " "+this.email +"" + this.pername + " " + this.city + " " +  this.address + " " + this.phno + " " + this.web + " "  + this.freetxt+ " ")
            await this.axios.put(config.hostname+'api/Studentinfo/Putbyemail/', {
            Fullname: this.name,
            Phoneno: this.phoneno,
            Email: this.email,
            Location:selectedValue
            
			},
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
			.then((response) => {
            alert(response.data)
          })

			////console.log(this.file)
          if(this.file != ""){
             const fd =new FormData()
			 this.email = document.getElementById('studentemail').value
            fd.append("Email",this.email)
            fd.append('imageurlbase64', url)
            ////console.log(fd)
            await this.axios.post(config.hostname+'api/Studentinfo/savepic/',fd,
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
            .then(res => {
				res
                //alert(res.data)
            })
          }
		  }
		  else{
			  alert("All Fields are Required")
		  }

		},onFilePicked (event) {
        this.file = event.target.files[0]
        }
	}
}
</script>

<style>

</style>