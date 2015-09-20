var app = {};

$(function () {
    app.iniciarlizar();
});


app.iniciarlizar = function () {

    $('#main-menu').smartmenus();
    app.ObterEsportes();
    app.ObterMarcas();
   

}



app.ObterEsportes = function () {

    $.getJSON('/menu/obteresportes', function (data) {

        $(data).each(function () {
            $("#esportes").append("<li><a href='#'>" + this.CategoriaDescricao + "</a></li>");
        });

    });

};

app.ObterMarcas = function () {

    $.getJSON('/menu/obtermarcas', function (data) {

        $(data).each(function () {
            $(".marcas").append("<li><a href='#'>" + this.MarcaDescricao + "</a></li>");
        });

    });

};










