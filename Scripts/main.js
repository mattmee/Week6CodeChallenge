$(document).ready(function () {
    $('body').on('click', '.ajax-get', function (event) {
        //bind this click event to anything that has teh class of "ajax-get" that appears on the page at any time
        //extract href of the link we just clicked on
        var url = $(this).attr('href');
        //disable default behavior (don't make the link go anyhwere)
        event.preventDefault();
        //now make an ajax get request
        $.get(url, function (data) {
            $('#ajax-content').html(data);
        });
    });

    $('body').on('submit', '.ajax-post', function (event) {
        event.preventDefault();
        var url = $(this).attr('action');
        $.post(url, $(this).serialize(), function (data) {
            $('#ajax-content').html("Thank you" + data);
        });
    });
});