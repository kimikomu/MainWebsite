// icons move and fall off the page
$(".icons").click(function () {

    let moveNum = Math.floor((Math.random() * 900) + - 250);
    let bounceNum = Math.floor((Math.random() * 20) + 6);

    $(this).attr("class", "bounce");

    $(".bounce").animate({ right: moveNum });
    $(".bounce").animate({ top: '2000px' });
});

// elements fall off the page
$(".navbar-brand").click(function () {

    $(this).attr("class", "bounce");

    $(".bounce").animate({ top: '2000px' });
});

$(".nav-item").click(function () {
    $(this).attr("class", "bounce");

    $(".bounce").animate({ top: '2000px' });
});

$(".error-button").click(function () {
    $(this).attr("class", "bounce");

    $(".bounce").animate({ top: '2000px' });
});

// error header flies off the page
$(".error-message").click(function () {

    $(this).attr("class", "bounce");

    $(".bounce").animate({ left: '5000px' });

    //doBounce($(this), bounceNum, '150px', 400);
});


// TODO: Incorporate bounce effect
//function doBounce(element, times, distance, speed) {
//    for (var i = 0; i < times; i++) {
//        element.animate({ marginTop: '-=' + distance }, speed)
//            .animate({ marginTop: '+=' + distance }, speed);
//    }
//}


















//var Ball = function () {
//    // List of variables only the object can see (private variables).
//    var velocity = [0, 0];
//    var position = [0, 0];
//    var element = $('#ball');
//    var paused = false;
//    // Method that moves the ball based on its velocity. This method is only used
//    // internally and will not be made accessible outside of the object.
//    function move(t) {
//    }
//    // Update the state of the ball, which for now just checks  
//    // if the play is paused and moves the ball if it is not.  
//    // This function will be provided as a method on the object.
//    function update(t) {
//        // First the motion of the ball is handled
//        if (!paused) {
//            move(t);
//        }
//    }
//    // Pause the ball motion.
//    function pause() {
//        paused = true;
//    }
//    // Start the ball motion.
//    function start() {
//        paused = false;
//    }
//    // Now explicitly set what consumers of the Ball object can use.
//    // Right now this will just be the ability to update the state of the ball,
//    // and start and stop the motion of the ball.
//    return {
//        update: update,
//        pause: pause,
//        start: start
//    }
//}

//    var ball;
//    var lastUpdate;
//    $(document).ready(function () {
//        lastUpdate = 0;
//        ball = Ball();
//        function update(time) {
//            var t = time - lastUpdate;
//            lastUpdate = time;
//            ball.update(t);
//            requestAnimationFrame(update);
//        }
//        requestAnimationFrame(update);
//    });


//var position = [300, 300];
//var velocity = [-1, -1];
//var move = function (t) {
//    position[0] += velocity[0] * t;
//    position[1] += velocity[1] * t;
//    element.css('left', position[0] + 'px');
//    element.css('top', position[1] + 'px');
//}

//$('#error-github').click(function () {
//    $('.icons').hide();
//});
