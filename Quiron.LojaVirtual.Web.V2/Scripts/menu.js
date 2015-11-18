var app = {};

$(function () {

    $('#main-menu').smartmenus();
    /* Ecommerce sidebar */
    $('.sidey .nav').navgoco();
    app.iniciarlizar();
});



app.iniciarlizar = function () {


    app.ObterMarcas();
    app.ObterEsportes();
    app.ObterClubesNacionais();
    app.ObterInternacionais();
}


app.ObterClubesNacionais = function () {

    $.getJSON('/menu/obterclubesnacionais', function (data) {
        $(data).each(function () {
            $("#clubesnacionais").append("<li><a href='/nav/times/" + this.ClubeCodigo + "/" + this.ClubeSeo + "'>" + this.Clube + "</a></li>");
        });
    });
};

app.ObterInternacionais = function () {

    $.getJSON('/menu/obterclubesinternacionais', function (data) {
        $(data).each(function () {
            $("#clubesinternacionais").append("<li><a href='/nav/times/" + this.ClubeCodigo + "/" + this.ClubeSeo + "'>" + this.Clube + "</a></li>");
        });
    });
};

app.ObterEsportes = function () {

    $.getJSON('/menu/obteresportes', function (data) {
        $(data).each(function () {
            $("#esportes").append("<li><a href='/nav/esportes/" + this.CategoriaCodigo + "/" + this.CategoriaDescricaoSeo + "'>" + this.CategoriaDescricao + "</a></li>");
        });
    });
};

app.ObterMarcas = function () {
    $.getJSON('/menu/obtermarcas', function (data) {
        $(data).each(function () {
            $("#marcas").append("<li><a href='/nav/" + this.MarcaCodigo + "/" + this.MarcaDescricaoSeo + "'>" + this.MarcaDescricao + "</a></li>");
            $("#calcadosmarcas").append("<li><a href='/nav/0003/calcados/" + this.MarcaCodigo + "/" + this.MarcaDescricaoSeo + "'>" + this.MarcaDescricao + "</a></li>");
            $("#roupasmarcas").append("<li><a href='/nav/0001/roupas/" + this.MarcaCodigo + "/" + this.MarcaDescricaoSeo + "'>" + this.MarcaDescricao + "</a></li>");
        });
    });
};

