
<template>
  <header>
      <nav>
        <RouterLink to="/">Home</RouterLink>
        <RouterLink to="/Carros">Carros</RouterLink>
        <RouterLink to="/Caminhoes">Caminhoes</RouterLink>
      </nav>
  </header>

  <RouterView />
</template>


<script>
export default{
  name:'App'
}
</script>