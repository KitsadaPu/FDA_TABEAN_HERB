$('.nav-top .menu').click(function(){
	var elem = $('.nav-top ul');

	// elem.slideToggle();
	if (elem.hasClass("active")) {
		elem.removeClass("active");
	} else {
		elem.addClass("active");
	}
});