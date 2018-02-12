﻿var gaHelper = (function ($) {
    "use strict";

    var module = {
        onready: function () {
            var keys = Object.keys(this);
            var keysLength = keys.length;
            for (var i = 0; i < keysLength; i++) {
                if (this[keys[i]] === null) {
                    throw new Error(keys[i] + " needs to be initialized.");
                }
            }

            var resumeButton = $("#resume-button");

            resumeButton.click(function () {
                alert("I am working!");
                //ga('send', 'event', 'View Resume from Index', 'click');
            });
        }
    };
    return module;
})(jQuery);