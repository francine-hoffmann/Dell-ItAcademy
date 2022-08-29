
<template>
  <h1>Produtos Item componente</h1>
    <template v-for="r in remedios" :key="r.nome" > 
        <ul v-if="r.valido === true" >
            <li>
            {{r.nome}}-{{r.labatorio}}
            <img v-bind:src="r.img" widht="20" height="40"/>
            </li>
        </ul>
    </template>
</template>

<script setup >
import { onMounted, reactive } from "vue";

name:"ProductsItem";

onMounted(() =>{
    console.log (`console montado`)

})

    const remedios = reactive([
    {
        id: 1,
        nome: "Revotril",
        labatorio:"ache",
        valido:true,
        img:"http://picsum.photos/200"

    },
    {
        id: 2,
        nome: "Fluoxetina",
        labatorio:"ache",
        valido:false,
        img:"http://picsum.photos/200"

    },
    {
        id: 3,
        nome: "Revoc",
        labatorio:"Lifar",
        valido:true,
        img:"http://picsum.photos/200"

    }
    ])
</script>

<style scoped>

</style>