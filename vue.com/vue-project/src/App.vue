<script setup>
import { RouterLink, RouterView } from 'vue-router'
import Header from "@/components/Header.vue";
import Footer from "@/components/icons/Footer";

</script>

<template>
  <Header></Header>
  <div class="containner">
    <RouterView />
  </div>
  <Footer></Footer>
</template>

<style scoped>
.containner {
  position: relative;
  width: 100%;
  margin: 0 auto;
}
</style>
