<template>
  <div>
    <button @click="submit">打印</button>
    <hot-table :settings="settings"/>
    <br>
    <hot-table :data="data" :rowHeaders="true" :colHeaders="true" licenseKey='non-commercial-and-evaluation'></hot-table>
  </div>
</template>

<script>
import { HotTable } from "@handsontable/vue";
import "handsontable/dist/handsontable.full.css";
import Handsontable from "handsontable";

export default {
  components: {
    HotTable
  },
  data: function() {
    return {
      data: [
        ["年份\\品牌", "Tesla", "Mercedes", "Toyota", "Volvo"],
        ["2019", 10, 11, 12, 13],
        ["2020", 20, 11, 14, 13],
        ["2021", 30, 15, 12, 13]
      ],
      settings: {
        data: Handsontable.helper.createSpreadsheetData(6, 10),
        rowHeaders: true,
        colHeaders: true,
        licenseKey: "non-commercial-and-evaluation"
      }
    }
  },
  methods: {
    submit() {
      // eslint-disable-next-line no-console
      console.log(this.settings)
    }
  }
};
</script>

<style>

</style>
