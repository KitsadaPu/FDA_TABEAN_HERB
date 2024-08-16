$(document).ready(function(){
	$(".card.aco svg").click(function(){
		if($(this).parent().parent().parent().hasClass("active")){
			$(this).parent().parent().parent().removeClass("active");
		}else{
			$(this).parent().parent().parent().addClass("active");
		}
	});
});