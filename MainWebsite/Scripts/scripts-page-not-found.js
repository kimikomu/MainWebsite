
$(document).ready(function () {
    $(".error-page-container").show();

    // links are useless and do not open new pages
    $(".error-anim").attr("href", "#").removeAttr("target");

    // elements move and fly/fall off the page
    $(".error-anim").click(function () {

        if ($(this).parent().hasClass("icons")) {
            let bounceNum = Math.floor((Math.random() * 1200));
            let windowWidth = $(window).width();
            let bounceHeight = $(window).height() * 2;

            $(this).parent().attr("class", "bounce").animate({ right: windowWidth, bottom: bounceHeight }, bounceNum);
            $(this).parent().attr("class", "bounce").animate({ left: windowWidth, bottom: bounceHeight * 0.6 }, bounceNum);           
        }
        $(this).attr("class", "bounce").animate({ top: '2000px' });

    });

    // hide image when leaving the page
    $("img").click(function () {
        $(".error-page-container").hide();
    });
});

    //function bounceOffScreen(element) {
    //    if (element.position >= windowWidth) {
    //        element.animate({ left: '100px' });
    //    }
    //}

    //function doBounce(element, times, distance, speed) {
    //    for (var i = 0; i < times; i++) {
    //        element.animate({ marginTop: '-=' + distance }, speed)
    //            .animate({ marginTop: '+=' + distance }, speed);
    //    }
    //}
