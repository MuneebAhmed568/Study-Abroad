

<template>

  <Bar
    :chart-options="chartOptions"
    :chart-data="chartData"
    :chart-id="chartId"
    :dataset-id-key="datasetIdKey"
    :plugins="plugins"
    :css-classes="cssClasses"
    :styles="styles"
    :width="width"
    :height="height"
  />
</template>

<script>
//import config from '@/../../config'

import { Bar } from 'vue-chartjs'
import { Chart as ChartJS, Title, Tooltip, Legend, BarElement, CategoryScale, LinearScale } from 'chart.js'

ChartJS.register(Title, Tooltip, Legend, BarElement, CategoryScale, LinearScale)

export default {
  name: 'BarChart',
  components: { Bar },
  
  props: ['graphvalueconsultants','graphvalueconsultantsnews','graphvalueconsultantsads'],
   
  data() {
    return {  
          
      chartData: {
        labels: [ 'MyProfile', 'Ads', 'News' ],
        datasets: [ { backgroundColor: ['#3366cc', '#dc3912', '#ff9900'], data: [this.graphvalueconsultants, this.graphvalueconsultantsads, this.graphvalueconsultantsnews] } ]
      },
      chartOptions: {
        responsive: true,
        legend: {
        legend:false
  }
      },
      chartId: {
      type: String,
      default: 'bar-chart'
    },
    datasetIdKey: {
      type: String,
      default: 'label'
    },
    width: {
      type: Number,
      default: 400
    },
    height: {
      type: Number,
      default: 200
    },
    
    cssClasses: {
      default: '',
      type: String
    },
    styles: {
      type: Object,
      default: () => {}
    },
    plugins: {
      type: Object,
      default: () => {}
    }
    }

  },
  async mounted () {
      
   
     
                
    }
}
</script>