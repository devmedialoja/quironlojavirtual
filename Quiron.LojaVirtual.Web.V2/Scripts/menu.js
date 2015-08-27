var app = {};

$(function () {
    app.iniciarlizar();
});


app.iniciarlizar = function () {

    $('#main-menu').smartmenus();
    app.ObterEsportes();

}



app.ObterEsportes = function () {

    $.getJSON('/menu/obteresportes', function (data) {

        $(data).each(function () {
            $("#esportes").append("<li><a href='#'>" + this.CategoriaDescricao + "</a></li>");
        });

    });

};
