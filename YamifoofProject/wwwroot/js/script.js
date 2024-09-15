(function ($) {
	"use strict";
	/* ..............................................
	Load More (bunu men yazmisam)
	................................................. */
    let skip = 3;
    $(document).on('click', "#loadMore", function () {
        var menuCount = $("#menuCount").val();

        $.ajax({
            url: "/Home/LoadMenus?skip="+skip,
            type: "GET",
            success: function (response) {
                $('#menuRow').append(response);
                skip += 3;
                if (skip >= menuCount ) {
                    $("#loadMore").remove();
                }
            },
            error: function (xhr) {

            }   
        });
	});

}(jQuery));


//jsin budu? heleki