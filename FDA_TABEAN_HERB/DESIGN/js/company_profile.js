
var conf_chart = [];
var max_dd = 0;
$(document).ready(function(){
	$(".l-item").click(function(){
		$(".l-item").each(function(){
			$(this).removeClass("active");
		})
		$(this).addClass("active");

		$(".b-list").each(function(i,v){
			$(this).removeClass("active");
		});
		$(".b-list."+$(this).attr("data-target")).addClass("active");
	});
	$(".adj .adj-s").click(function(){
		let mm = $(this).attr("data-mode");
		$(".adj-s").each(function(){
			$(this).removeClass("active");
		})
		$(this).addClass("active");

		$(".b-list").each(function(i,v){
			$(this).removeClass("rrr ggg");
			$(this).addClass(mm);
		});
	});
	$(".card-tab-control .tab-content-item").click(function(){
		let index = $(this).data("index");
		$(".card-tab-control .tab-content-item").each(function(){
			$(this).removeClass("active");
		});
		$(this).addClass("active");
		$(".card-tab").each(function(i,v){
			$(v).removeClass("active");
		});
		$(".card-tab"+index).addClass("active");
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
	  height: "330",
	  dataFormat: "json",
	  dataSource: {
	    chart: {
	      caption: "",
	      subcaption: "",
	      showLegend: "1",
	      legendPosition: "RIGHT",
	      showpercentvalues: "1",
	      enableSmartLabels: "0",
	      showLabels:"0",
	      showValues:"0",
	      defaultcenterlabel: max_dd+" ใบ",
	      aligncaptionwithcanvas: "0",
	      captionpadding: "0",
	      decimals: "1",
	      plottooltext:
	        "<b>$percentValue</b> : $label",
	      centerlabel: "",
	      theme: "fusion"
	    },
	    data: conf_chart
	  }
	});
});