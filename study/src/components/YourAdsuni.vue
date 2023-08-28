<template> 
<div class="main-card mb-3 card">
    <div class="card-body">
    <h3><b>Add ADs :</b></h3>
        <form class="">
            <div v-for="d in adslist1" :key="d">
            <div class="position-relative row form-group">
                <label for="examplePassword" class="col-sm-2 col-form-label">Title:
                    <i style="color:red">*</i></label>
                <div class="col-sm-10"><input  v-model="d.Title" name="title" id="tilt" placeholder="Enter Title" type="text" class="form-control"></div>
            </div>
            <div class="position-relative row form-group"><label for="exampleText" class="col-sm-2 col-form-label">AD Details:</label>
                <div class="col-sm-10"><textarea v-model="d.Detail" name="text" id="det" class="form-control"></textarea></div>
            </div>
            
            <div class="row">
                <div class="col-sm-6">
                    <div class="position-relative row form-group">
                    <div class="col-12 mt-2">
                        <label for="exampleFile" class=" col-form-label">Select Countries:</label>
                    </div>
                    </div>
                    <div class="position-relative row form-group">
                         <div class="col-12 mt-2">
                            <div id="chkmain"  class="multiselect">
                          <label><input id="chk1" type="checkbox" name="option[]" value="Afghanistan">Afghanistan</label>
									<label ><input id="chk2" type="checkbox" name="option[]" value="Aland Islands">Aland Islands</label>
									<label ><input id="chk3" type="checkbox" name="option[]" value="Albania">Albania</label>
									<label ><input id="chk4" type="checkbox" name="option[]" value="Algeria">Algeria</label>
									<label ><input id="chk5" type="checkbox" name="option[]" value="American Samoa">American Samoa</label>
									<label><input id="chk6" type="checkbox" name="option[]" value="Andorra">Andorra</label>
									<label><input id="chk7" type="checkbox" name="option[]" value="Angola">Angola</label>
									<label ><input id="chk8" type="checkbox" name="option[]" value="Anguilla">Anguilla</label>
									<label ><input id="chk9" type="checkbox" name="option[]" value="Antarctica">Antarctica</label>
									<label ><input id="chk10" type="checkbox" name="option[]" value="Antigua and Barbuda">Antigua and Barbuda</label>
									<label ><input id="chk11" type="checkbox" name="option[]" value="Argentina">Argentina</label>
									<label><input id="chk12" type="checkbox" name="option[]" value="Armenia">Armenia</label>
									<label><input id="chk13" type="checkbox" name="option[]" value="Aruba">Aruba</label>
									<label ><input id="chk14" type="checkbox" name="option[]" value="Australia">Australia</label>
									<label ><input id="chk15" type="checkbox" name="option[]" value="Austria">Austria</label>
									<label ><input id="chk16" type="checkbox" name="option[]" value="Azerbaijan">Azerbaijan</label>
									<label ><input id="chk17" type="checkbox" name="option[]" value="Bahamas">Bahamas</label>
									<label><input id="chk18" type="checkbox" name="option[]" value="Bahrain">Bahrain</label>
									<label><input id="chk19" type="checkbox" name="option[]" value="Bangladesh">Bangladesh</label>
									<label ><input id="chk20" type="checkbox" name="option[]" value="Barbados">Barbados</label>
									<label ><input id="chk21" type="checkbox" name="option[]" value="Belarus">Belarus</label>
									<label ><input id="chk22" type="checkbox" name="option[]" value="Belgium">Belgium</label>
									<label ><input id="chk23" type="checkbox" name="option[]" value="Benin">Benin</label>
									<label><input id="chk24" type="checkbox" name="option[]" value="Bermuda">Bermuda</label>
									<label><input id="chk25" type="checkbox" name="option[]" value="Bhutan">Bhutan</label>
									<label ><input id="chk26" type="checkbox" name="option[]" value="Bolivia">Bolivia</label>
									<label ><input id="chk27" type="checkbox" name="option[]" value="Bonaire Sint Eustatius and Saba">Bonaire Sint Eustatius and Saba</label>
									<label ><input id="chk28" type="checkbox" name="option[]" value="Bosnia and Herzegovina">Bosnia and Herzegovina</label>
									<label><input id="chk29" type="checkbox" name="option[]" value="Botswana">Botswana</label>
									<label><input id="chk30" type="checkbox" name="option[]" value="Bouvet Island">Bouvet Island</label>
									<label ><input id="chk31" type="checkbox" name="option[]" value="Brazil">Brazil</label>
									<label ><input id="chk32" type="checkbox" name="option[]" value="British Indian Ocean Territory">British Indian Ocean Territory</label>
									<label ><input id="chk33" type="checkbox" name="option[]" value="Brunei Darussalam">Brunei Darussalam</label>
									<label ><input id="chk34" type="checkbox" name="option[]" value="Bulgaria">Bulgaria</label>
									<label><input id="chk35" type="checkbox" name="option[]" value="Burkina Faso">Burkina Faso</label>
									<label><input id="chk36" type="checkbox" name="option[]" value="Burundi">Burundi</label>
									<label ><input id="chk37" type="checkbox" name="option[]" value="Cambodia">Cambodia</label>
									<label ><input id="chk38" type="checkbox" name="option[]" value="Cameroon">Cameroon</label>
									<label ><input id="chk39" type="checkbox" name="option[]" value="Canada">Canada</label>
									<label ><input id="chk40" type="checkbox" name="option[]" value="Cape Verde">Cape Verde</label>
									<label><input id="chk41" type="checkbox" name="option[]" value="Canada">Canada</label>
									<label><input id="chk42" type="checkbox" name="option[]" value="Cayman Islands">Cayman Islands</label>
									<label ><input id="chk43" type="checkbox" name="option[]" value="Central African Republic">Central African Republic</label>
									<label ><input id="chk44" type="checkbox" name="option[]" value="Chad">Chad</label>
									<label ><input id="chk45" type="checkbox" name="option[]" value="Chile">Chile</label>
									<label ><input id="chk46" type="checkbox" name="option[]" value="China">China</label>
									<label><input id="chk47" type="checkbox" name="option[]" value="Christmas Island">Christmas Island</label>
									<label><input id="chk48" type="checkbox" name="option[]" value="Cocos (Keeling) Islands">Cocos (Keeling) Islands</label>
									<label ><input id="chk49" type="checkbox" name="option[]" value="Colombia">Colombia</label>
									<label ><input id="chk50" type="checkbox" name="option[]" value="Comoros">Comoros</label>
									<label ><input id="chk51" type="checkbox" name="option[]" value="Congo">Congo</label>
									<label ><input id="chk52" type="checkbox" name="option[]" value="Congo Democratic Republic of the Congo">Congo Democratic Republic of the Congo</label>
									<label><input id="chk53" type="checkbox" name="option[]" value="Cook Islands">Cook Islands</label>
									<label ><input id="chk54" type="checkbox" name="option[]" value="Costa Rica">Costa Rica</label>
									<label ><input id="chk55" type="checkbox" name="option[]" value="Cote D'Ivoire">Cote D'Ivoire</label>
									<label ><input id="chk56" type="checkbox" name="option[]" value="Croatia">Croatia</label>
									<label ><input id="chk57" type="checkbox" name="option[]" value="Cuba">Cuba</label>
									<label><input id="chk58" type="checkbox" name="option[]" value="Curacao">Curacao</label>
									<label><input id="chk59" type="checkbox" name="option[]" value="Cyprus">Cyprus</label>
									<label ><input id="chk60" type="checkbox" name="option[]" value="Czech Republic">Czech Republic</label>
									<label ><input id="chk61" type="checkbox" name="option[]" value="Denmark">Denmark</label>
									<label ><input id="chk62" type="checkbox" name="option[]" value="Djibouti">Djibouti</label>
									<label ><input id="chk63" type="checkbox" name="option[]" value="Dominica">Dominica</label>
									<label ><input id="chk64" type="checkbox" name="option[]" value="Ecuador">Ecuador</label>
									<label ><input id="chk65" type="checkbox" name="option[]" value="Egypt">Egypt</label>
									<label ><input id="chk66" type="checkbox" name="option[]" value="El Salvador">El Salvador</label>
									<label><input id="chk67" type="checkbox" name="option[]" value="Equatorial Guinea">Equatorial Guinea</label>
									<label><input id="chk68" type="checkbox" name="option[]" value="Eritrea">Eritrea</label>
									<label ><input id="chk69" type="checkbox" name="option[]" value="Ethiopia">Ethiopia</label>
									<label ><input id="chk70" type="checkbox" name="option[]" value="Falkland Islands (Malvinas)">Falkland Islands (Malvinas)</label>
									<label ><input id="chk71" type="checkbox" name="option[]" value="Faroe Islands">Faroe Islands</label>
									<label ><input id="chk72" type="checkbox" name="option[]" value="Fiji">Fiji</label>
									<label ><input id="chk73" type="checkbox" name="option[]" value="Finland">Finland</label>
									<label ><input id="chk74" type="checkbox" name="option[]" value="France">France</label>
									<label ><input id="chk75" type="checkbox" name="option[]" value="French Guiana">French Guiana</label>
									<label><input id="chk76" type="checkbox" name="option[]" value="French Polynesia">French Polynesia</label>
									<label><input id="chk77" type="checkbox" name="option[]" value="French Southern Territories">French Southern Territories</label>
									<label ><input id="chk78" type="checkbox" name="option[]" value="Gabon">Gabon</label>
									<label ><input id="chk79" type="checkbox" name="option[]" value="Gambia">Gambia</label>
									<label ><input id="chk80" type="checkbox" name="option[]" value="Georgia">			</label>
									<label><input id="chk81" type="checkbox" name="option[]" value="Germany">Germany</label>
									<label ><input id="chk82" type="checkbox" name="option[]" value="Ghana">Ghana</label>
									<label ><input id="chk83" type="checkbox" name="option[]" value="Gibraltar">Gibraltar</label>
									<label ><input id="chk84" type="checkbox" name="option[]" value="Greece">Greece</label>
									<label ><input id="chk85" type="checkbox" name="option[]" value="Greenland">Greenland</label>
									<label><input id="chk86" type="checkbox" name="option[]" value="Grenada">Grenada</label>
									<label><input id="chk87" type="checkbox" name="option[]" value="Guadeloupe">Guadeloupe</label>
									<label ><input id="chk88" type="checkbox" name="option[]" value="Guam">Guam</label>
									<label ><input id="chk89" type="checkbox" name="option[]" value="Guatemala">Guatemala</label>
									<label ><input id="chk90" type="checkbox" name="option[]" value="Guernsey">Guernsey</label>
									<label><input id="chk91" type="checkbox" name="option[]" value="Guinea">Guinea</label>
									<label ><input id="chk92" type="checkbox" name="option[]" value="Guinea-Bissau">Guinea-Bissau</label>
									<label ><input id="chk93" type="checkbox" name="option[]" value="Guyana">Guyana</label>
									<label ><input id="chk94" type="checkbox" name="option[]" value="Haiti">Haiti</label>
									<label ><input id="chk95" type="checkbox" name="option[]" value="Heard Island and Mcdonald Islands">Heard Island and Mcdonald Islands</label>
									<label><input id="chk96" type="checkbox" name="option[]" value="Holy See (Vatican City State)">Holy See (Vatican City State)</label>
									<label><input id="chk97" type="checkbox" name="option[]" value="Hong Kong">Hong Kong</label>
									<label ><input id="chk98" type="checkbox" name="option[]" value="Hungary">Hungary</label>
									<label ><input id="chk99" type="checkbox" name="option[]" value="Iceland">Iceland</label>
									<label ><input id="chk100" type="checkbox" name="option[]" value="India">India</label>
									<label ><input id="chk101" type="checkbox" name="option[]" value="Indonesia">Indonesia</label>
									<label ><input id="chk102" type="checkbox" name="option[]" value="Iran Islamic Republic of">Iran Islamic Republic of</label>
									<label ><input id="chk103" type="checkbox" name="option[]" value="Iraq">Iraq</label>
									<label ><input id="chk104" type="checkbox" name="option[]" value="Ireland">Ireland</label>
									<label ><input id="chk105" type="checkbox" name="option[]" value="Isle of Man">Isle of Man</label>
									<label ><input id="chk106" type="checkbox" name="option[]" value="Israel">Israel</label>
									<label ><input id="chk107" type="checkbox" name="option[]" value="Italy">Italy</label>
									<label ><input id="chk108" type="checkbox" name="option[]" value="Jamaica">Jamaica</label>
									<label ><input id="chk109" type="checkbox" name="option[]" value="Japan">Japan</label>
									<label ><input id="chk110" type="checkbox" name="option[]" value="Jersey">Jersey</label>
									<label ><input id="chk111" type="checkbox" name="option[]" value="Jordan">Jordan</label>
									<label ><input id="chk112" type="checkbox" name="option[]" value="Kazakhstan">Kazakhstan</label>
									<label ><input id="chk113" type="checkbox" name="option[]" value="Kenya">Kenya</label>
									<label ><input id="chk114" type="checkbox" name="option[]" value="Kiribati">Kiribati</label>
									<label ><input id="chk115" type="checkbox" name="option[]" value="Korea Democratic People's Republic of">Korea Democratic People's Republic of</label>
									<label ><input id="chk116" type="checkbox" name="option[]" value="Korea Republic of">Korea, Republic of</label>
									<label ><input id="chk117" type="checkbox" name="option[]" value="Kosovo">Kosovo</label>
									<label ><input id="chk118" type="checkbox" name="option[]" value="Kuwait">Kuwait</label>
									<label ><input id="chk119" type="checkbox" name="option[]" value="Kyrgyzstan">Kyrgyzstan</label>
									<label ><input id="chk120" type="checkbox" name="option[]" value="Lao People's Democratic Republic">Lao People's Democratic Republic</label>
									<label ><input id="chk121" type="checkbox" name="option[]" value="Latvia">Latvia</label>
									<label ><input id="chk122" type="checkbox" name="option[]" value="Lebanon">Lebanon</label>
									<label ><input id="chk123" type="checkbox" name="option[]" value="Lesotho">Lesotho</label>
									<label ><input id="chk124" type="checkbox" name="option[]" value="Liberia">Liberia</label>
									<label ><input id="chk125" type="checkbox" name="option[]" value="Libyan Arab Jamahiriya">Libyan Arab Jamahiriya</label>
									<label ><input id="chk126" type="checkbox" name="option[]" value="Liechtenstein">Liechtenstein</label>
									<label ><input id="chk127" type="checkbox" name="option[]" value="Lithuania">Lithuania</label>
									<label ><input id="chk128" type="checkbox" name="option[]" value="Luxembourg">Luxembourg</label>
									<label><input id = "chk129" type = "checkbox" name = "option[]" value = "Macao" > Macao </label>
									<label><input id = "chk120" type = "checkbox" name = "option[]" value = " Macedonia the Former Yugoslav Republic" > Macedonia the Former Yugoslav Republic</label >
									<label><input id = "chk131" type = "checkbox" name = "option[]" value = "Madagascar" > Madagascar </label >
									<label><input id = "chk132" type = "checkbox" name = "option[]" value = "Malawi" > Malawi </label >
									<label><input id = "chk133" type = "checkbox" name = "option[]" value = "Malaysia" > Malaysia </label >
									<label><input id = "chk134" type = "checkbox" name = "option[]" value = "Maldives" > Maldives </label >
									<label><input id = "chk135" type = "checkbox" name = "option[]" value = "Mali" > Mali </label >
									<label><input id = "chk136" type = "checkbox" name = "option[]" value = "Malta" > Malta </label >
									<label><input id = "chk137" type = "checkbox" name = "option[]" value = "Marshall Islands" > Marshall Islands</label >
									<label><input id = "chk138" type = "checkbox" name = "option[]" value = "Martinique" > Martinique </label >
									<label><input id = "chk139" type = "checkbox" name = "option[]" value = "Mauritania" > Mauritania </label >
									<label><input id = "chk140" type = "checkbox" name = "option[]" value = "Mauritius" > Mauritius </label >
									<label><input id = "chk141" type = "checkbox" name = "option[]" value = "Mayotte" > Mayotte </label >
									<label><input id = "chk142" type = "checkbox" name = "option[]" value = "Mexico" > Mexico </label >
									<label><input id = "chk143" type = "checkbox" name = "option[]" value = "Micronesia" > Micronesia </label >
									<label><input id = "chk144" type = "checkbox" name = "option[]" value = "Moldova Republic " > Moldova Republic</label >
									<label><input id = "chk145" type = "checkbox" name = "option[]" value = "Monaco" > Monaco </label >
									<label><input id = "chk146" type = "checkbox" name = "option[]" value = "Mongolia" > Mongolia </label >
									<label><input id = "chk147" type = "checkbox" name = "option[]" value = "Montenegro" > Montenegro </label >
									<label><input id = "chk148" type = "checkbox" name = "option[]" value = "Montserrat" > Montserrat </label >
									<label><input id = "chk149" type = "checkbox" name = "option[]" value = "Morocco" > Morocco </label >
									<label><input id = "chk150" type = "checkbox" name = "option[]" value = "Mozambique" > Mozambique </label >
									<label><input id = "chk151" type = "checkbox" name = "option[]" value = "Myanmar" > Myanmar </label >
									<label><input id = "chk152" type = "checkbox" name = "option[]" value = "Namibia" > Namibia </label >
									<label><input id = "chk153" type = "checkbox" name = "option[]" value = "Nauru" > Nauru </label >
									<label><input id = "chk154" type = "checkbox" name = "option[]" value = "Nepal" > Nepal </label >
									<label><input id = "chk155" type = "checkbox" name = "option[]" value = "Netherlands" > Netherlands </label >
									<label><input id = "chk156" type = "checkbox" name = "option[]" value = "Netherlands Antilles" > Netherlands Antilles </label >
									<label><input id = "chk157" type = "checkbox" name = "option[]" value = "New Caledonia" > New Caledonia </label >
									<label><input id = "chk158" type = "checkbox" name = "option[]" value = "New Zealand" > New Zealand </label >
									<label><input id = "chk159" type = "checkbox" name = "option[]" value = "Nicaragua" > Nicaragua </label >
									<label><input id = "chk160" type = "checkbox" name = "option[]" value = "Nigeria" > Nigeria </label >
									<label><input id = "chk161" type = "checkbox" name = "option[]" value = "Niue" > Niue </label >
									<label><input id = "chk162" type = "checkbox" name = "option[]" value = "Norfolk Island"> Norfolk Island </label >
									<label><input id = "chk163" type = "checkbox" name = "option[]" value = "Northern Mariana Islands" > Northern Mariana Islands</label >
									<label><input id = "chk164" type = "checkbox" name = "option[]" value = "Norway"> Norway </label >
									<label><input id = "chk165" type = "checkbox" name = "option[]" value = "Oman" > Oman </label >
									<label><input id = "chk166" type = "checkbox" name = "option[]" value = "Pakistan" > Pakistan </label >
									<label><input id = "chk167" type = "checkbox" name = "option[]" value = "Palau" > Palau </label >
									<label><input id = "chk168" type = "checkbox" name = "option[]" value = "Palestinian Territory" > Palestinian Territory</label>
									<label><input id = "chk169" type = "checkbox" name = "option[]" value = "Papua New Guinea" > Papua New Guinea </label >
									<label><input id = "chk170" type = "checkbox" name = "option[]" value = "Paraguay" > Paraguay </label >
									<label><input id = "chk171" type = "checkbox" name = "option[]" value = "Peru" > Peru </label >
									<label><input id = "chk172" type = "checkbox" name = "option[]" value = "Philippines" > Philippines </label >
									<label><input id = "chk173" type = "checkbox" name = "option[]" value = "Pitcairn" > Pitcairn </label >
									<label><input id = "chk174" type = "checkbox" name = "option[]" value = "Poland" > Poland </label >
									<label><input id = "chk175" type = "checkbox" name = "option[]" value = "Portugal" > Portugal </label >
									<label><input id = "chk176" type = "checkbox" name = "option[]" value = "Puerto Rico" > Puerto Rico </label >
									<label><input id = "chk177" type = "checkbox" name = "option[]" value = "Qatar" > Qatar </label >
									<label><input id = "chk178" type = "checkbox" name = "option[]" value = "Reunion" > Reunion </label >
									<label><input id = "chk179" type = "checkbox" name = "option[]" value = "Romania" > Romania </label >
									<label><input id = "chk180" type = "checkbox" name = "option[]" value = "Russian Federation" > Russian Federation </label >
									<label><input id = "chk181" type = "checkbox" name = "option[]" value = "Rwanda" > Rwanda </label >
									<label><input id = "chk182" type = "checkbox" name = "option[]" value = "Saint Barthelemy" > Saint Barthelemy </label >
									<label><input id = "chk183" type = "checkbox" name = "option[]" value = "Saint Helena" > Saint Helena </label >
									<label><input id = "chk184" type = "checkbox" name = "option[]" value = "Saint Kitts and Nevis" > Saint Kitts and Nevis </label >
									<label><input id = "chk185" type = "checkbox" name = "option[]" value = "Saint Lucia" > Saint Lucia </label >
									<label><input id = "chk186" type = "checkbox" name = "option[]" value = "saint Martin" > saint Martin</label >
									<label><input id = "chk187" type = "checkbox" name = "option[]" value = "Saint Pierre and Miquelon" > Saint Pierre and Miquelon </label >
									<label><input id = "chk188" type = "checkbox" name = "option[]" value = "Saint Vincent and the Grenadines" > Saint Vincent and the Grenadines </label >
									<label><input id = "chk189" type = "checkbox" name = "option[]" value = "Samoa" > Samoa </label >
									<label><input id = "chk190" type = "checkbox" name = "option[]" value = "San Marino" > SSan Marino </label >
									<label><input id = "chk191" type = "checkbox" name = "option[]" value = "Sao Tome and Principe" > Sao Tome and Principe </label >
									<label><input id = "chk192" type = "checkbox" name = "option[]" value = "Saudi Arabia" > Saudi Arabia </label >
									<label><input id = "chk193" type = "checkbox" name = "option[]" value = "Senegal" > Senegal </label >
									<label><input id = "chk194" type = "checkbox" name = "option[]" value = "Serbia" > Serbia </label >
									<label><input id = "chk195" type = "checkbox" name = "option[]" value = "Serbia and Montenegro" > Serbia and Montenegro </label >
									<label><input id = "chk196" type = "checkbox" name = "option[]" value = "Seychelles" > Seychelles </label >
									<label><input id = "chk197" type = "checkbox" name = "option[]" value = "Sierra Leone" > Sierra Leone </label >
									<label><input id = "chk198" type = "checkbox" name = "option[]" value = "Singapore" > Singapore </label >
									<label><input id = "chk199" type = "checkbox" name = "option[]" value = "Sint Maarten" > Sint Maarten </label >
									<label><input id = "chk200" type = "checkbox" name = "option[]" value = "Slovakia" > Slovakia </label >
									<label><input id = "chk201" type = "checkbox" name = "option[]" value = "Slovenia" > Slovenia </label >
									<label><input id = "chk202" type = "checkbox" name = "option[]" value = "Solomon Islands" > Solomon Islands </label >
									<label><input id = "chk203" type = "checkbox" name = "option[]" value = "South Africa" > South Africa </label >
									<label><input id = "chk204" type = "checkbox" name = "option[]" value = "South Georgia and the South Sandwich Islands" > South Georgia and the South Sandwich Islands </label >
									<label><input id = "chk205" type = "checkbox" name = "option[]" value = "South Sudan" > South Sudan</label >
									<label><input id = "chk206" type = "checkbox" name = "option[]" value = "Spain" > Spain </label >
									<label><input id = "chk207" type = "checkbox" name = "option[]" value = "Sri Lanka" > Sri Lanka</label >
									<label><input id = "chk208" type = "checkbox" name = "option[]" value = "Sudan" > Sudan </label >
									<label><input id = "chk209" type = "checkbox" name = "option[]" value = "Suriname" > Suriname </label >
									<label><input id = "chk210" type = "checkbox" name = "option[]" value = "Svalbard and Jan Mayen" > Svalbard and Jan Mayen</label >
									<label><input id = "chk211" type = "checkbox" name = "option[]" value = "Swaziland" > Swaziland </label >
									<label><input id = "chk212" type = "checkbox" name = "option[]" value = "Sweden" > Sweden </label >
									<label><input id = "chk213" type = "checkbox" name = "option[]" value = "Switzerland" > Switzerland </label >
									<label><input id = "chk214" type = "checkbox" name = "option[]" value = "Syrian Arab Republic" > Syrian Arab Republic </label >
									<label><input id = "chk215" type = "checkbox" name = "option[]" value = "Taiwan" > Taiwan </label >
									<label><input id = "chk216" type = "checkbox" name = "option[]" value = "Tajikistan" > Tajikistan </label >
									<label><input id = "chk217" type = "checkbox" name = "option[]" value = "Tanzania" > Tanzania </label >
									<label><input id = "chk218" type = "checkbox" name = "option[]" value = "Thailand" > Thailand </label >
									<label><input id = "chk219" type = "checkbox" name = "option[]" value = "Timor - Leste" > Timor - Leste </label >
									<label><input id = "chk220" type = "checkbox" name = "option[]" value = "Togo" > Togo </label >
									<label><input id = "chk221" type = "checkbox" name = "option[]" value = "Tokelau" > Tokelau </label >
									<label><input id = "chk222" type = "checkbox" name = "option[]" value = "Tonga" > Tonga </label >
									<label><input id = "chk223" type = "checkbox" name = "option[]" value = " Trinidad and Tobago" > Trinidad and Tobago</label >
									<label><input id = "chk224" type = "checkbox" name = "option[]" value = "Tunisia" > Tunisia </label >
									<label><input id = "chk225" type = "checkbox" name = "option[]" value = "Turkey" > Turkey </label >
									<label><input id = "chk226" type = "checkbox" name = "option[]" value = "Turkmenistan" > Turkmenistan </label >
									<label><input id = "chk227" type = "checkbox" name = "option[]" value = "Turks and Caicos Islands" > Turks and Caicos Islands</label>
									<label><input id = "chk228" type = "checkbox" name = "option[]" value = "Tuvalu" > Tuvalu </label >
									<label><input id = "chk229" type = "checkbox" name = "option[]" value = "Uganda" > Uganda </label >
									<label><input id = "chk230" type = "checkbox" name = "option[]" value = "Ukraine" > Ukraine </label >
									<label><input id = "chk231" type = "checkbox" name = "option[]" value = "United Arab Emirates" > United Arab Emirates</label >
									<label><input id = "chk232" type = "checkbox" name = "option[]" value = "United Kingdom" > United Kingdom</label>
									<label><input id = "chk233" type = "checkbox" name = "option[]" value = "United States" > United States</label>
									<label><input id = "chk234" type = "checkbox" name = "option[]" value = "United States Minor Outlying Islands" > United States Minor Outlying Islands </label >
									<label><input id = "chk235" type = "checkbox" name = "option[]" value = "Uruguay" > Uruguay </label >
									<label><input id = "chk236" type = "checkbox" name = "option[]" value = "Uzbekistan" > Uzbekistan </label >
									<label><input id = "chk237" type = "checkbox" name = "option[]" value = "Vanuatu" > Vanuatu </label >
									<label><input id = "chk238" type = "checkbox" name = "option[]" value = "Venezuela" > Venezuela </label >
									<label><input id = "chk239" type = "checkbox" name = "option[]" value = "Viet Nam" > Viet Nam</label>
									<label><input id = "chk240" type = "checkbox" name = "option[]" value = "Virgin Islands British" > Virgin Islands, British</label>
									<label><input id = "chk241" type = "checkbox" name = "option[]" value = "Virgin Islands" > Virgin Islands</label>
									<label><input id = "chk242" type = "checkbox" name = "option[]" value = "Western Sahara" > Western Sahara</label>
									<label><input id = "chk243" type = "checkbox" name = "option[]" value = "Yemen" > Yemen </label >
									<label><input id = "chk244" type = "checkbox" name = "option[]" value = "Zambia" > Zambia </label >
									<label><input id = "chk245" type = "checkbox" name = "option[]" value = "Zimbabwe" > Zimbabwe </label >
                            </div>
                        </div>
                        
                    </div>
                </div>
                
                <div class="col-sm-6">
                    <div class="position-relative row form-group">
                        <div class="col-12 mt-2">
                            <label for="exampleFile" class=" col-form-label">Select Education Levels:</label>
                        </div>
                    </div>
                    <div class="position-relative row form-group">
                        <div class="col-12 mt-2">
                            
                            <div id="chkmain1" class="multiselect">
                            <label><input id="chk11" type="checkbox" name="option[]" value="Matric" />Matric</label>
                            <label><input id="chk22" type="checkbox" name="option[]" value="Inter" />Inter</label>
                            <label><input id="chk33" type="checkbox" name="option[]" value="Bachelor" />Bachelor</label>
                            <label><input id="chk44" type="checkbox" name="option[]" value="Master" />Master</label>
                            <label><input id="chk55" type="checkbox" name="option[]" value="M_Phil" />M Phil</label>
                            <label><input id="chk66" type="checkbox" name="option[]" value="PhD" />PhD</label>
                            </div>
                        
                        </div>
                    </div>
                </div>
            </div>
            
            <div class="position-relative row form-group">
                <div class="position-relative row form-group col-12 mt-2"><label for="exampleFile" class="col-sm-12 col-form-label">AD Image:</label>
                    <div class="col-sm-10"><input id="upload-pic" name="file" ref="fileInput" accept="image/*" @change="onFilePicked($event)" type="file" class="form-control-file" required>
                        </div>
                </div>
            </div>
            
            <div class="position-relative row form-group">
            <div align="center" class="col-sm-12 mt-3">
            <button v-if="submitbtntrue" v-on:click.prevent="submit" class="btn btn-secondary">Submit</button>
            <button v-if="editbtntrue" v-on:click.prevent="updateOnClick(d.id)" class="btn btn-secondary">Update</button>
            </div>
            </div>
            </div>
        </form>
         <div class="row">
        <div class="col-md-12">
            <div class="main-card mb-3 card">
                <div class="card-header">
                    <h5><b>Manage your Ads</b></h5>
                </div>
                <div class="table-responsive">
                    <table class="align-middle mb-0 table table-borderless table-striped table-hover">
                    <thead>
                        <tr>
                        <th class="text-center">ID</th>
                        <th class="text-center">Date</th>
                        <th class="text-center">Title</th>
                        
                        <th class="text-center">Edit</th>
                        <th class="text-center">Delete</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for="s in adslist" :key="s">
                            <td class="text-center">{{s.id}}</td>
                            <td class="text-center text-muted">{{s.dates}}</td>
                            <td class="text-center">{{s.title}}</td>
                            
                            <td class="text-center">
                                <button v-on:click.prevent="updatedClick(s.id)"  type="button" id="PopoverCustomT-1" class="btn btn-primary btn-sm"><i class="fa fa-edit"> </i> Edit</button>
                            </td>
                            <td class="text-center">
                                <button type="button" id="PopoverCustomT-1" v-on:click.prevent="deleteClick(s.id)" class="btn btn-primary btn-sm  bg-danger"><i class="pe-7s-trash"> </i> Delete</button>
                            </td>
                        </tr>
                        
                    </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
