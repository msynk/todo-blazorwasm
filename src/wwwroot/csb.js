var csb = (function () {
    return {
        focus: function (el) {
            el && el.focus && el.focus();
        }
    }
}());