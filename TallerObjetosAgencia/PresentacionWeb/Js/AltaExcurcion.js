function validarDiasTraslado(sender, args) {
    var dias = args.Value;
    if ($.isNumeric(dias)) {
        args.IsValid = true;

    } else {
        args.IsValid = false;
    }
}
function validarStock(sender, args) {
    var stock = args.Value;
    if ($.isNumeric(stock)) {
        args.IsValid = true;

    } else {
        args.IsValid = false;
    }
}
function validarPuntos(sender, args) {
    var puntos = args.Value;
    if ($.isNumeric(puntos)) {
        args.IsValid = true;

    } else {
        args.IsValid = false;
    }
}
function validarCostoDiario(sender, args) {
    var puntos = args.Value;
    if ($.isNumeric(puntos)) {
        args.IsValid = true;

    } else {
        args.IsValid = false;
    }
}
function validarDiasEstadia(sender, args) {
    var puntos = args.Value;
    if ($.isNumeric(puntos)) {
        args.IsValid = true;

    } else {
        args.IsValid = false;
    }
}