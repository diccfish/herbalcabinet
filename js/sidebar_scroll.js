 if( jQuery(window).width() > 859 ) {
 $(function() {
        var offset = $(".sidebar").offset();
        var topPadding = -40;
        $(window).scroll(function() {
            if ($(window).scrollTop() > offset.top) {
                $(".sidebar").stop().animate({
                    marginTop: $(window).scrollTop() - offset.top + topPadding
                });
            } else {
                $(".sidebar").stop().animate({
                    marginTop: 0
                });
            };
        });
    });
}