</div>
        
 
</template>
<script>
import config from '@/../config'

import { create } from 'ipfs-http-client';

import { Buffer } from 'buffer';
import AdsData from '@/AdsDatabase.json'
export default {
    props:['emailsession','emails'],
    data () {
        return {
            file:"",
            addata: AdsData,
            title: "",
            adsdetail: "",
            key1value: "",
            key2value: "",
            submitbtntrue: true,
            editbtntrue: false,
            arr: [],
            arr2: [],
            inc: 0,
            inc1: 0,
             adslist: undefined,
             adslist1: [{"Title":"","Country":"b","Educationlevel":"c","Detail":"","imageurl":"e"}],
             
            projectId: '2DBOP6lMpJJXMfPYTHHbUprAtAA',
            projectSecret : 'c47db02a18967d4b6b1758b83a53ffb8',
            token:""
        }
    },
	components: {
  },
    async mounted () {
        this.token=localStorage.getItem("token");

      ////console.log(this.emails)
        await this.axios.get(config.hostname+'api/addsinfo/Getbyemail/' + this.emails ,
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
              .then((response) => {
                this.adslist = response.data
                //////console.log(this.adslist)
                 })
    },
    methods: {
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
        onChange(event) {
            this.key1value=event.target.value
            this.arr[this.inc] =  this.key1value
            this.inc++
            ////console.log(this.arr)
        },
        onChangess(event) {
            this.key2value=event.target.value
            this.arr2[this.inc1] =  this.key2value
            this.inc1++
            ////console.log(this.arr2)
        },
        async submit () {
            var url= await this.uploadToIpfs(this.file);
            //console.log("Url from Ads Uni");
            //console.log(url);
            var selected = new Array();
            var selected1 = new Array();
        //Reference the Table.
        var chkmain = document.getElementById("chkmain");
        var chkmain1 = document.getElementById("chkmain1");
        //Reference all the CheckBoxes in Table.
        var chks = chkmain.getElementsByTagName("INPUT");
        var chks1 = chkmain1.getElementsByTagName("INPUT");
 
        // Loop and push the checked CheckBox value in Array.
        for (var i = 0; i < chks.length; i++) {
            if (chks[i].checked) {
                selected.push(chks[i].value);
            }
        }
        for (var j = 0; j < chks1.length; j++) {
            if (chks1[j].checked) {
                selected1.push(chks1[j].value);
            }
        }
 
        //Display the selected CheckBox values.
       // if (selected.length > 0) {
       //     alert("Selected values: " + selected.join(","));
      //  }
       //  if (selected1.length > 0) {
//alert("Selected1 values: " + selected1.join(","));
      //  }
            this.tilt = document.getElementById('tilt').value
            this.det = document.getElementById('det').value
            ////console.log(this.tilt,this.emails,this.det,this.arr,this.arr2)
            const fd =new FormData()
            fd.append("Title",this.tilt)
            fd.append("Detail",this.det)
            fd.append("email",this.emails)
            fd.append("Educationlevel",selected1.join(","))
            fd.append("Country",selected.join(","))
            fd.append('imageurlbase64', url)
            ////console.log(fd)
             if( this.file!="" && this.tilt!="" && this.det!="" && this.email!="")
            {
            await this.axios.post(config.hostname+'api/addsinfo/PostByadd/',fd ,
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
          .then((response) => {
            alert(response.data)
          }) }
          else{
              alert("All Fields are Required !")
          }    
        },
        async updateOnClick (id){
            //console.log("Url from Ads checking");
            var url= await this.uploadToIpfs(this.file);
            //console.log("Url from Ads ");
            //console.log(url);
            var selected = new Array();
            var selected1 = new Array();
        //Reference the Table.
        var chkmain = document.getElementById("chkmain");
        var chkmain1 = document.getElementById("chkmain1");
        //Reference all the CheckBoxes in Table.
        var chks = chkmain.getElementsByTagName("INPUT");
        var chks1 = chkmain1.getElementsByTagName("INPUT");
 
        // Loop and push the checked CheckBox value in Array.
        for (var i = 0; i < chks.length; i++) {
            if (chks[i].checked) {
                selected.push(chks[i].value);
            }
        }
        for (var j = 0; j < chks1.length; j++) {
            if (chks1[j].checked) {
                selected1.push(chks1[j].value);
            }
        }
 
        //Display the selected CheckBox values.
  //      if (selected.length > 0) {
  // //         alert("Selected values: " + selected.join(","));
  //      }
//if (selected1.length > 0) {
  //          alert("Selected1 values: " + selected1.join(","));
//}
            this.tilt = document.getElementById('tilt').value
            this.det = document.getElementById('det').value
            ////console.log(this.tilt,this.emails,this.det,this.arr,this.arr2)
            await this.axios.put(config.hostname+'api/addsinfo/Putaddbyid/', {
            id: id,
            Title: this.tilt,
            Detail: this.det,
            Educationlevel: selected1.join(","),
            imageurl:"abc",
            Country: selected.join(",")
        } ,
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
          .then((response) => {
            alert(response.data)
          })

            if(this.file != ""){
             const fd =new FormData()
            fd.append("email",this.emails)
            fd.append("id",id)
            fd.append('imageurlbase64', url)
            ////console.log(fd)
            await this.axios.post(config.hostname+'api/addsinfo/savepic/',fd ,
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


          
        },
        async deleteClick (id) {
          if (!confirm('Are you sure?')) {
        return
      }
      await this.axios.delete(config.hostname+'api/addsinfo/' + id ,
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
        .then((response) => {
          alert(response.data)
        })
      },
      async updatedClick (id) {
          this.submitbtntrue=false
          this.editbtntrue=true
        await this.axios.get(config.hostname+'api/addsinfo/Getbyid/' + id  ,
      {headers:{
        Accept: 'application/json',
        'Content-type':'application/json',
        Authorization:`Bearer ${this.token}`
      }})
              .then((response) => {
                this.adslist1 = response.data
                ////console.log(this.adslist1)
                 })
      },
    onFilePicked (event) {
        this.file = event.target.files[0]
        }
    }
}
</script>
