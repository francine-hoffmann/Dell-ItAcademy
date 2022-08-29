<template>
  <header>
    <img alt="Vue logo" class="logo" src="@/assets/logo.svg" width="60" height="60" />
    <TabMenu :model="items" />
  </header>
</template>

<script setup>
import {ref} from "vue";
name: "Header";
const active = ref(3);
const items = ref([
  {
    label: 'Home',
    icon: 'pi pi-fw pi-home',
    to: '/'
  },
  {
    label: 'Sobre',
    icon: 'pi pi-fw pi-id-card',
    to: '/about'
  },
  {
    label: 'Produtos',
    icon: 'pi pi-fw pi-pencil',
    to: '/products'
  },
  {
    label: 'Clientes',
    icon: 'pi pi-fw pi-prime',
    to: '/customer'
  },
  {
    label: '',
    icon: 'pi pi-fw pi-cog',
    to: '/settings'
  }
]);
</script>

<style scoped>
  header {
    display: flex;
    padding-right: calc(var(--section-gap) / 2);
  }
  .logo {
    margin: 0 2rem 0 0;
  }
</style>