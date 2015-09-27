var app = {};

$(function () {
    app.iniciarlizar();
});


app.iniciarlizar = function () {

    $('#main-menu').smartmenus();
    $('.sidey .nav').navgoco();
    app.ObterEsportes();
    app.ObterMarcas();
    app.ObterClubesNacionais();
    app.ObterClubesInternacionais();


}

///

//

app.ObterClubesNacionais = function () {

    $.getJSON('menu/obterclubesnacionais', function (data) {

        $(data).each(function () {
            $("#clubesnacionais").append("<li><a href='/nav/times/" + this.ClubeCodigo + "/" + this.ClubeSeo + "'>" + this.Clube + "</a></li>");
        });

    });

}



app.ObterClubesInternacionais = function () {

    $.getJSON('menu/obterclubesinternacionais', function (data) {

        $(data).each(function () {
           
            $("#clubesinternacionais").append("<li><a href='/nav/times/" + this.ClubeCodigo + "/" + this.ClubeSeo + "'>" + this.Clube + "</a></li>");
        });

    });

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










