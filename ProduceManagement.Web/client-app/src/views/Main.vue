<template>
  <el-container>
    <el-header>
      <el-page-header @back="goBack" content="详情页面"> </el-page-header>
    </el-header>
    <el-main>
      <el-row :gutter="20">
        <el-col :span="6"
          ><div class="grid-content bg-purple">
            <el-select
              v-model="value1"
              multiple
              filterable
              allow-create
              default-first-option
              placeholder="请选择"
            >
              <el-option
                v-for="item in options"
                :key="item.value"
                :label="item.label"
                :value="item.value"
              >
              </el-option>
            </el-select></div
        ></el-col>
        <el-col :span="6"><div class="grid-content bg-purple">BBB</div></el-col>
        <el-col :span="6"><div class="grid-content bg-purple">CCC</div></el-col>
        <el-col :span="6"
          ><div class="grid-content bg-purple">
            <el-button>Query</el-button>
          </div></el-col
        >
      </el-row>
      <el-table :data="tableData" style="width: 100%">
        <el-table-column prop="date" label="日期" width="180">
        </el-table-column>
        <el-table-column prop="name" label="姓名" width="180">
        </el-table-column>
        <el-table-column prop="address" label="地址"> </el-table-column>
      </el-table>
    </el-main>
  </el-container>
</template>
<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import { User, Option } from "../models/User";

export default class Home extends Vue {
  tableData: User[] = [
    {
      date: "2016-05-02",
      name: "王小虎",
      address: "上海市普陀区金沙江路 1518 弄"
    },
    {
      date: "2016-05-04",
      name: "王小虎",
      address: "上海市普陀区金沙江路 1517 弄"
    },
    {
      date: "2016-05-01",
      name: "王小虎",
      address: "上海市普陀区金沙江路 1519 弄"
    },
    {
      date: "2016-05-03",
      name: "王小虎",
      address: "上海市普陀区金沙江路 1516 弄"
    }
  ];
  options: Option[] = [
    {
      value: "选项1",
      label: "黄金糕"
    },
    {
      value: "选项2",
      label: "双皮奶"
    },
    {
      value: "选项3",
      label: "蚵仔煎"
    },
    {
      value: "选项4",
      label: "龙须面"
    },
    {
      value: "选项5",
      label: "北京烤鸭"
    }
  ];
}
</script>
