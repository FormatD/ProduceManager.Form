<template>
  <el-container style="height:100%; border: 1px solid #eee;">
    <el-aside width="200px" style="background-color: rgb(238, 241, 246)">
      <el-radio-group v-model="isCollapse" style="margin-bottom: 20px;">
        <el-radio-button :label="false">展开</el-radio-button>
        <el-radio-button :label="true">收起</el-radio-button>
      </el-radio-group>

      <el-menu
        :default-openeds="['1', '3']"
        class="menu"
        :collapse="isCollapse"
      >
        <el-submenu index="1">
          <template slot="title"
            ><i class="el-icon-message"></i>
            <router-link to="/">Main</router-link>
          </template>
          <el-menu-item-group>
            <template slot="title"
              >分组一</template
            >
            <el-menu-item index="1-1">
              <router-link to="/home">Home</router-link>
            </el-menu-item>
            <el-menu-item index="1-2">
              <router-link to="/about">About</router-link>
            </el-menu-item>
          </el-menu-item-group>
          <el-submenu index="1-4">
            <template slot="title"
              >选项4</template
            >
            <el-menu-item index="1-4-1"
              ><router-link to="/">Home</router-link></el-menu-item
            >
          </el-submenu>
        </el-submenu>
        <el-submenu index="1">
          <template slot="title"
            ><i class="el-icon-message"></i>
            XXX
          </template>
          <el-menu-item index="1-4-1"
            ><router-link to="/main">Main</router-link></el-menu-item
          >
        </el-submenu>
      </el-menu>
    </el-aside>

    <el-container>
      <el-header style="text-align: right; font-size: 12px">
        <el-dropdown>
          <i class="el-icon-setting" style="margin-right: 15px"></i>
          <el-dropdown-menu slot="dropdown">
            <el-dropdown-item>查看</el-dropdown-item>
            <el-dropdown-item>新增</el-dropdown-item>
            <el-dropdown-item>删除</el-dropdown-item>
          </el-dropdown-menu>
        </el-dropdown>
        <el-avatar icon="el-icon-user-solid"></el-avatar>
        <span>王小虎</span>
      </el-header>

      <el-main>
        <router-view />
      </el-main>
    </el-container>
  </el-container>
</template>

<script>
export default {
  name: "app",
  components: {},
  data: function() {
    return { isCollapse: false };
  }
};
</script>

<style lang="less">
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
.menu {
  padding: 30px;
  a {
    font-weight: bold;
    color: #2c3e50;
    &.router-link-exact-active {
      color: #42b983;
    }
  }
}
.el-main {
  border-top: #eee 1px solid;
}
</style>
