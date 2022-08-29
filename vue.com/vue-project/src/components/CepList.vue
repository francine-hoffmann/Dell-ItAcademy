<template>
<p>Numero do Cep</p>
<input v-model="cepNumber" placeholder="edit me"/>
<ul v-for="c in ListaCeps">
<li> {{c.cep}}- {{c.address_name}} - {{c.city}}</li>
</ul>
  
</template>

<script setup>
import { onMounted, onUpdated, reactive, ref } from "vue";
import http from"@/services/http.js";

name:"CepList";
const cepNumber = ref('');
let ListaCeps = reactive({ceps:[]})
onUpdated(async() =>{
    try{
        const {data}= await http.get(cepNumber.value);
        console.log(data);
        ListaCeps['cep'] = data;
    }catch (error){
        console.log(error);
    }
})


</script >

<style scoped>

</style>