var conf_chart = [];
var max_dd = 0;
$(document).ready(function(){
	$(".page-content .menu-item").click(function(){
		$(".page-content .menu-item").each(function(i,v){
			$(this).removeClass("active");
		});
		$(this).addClass("active");
	});
	var data_date = [];
	for (var i = 0; i < 30; i++) {
		let idx = (i+1);
		data_date.push(
		{
      	  "start": idx+"/04/2019 00:00:00",
      	  "end": idx+"/04/2019 23:59:59",
      	  "label": idx+"",
      	  "bgcolor": "#ffffff",
      	});
	}
	$("#chart-month").insertFusionCharts({
	   type: "gantt",
	   width: "100%",
	   dataFormat: "json",
	   dataSource: {
	  "chart": {
	    "dateformat": "dd/mm/yyyy",
	    "theme": "fusion",
	    "canvasborderalpha": "40",
	    "ganttlinealpha": "50",
	    "xAxisNamePadding": "10",
        "yAxisNamePadding": "10",
        "flatScrollBars": "1",
        "scrollColor":"#666666",
        "ganttwidthpercent": "75",
        "ganttPaneDuration": "25",
        "ganttPaneDurationUnit": "d",
	  },
	  "tasks": {
	    "color": "#008000",
	    "task": [
	      {
	        "start": "01/04/2019",
	        "end": "16/04/2019",
	        "id":"1",
	        "processid": "1",
	      },
	      {
	        "start": "05/04/2019",
	        "end": "12/04/2019",
	        "id":"2",
	        "processid": "2",
	      },
	      {
	        "start": "01/04/2019",
	        "end": "16/04/2019",
	        "id":"2-1",
	        "processid": "2",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "19/04/2019",
	        "end": "29/04/2019",
	        "id":"3",
	        "processid": "3",
	      },
	      {
	        "start": "04/04/2019 00:00:00",
	        "end": "04/04/2019 23:59:59",
	        "id":"3-1",
	        "processid": "3",
	      },
	      {
	        "start": "05/04/2019 00:00:00",
	        "end": "05/04/2019 23:59:59",
	        "id":"3-2",
	        "processid": "3",
	      },
	      {
	        "start": "06/04/2019 00:00:00",
	        "end": "06/04/2019 23:59:59",
	        "id":"3-3",
	        "processid": "3",
	      },
	      {
	        "start": "07/04/2019 00:00:00",
	        "end": "07/04/2019 23:59:59",
	        "id":"3-4",
	        "processid": "3",
	      },
	      {
	        "start": "08/04/2019 00:00:00",
	        "end": "08/04/2019 23:59:59",
	        "id":"3-5",
	        "processid": "3",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "09/04/2019 00:00:00",
	        "end": "09/04/2019 23:59:59",
	        "id":"3-6",
	        "processid": "3",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "10/04/2019 00:00:00",
	        "end": "10/04/2019 23:59:59",
	        "id":"3-7",
	        "processid": "3",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "11/04/2019 00:00:00",
	        "end": "11/04/2019 23:59:59",
	        "id":"3-8",
	        "processid": "3",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "12/04/2019 00:00:00",
	        "end": "12/04/2019 23:59:59",
	        "id":"3-8",
	        "processid": "3",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "13/04/2019 00:00:00",
	        "end": "13/04/2019 23:59:59",
	        "id":"3-9",
	        "processid": "3",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "03/04/2019",
	        "end": "11/04/2019",
	        "id":"4",
	        "processid": "4",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "09/04/2019",
	        "end": "12/04/2019",
	        "id":"5",
	        "processid": "5",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "18/04/2019",
	        "end": "21/04/2019",
	        "id":"6",
	        "processid": "6",
	        "color":"#DD0000"
	      },
	      {
	        "start": "22/04/2019",
	        "end": "23/04/2019",
	        "id":"7",
	        "processid": "7",
	        "color":"#F2C32A"
	      },
	    ]
	  },
	  "processes": {
	    "headeralign": "left",
	    "fontsize": "14",
	    "isbold": "0",
	    "align": "left",
	    "headerbgcolor": "#ffffff",
	    "process": [
	      {
	        "label": "ตรวจตามแผนเฝ้าระวัง",
	        "id":"1"
	      },
	      {
	        "label": "เก็บตัวอย่าง",
	        "id":"2"
	      },
	      {
	        "label": "ตรวจสอบสถานที่ประจำเดือน",
	        "id":"3"
	      },
	      {
	        "label": "กลุ่มเสี่ยง - ขายส่ง",
	        "id":"4"
	      },
	      {
	        "label": "รายการต่ออายุ",
	        "id":"5"
	      },
	      {
	        "label": "GMP : ความเสี่ยงสูง",
	        "id":"6"
	      },
	      {
	        "label": "GMP : ความเสี่ยงสูง",
	        "id":"7"
	      }
	    ]
	  },
	  "categories": [
	    {
	      "category": data_date
	    }
	  ]}
	});
	$("#chart-line").insertFusionCharts({
	    type: 'msline',
        renderAt: 'chart-line',
        width: '100%',
        dataFormat: 'json',
        dataSource: {
          "chart": {
            "theme": "fusion",
            "showLegend": "0"
          },
          "categories": [{
            "category": [{
                "label": "ม.ค."
              },
              {
                "label": "ก.พ."
              },
              {
                "label": "มี.ค."
              },
              {
                "label": "เม.ย."
              },
              {
                "label": "มิ.ย."
              },
              {
                "label": "ก.ค."
              },
              {
                "label": "ส.ค."
              },
              {
                "label": "ต.ค."
              }
            ]
          }],
          "dataset": [{
              "seriesname": "2557",
              "color":"#430089",
              "data": [
              	{
                  "value": "18"
                },
                {
                  "value": "29"
                },
                {
                  "value": "34"
                },
                {
                  "value": "45"
                },
                {
                  "value": "47"
                },
                {
                  "value": "42"
                },
                {
                  "value": "59"
                },
                {
                  "value": "80"
                }
              ]
            },
            {
              "seriesname": "2558",
              "color":"#008B06",
              "data": [
              	{
                  "value": "20"
                },
                {
                  "value": "27"
                },
                {
                  "value": "37"
                },
                {
                  "value": "35"
                },
                {
                  "value": "40"
                },
                {
                  "value": "59"
                },
                {
                  "value": "27"
                },
                {
                  "value": "10"
                }
              ]
            },
            {
              "seriesname": "2559",
              "color":"#FFD000",
              "data": [
              	{
                  "value": "80"
                },
                {
                  "value": "75"
                },
                {
                  "value": "55"
                },
                {
                  "value": "30"
                },
                {
                  "value": "68"
                },
                {
                  "value": "7"
                },
                {
                  "value": "22"
                },
                {
                  "value": "99"
                }
              ]
            },
            {
              "seriesname": "2560",
              "color":"#DD0000",
              "data": [
              	{
                  "value": "29"
                },
                {
                  "value": "99"
                },
                {
                  "value": "55"
                },
                {
                  "value": "76"
                },
                {
                  "value": "12"
                },
                {
                  "value": "80"
                },
                {
                  "value": "87"
                },
                {
                  "value": "91"
                }
              ]
            },
            {
              "seriesname": "2561",
              "color":"#0E9EDD",
              "data": [
              	{
                  "value": "12"
                },
                {
                  "value": "36"
                },
                {
                  "value": "99"
                },
                {
                  "value": "77"
                },
                {
                  "value": "63"
                },
                {
                  "value": "87"
                },
                {
                  "value": "34"
                },
                {
                  "value": "12"
                }
              ]
            },
          ]
        }
	});
	$("setchart item_chart").each(function(i,v){
		conf_chart[i] = {};
		conf_chart[i].label = $(this).find("label").text();
		conf_chart[i].value = $(this).find("value").text();
		conf_chart[i].color = $(this).find("color").text();
		max_dd+=parseInt($(this).find("value").text());
	});
	$("#chart-donut").insertFusionCharts({
	  type: "doughnut2d",
	  width: "100%",
	  height: "300",
	  dataFormat: "json",
	  dataSource: {
	    chart: {
	      doughnutRadius:"65%",
	      caption: "",
	      subcaption: "",
	      showLegend: "0",
	      showpercentvalues: "1",
	      enableSmartLabels: "0",
	      showLabels:"0",
	      showValues:"0",
	      centerLabelFontSize: "18",
	      defaultcenterlabel: max_dd+" เรื่อง",
	      aligncaptionwithcanvas: "0",
	      captionpadding: "0",
	      decimals: "1",
	      plottooltext:
	        "<b>$percentValue</b> : $label",
	      centerlabel: "",
	      theme: "fusion",
	      chartTopMargin:"0",
	      chartLeftMargin:"0",
	      chartRightMargin:"0",
	      chartBottomMargin:"0",
	    },
	    data: conf_chart
	  }
	});
});