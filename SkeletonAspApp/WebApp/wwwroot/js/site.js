// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    // Obtener el token desde el campo oculto en el formulario o en cualquier parte del HTML
    var token = $('input[name="__RequestVerificationToken"]').val();

    // Interceptar todas las solicitudes AJAX y agregar el token a las cabeceras
    $.ajaxSetup({
        beforeSend: function (xhr) {
            xhr.setRequestHeader('RequestVerificationToken', token);
        }
    });
});

//// Obtener el token desde la metaetiqueta
//var csrfToken = document.querySelector('meta[name="csrf-token"]').getAttribute('content');

//// Configurar globalmente las opciones AJAX
//$.ajaxSetup({
//    beforeSend: function (xhr) {
//        xhr.setRequestHeader('RequestVerificationToken', csrfToken);
//    }
//});