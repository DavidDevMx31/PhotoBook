$(function () {
    console.log("Document ready!");
    getAlbums();
});

function getAlbums() {
    $.ajax({
        url: '/Albums/GetAlbums',
        type: 'GET',
        dataType: 'JSON',
        success: function (response) {
            var rows = [];
            for (var i = 0; i < response.length; i++) {
                var row = '<tr><th scope="row">' + response[i].Number +
                    '</th><th>' + response[i].Name +
                    '</th><th>' + response[i].Author +
                    '</th><th>' + response[i].CreationDate + '</th></tr>';
                rows.push(row);
            }
            $("#albumsTable > tbody").append(rows.join(''));
        }
    });
}

function showAlbumPhotos() {
    alert("Elegiste el álbum " + document.getElementById("albums").value);
    var albumId = document.getElementById("albums").value;
}