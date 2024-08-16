$(document).ready(function () {
    var CITIZEN_ID = "";
    runQuery2();
    function runQuery2() { //รับพารามิเตอร์จาก Query string
        CITIZEN_ID = QueryString("CITIZEN_ID");
    }
	$("#page-qsm .menu-item").click(function(){
		$("#page-qsm .menu-item").each(function(i,v){
			$(this).removeClass("active");
		});
		$(this).addClass("active");
	});
	$('#chart-donut').percentcircle({
		animate : true,
		diameter : 250,
		guage: 4,
		coverBg: '#fff',
		bgColor: '#f9e3c9',
		fillColor: '#F2C32A',
		percentSize: '15px',
		percentWeight: 'normal'
	});
	$('#chart-company').percentcircle({
		animate : true,
		diameter : 132,
		guage: 4,
		coverBg: '#fff',
		bgColor: '#f9e3c9',
		fillColor: '#F2C32A',
		percentSize: '15px',
		percentWeight: 'normal'
	});
	$("#chart-stat").insertFusionCharts({
	   type: "mscolumn2d",
	   width: "100%",
	   height: "100%",
	   dataFormat: "json",
	   dataSource: {
	  "chart": {
	    "formatnumberscale": "1",
	    "plottooltext": "<b>$dataValue</b>",
	    "theme": "fusion",
	    "drawcrossline": "1",
	     "showLegend": "0",
	     "palettecolors":"FBA900,930005,B55300,5B13A8"
	  },
	  "categories": [
	    {
	      "category": [
	        {
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
	          "label": "พ.ค."
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
	          "label": "ก.ย."
	        },
	        {
	          "label": "ต.ค."
	        },
	        {
	          "label": "พ.ย."
	        },
	        {
	          "label": "ธ.ค."
	        }
	      ]
	    }
	  ],
	  "dataset": [
	    {
	      "seriesname": "ร้องเรียน",
	      "data": [
	        {
	          "value": "65"
	        },
	        {
	          "value": "45"
	        },
	        {
	          "value": "73"
	        },
	        {
	          "value": "28"
	        },
	        {
	          "value": "57"
	        },
	        {
	          "value": "52"
	        },
	        {
	          "value": "30"
	        },
	        {
	          "value": "20"
	        },
	        {
	          "value": "80"
	        },
	        {
	          "value": "100"
	        },
	        {
	          "value": "34"
	        },
	        {
	          "value": "89"
	        }
	      ]
	    },
	    {
	      "seriesname": "ดำเนินคดี",
	      "data": [
	        {
	          "value": "79"
	        },
	        {
	          "value": "35"
	        },
	        {
	          "value": "68"
	        },
	        {
	          "value": "32"
	        },
	        {
	          "value": "42"
	        },
	        {
	          "value": "80"
	        },
	        {
	          "value": "10"
	        },
	        {
	          "value": "5"
	        },
	        {
	          "value": "40"
	        },
	        {
	          "value": "70"
	        },
	        {
	          "value": "90"
	        },
	        {
	          "value": "46"
	        }
	      ]
	    },
	    {
	      "seriesname": "อายัด",
	      "data": [
	        {
	          "value": "12"
	        },
	        {
	          "value": "75"
	        },
	        {
	          "value": "40"
	        },
	        {
	          "value": "60"
	        },
	        {
	          "value": "87"
	        },
	        {
	          "value": "100"
	        },
	        {
	          "value": "30"
	        },
	        {
	          "value": "15"
	        },
	        {
	          "value": "85"
	        },
	        {
	          "value": "33"
	        },
	        {
	          "value": "10"
	        },
	        {
	          "value": "18"
	        }
	      ]
	    },
	    {
	      "seriesname": "เรียกเก็บคืน",
	      "data": [
	        {
	          "value": "40"
	        },
	        {
	          "value": "25"
	        },
	        {
	          "value": "77"
	        },
	        {
	          "value": "23"
	        },
	        {
	          "value": "13"
	        },
	        {
	          "value": "40"
	        },
	        {
	          "value": "36"
	        },
	        {
	          "value": "32"
	        },
	        {
	          "value": "76"
	        },
	        {
	          "value": "40"
	        },
	        {
	          "value": "15"
	        },
	        {
	          "value": "24"
	        }
	      ]
	    }
	  ]
	}
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
              "seriesname": "การเข้าตรวจสอบ",
              "color":"#008B06",
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
              "seriesname": "Los Angeles Topanga",
              "color":"#DD0000",
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
            }
          ]
        }
	});
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
        "yAxisNamePadding": "10"
	  },
	  "tasks": {
	    "color": "#008000",

	    "task": [
	      {
	        "start": "01/01/2018",
	        "end": "30/06/2018",
	        "id":"1",
	        "processid": "1"
	      },
	      {
	        "start": "01/03/2018",
	        "end": "30/06/2018",
	        "id":"2",
	        "processid": "2"
	      },
	      {
	        "start": "01/08/2018",
	        "end": "31/10/2018",
	        "id":"2-1",
	        "processid": "2",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "01/01/2018",
	        "end": "31/01/2018",
	        "id":"3",
	        "processid": "3"
	      },
	      {
	        "start": "01/02/2018",
	        "end": "28/02/2018",
	        "id":"3-1",
	        "processid": "3"
	      },
	      {
	        "start": "01/03/2018",
	        "end": "31/03/2018",
	        "id":"3-2",
	        "processid": "3"
	      },
	      {
	        "start": "01/04/2018",
	        "end": "30/04/2018",
	        "id":"3-3",
	        "processid": "3"
	      },
	      {
	        "start": "01/05/2018",
	        "end": "31/05/2018",
	        "id":"3-4",
	        "processid": "3"
	      },
	      {
	        "start": "01/06/2018",
	        "end": "30/06/2018",
	        "id":"3-5",
	        "processid": "3",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "01/07/2018",
	        "end": "31/07/2018",
	        "id":"3-6",
	        "processid": "3",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "01/08/2018",
	        "end": "31/08/2018",
	        "id":"3-7",
	        "processid": "3",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "01/09/2018",
	        "end": "30/09/2018",
	        "id":"3-8",
	        "processid": "3",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "01/10/2018",
	        "end": "31/10/2018",
	        "id":"3-8",
	        "processid": "3",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "01/11/2018",
	        "end": "30/11/2018",
	        "id":"3-9",
	        "processid": "3",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "01/01/2018",
	        "end": "31/05/2018",
	        "id":"4",
	        "processid": "4",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "01/06/2018",
	        "end": "30/09/2018",
	        "id":"5",
	        "processid": "5",
	        "color":"#F2C32A"
	      },
	      {
	        "start": "01/09/2018",
	        "end": "31/12/2018",
	        "id":"6",
	        "processid": "6",
	        "color":"#DD0000"
	      },
	      {
	        "start": "01/05/2018",
	        "end": "31/8/2018",
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
	    "process": [
	      {
	        "label": "ตรวจตามแผนเฝ้าระวัง",
             "id": "1"
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
	      }
	      //{
	      //  "label": "GMP : ความเสี่ยงสูง",
	      //  "id":"7"
	      //}
	    ]
	  },
	  "categories": [
	    {
	      "category": [
	      	{
	      	  "start": "01/01/2018",
	      	  "end": "31/01/2018",
              "label": "ม.ค.",
              "link": "/Plan/SHOW_INVTGE_PLAN_DETAIL?MAIN_IDA=62062000129&CITIZEN_ID=" + CITIZEN_ID + "MONTH=1"

	      	},
	      	{
	      	  "start": "01/02/2018",
	      	  "end": "28/02/2018",
                    "label": "ก.พ.",
                    "link": "/Plan/SHOW_INVTGE_PLAN_DETAIL?MAIN_IDA=62062000129&CITIZEN_ID=" + CITIZEN_ID + "MONTH=1"
	      	},
	      	{
	      	  "start": "01/03/2018",
	      	  "end": "31/03/2018",
                    "label": "มี.ค.",
                    "link": "/Plan/SHOW_INVTGE_PLAN_DETAIL?MAIN_IDA=62062000129&CITIZEN_ID=" + CITIZEN_ID + "MONTH=1"
	      	},
	      	{
	      	  "start": "01/04/2018",
	      	  "end": "30/04/2018",
                    "label": "เม.ย.",
                    "link": "/Plan/SHOW_INVTGE_PLAN_DETAIL?MAIN_IDA=62062000129&CITIZEN_ID=" + CITIZEN_ID + "MONTH=1"
	      	},
	      	{
	      	  "start": "01/05/2018",
	      	  "end": "31/05/2018",
                    "label": "พ.ค.",
                    "link": "/Plan/SHOW_INVTGE_PLAN_DETAIL?MAIN_IDA=62062000129&CITIZEN_ID=" + CITIZEN_ID + "MONTH=1"
	      	},
	      	{
	      	  "start": "01/06/2018",
	      	  "end": "30/06/2018",
                    "label": "มิ.ย.",
                    "link": "/Plan/SHOW_INVTGE_PLAN_DETAIL?MAIN_IDA=62062000129&CITIZEN_ID=" + CITIZEN_ID + "MONTH=1"
	      	},
	      	{
	      	  "start": "01/07/2018",
	      	  "end": "31/07/2018",
                    "label": "ก.ค.",
                    "link": "/Plan/SHOW_INVTGE_PLAN_DETAIL?MAIN_IDA=62062000129&CITIZEN_ID=" + CITIZEN_ID + "MONTH=1"
	      	},
	      	{
	      	  "start": "01/08/2018",
	      	  "end": "31/08/2018",
                    "label": "ส.ค.",
                    "link": "/Plan/SHOW_INVTGE_PLAN_DETAIL?MAIN_IDA=62062000129&CITIZEN_ID=" + CITIZEN_ID + "MONTH=1"
	      	},
	      	{
	      	  "start": "01/09/2018",
	      	  "end": "30/09/2018",
                    "label": "ก.ย.",
                    "link": "/Plan/SHOW_INVTGE_PLAN_DETAIL?MAIN_IDA=62062000129&CITIZEN_ID=" + CITIZEN_ID + "MONTH=1"
	      	},
	        {
	          "start": "01/10/2018",
	          "end": "31/10/2018",
                "label": "ต.ค.",
                "link": "/Plan/SHOW_INVTGE_PLAN_DETAIL?MAIN_IDA=62062000129&CITIZEN_ID=" + CITIZEN_ID + "MONTH=1"
	        },
	//        {
	//          "start": "01/11/2018",
	//          "end": "30/11/2018",
	//          "label": "พ.ย."
	//        },
	//        {
	//          "start": "01/12/2018",
	//          "end": "31/12/2018",
	//          "label": "ธ.ค."
	//        }
	//      ]
	//    }
	//  ]}
	//});
});