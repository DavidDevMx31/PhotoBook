function showAlbumPhotos() {
    console.log(document.getElementById("albums").value);
    var albumId = document.getElementById("albums").value;
    $.ajax({
        url: '/Albums/GetAlbumPhotos',
        type: 'GET',
        dataType: 'JSON',
        data: { albumId = albumId },
        success: function (response) {
            console.log(JSON.stringify(response));
        }
    });
}