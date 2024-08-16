$(document).ready(function(){
	$(".top-menu-item").click(function(){
		var index = $(this).data("index-tab");
		$(".item-tab").each(function(i,v){
			$(this).removeClass("active");
		});
		$(".top-menu-item").each(function(i,v){
			$(this).removeClass("active");
		});
		$(this).addClass("active");
		$(".tab"+index).addClass("active");
	});
	$(".item-tab .item-list").click(function(){
		var index = $(this).data("index-list");
		var parent_index = $(this).data("parent");
		$(".canvas-page .item-canvas").each(function(){
			$(this).removeClass("active");
		});
		$(".tab"+parent_index+" .canvas"+index).addClass("active");
		$(".tab"+parent_index+" .canvas-page").addClass("canvas");
		$(".tab"+parent_index+" .canvas"+index).gotoAnchor();
	});
	$(".canvas-page .btn-back").click(function(){
		$(this).parent().parent().removeClass("active");
		$(this).parent().parent().parent().removeClass("canvas");
	});
	$(".set-popup .btn-close,.set-popup .foot-popup").click(function(){
		$("html,body").removeClass("lock");
		$(".block-popup").removeClass("popup");
		$(".block-popup .set-popup").each(function(){
			$(this).removeClass("active");
		});
	});
	$(".btn-setting").click(function(){
		rmClass(".block-popup .set-popup","active");
		$("html,body").addClass("lock");
		$(".block-popup").addClass("popup");
		$(".block-popup .popup1").addClass("active");
	});
	$(".btn-browse").click(function(){
		rmClass(".block-popup .set-popup","active");
		$("html,body").addClass("lock");
		$(".block-popup").addClass("popup");
		$(".block-popup .popup2").addClass("active");
	});
	$(".popup1 .btn-upload").click(function(){
		rmClass(".block-popup .set-popup","active");
		$(".block-popup .popup2").addClass("active");
	});
	$(".popup2 .tab-section").click(function(){
		rmClass(".popup2 .tab-section","active");
		rmClass(".popup2 .block-section","active");
		$(this).addClass("active");
		$(".popup2 .block-section"+$(this).data("section-index")).addClass("active");
	});
});
function rmClass(elem,cls){
	$(elem).each(function(){
		$(this).removeClass(cls);
	});
}
$.fn.gotoAnchor = function(opts){
	var hd;
	if($(window).width() > 767){
		hd = -146;
	}else{
		hd = -70;
	}
	if( $(this).length>0 ){
		var defaults={
			speed:'slow',
			stop:false,
			offsetTop: ($("#header").length > 0)?$("#header")[0].offsetHeight+516:0,
			anotherTop: hd,
			callBack:function(){}
		};
		$.extend(true,defaults,opts);
		if (!defaults.stop) {
			$('html,body').animate({scrollTop:$(this).offset().top+defaults.anotherTop},defaults.speed).promise().done(function(){defaults.callBack();});
	   	}else{
	   		$('html,body').stop(true,false).animate({scrollTop:$(this).offset().top+defaults.anotherTop },defaults.speed).promise().done(function(){defaults.callBack();});
	   	}
	}
}