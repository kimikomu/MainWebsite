var gaHelper = (function ($) {
    "use strict";
    var module = {
        notificationDetailsUrl: null,
        onready: function () {
            var keys = Object.keys(this);
            var keysLength = keys.length;
            for (var i = 0; i < keysLength; i++) {
                if (this[keys[i]] === null) {
                    throw new Error(keys[i] + " needs to be initialized.");
                }
            }
        }

        var onclick="ga('send', 'event', 'View Resume', 'click');"


    };
    return module;
})(jQuery);