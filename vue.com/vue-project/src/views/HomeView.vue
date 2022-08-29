<script setup>
</script>
<template>
<div>

<Card  class="containner-card" >
  <template #header>
    <img src="https://picsum.photos/200" style="height: 10rem" />
  </template>
  <template #title>
    Benvido ao Sistema de Cadastro
  </template>
  <template #subtitle>
    Pagina Home de exemplo para aula de Vue.ja
  </template>
  <template #content>
    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Inventore sed consequuntur error repudiandae numquam deserunt
      quisquam repellat libero asperiores earum nam nobis, culpa ratione quam perferendis esse, cupiditate neque quas!</p>
  </template>
  <template #footer>
  </template>
</Card>
</div>
</template>

<style scoped>
.containner-card{
  width: 90%;
  margin: 5%;
}
p {
  line-height: 1.5;
  margin:5%;
}
</style>

