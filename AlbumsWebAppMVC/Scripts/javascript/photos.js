$(document).ready(function () {

    $('.thumbnail').click(function () {
        var selectedImageKey = $(this).find('img').attr('data-image-key');
        $('.carousel-inner div').removeClass("active");
        $('#' + selectedImageKey).addClass('active');
        $('#photosModal').modal('show');
    });

});