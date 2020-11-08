$(document).ready(function () {
    $('#form1').bootstrapValidator({
        // To use feedback icons, ensure that you use Bootstrap v3.1.0 or later
        feedbackIcons: {
            valid: 'glyphicon glyphicon-ok',
            invalid: 'glyphicon glyphicon-remove',
            validating: 'glyphicon glyphicon-refresh'
        },
        fields: {
            txtNombreServ: {
                message: 'el nombre no es válido',
                validators: {
                    notEmpty: {
                        message: 'El nombre no puede estar en vacío'
                    }
                }
            }
        }
    });
});

