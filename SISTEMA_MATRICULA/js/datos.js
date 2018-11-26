$(function () {
    $("#Btn_Aceptar").click(function () {
        var objAlumno = {
            dni: $('#txtDni').val(),
            nombre: $('#txtNombre').val(),
            paterno: $('#txtPaterno').val(),
            materno: $('#txtMaterno').val(),
            direccion: $('#txtDireccion').val(),
            correo: $('#txtCorreo').val(),
            nacimiento: $('#txtFecha').val(),
            sexo: $('#dlSexo').val()
        };
            $.ajax({
                type: "POST",
                url: "Reg_Alumno.aspx/obtenerAlumno",
                data: JSON.stringify(objAlumno),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    if (response.d === "Success") {
                        swal({
                            position: 'top-end',
                            type: 'success',
                            title: 'Your work has been saved',
                            showConfirmButton: false,
                            timer: 1500
                        })
           /*cargar la tabla de nuevo*/
                    } else {
                        swal({
                            type: 'error',
                            title: 'Oops...',
                            text: 'Something went wrong!',
                            footer: '<a href>Why do I have this issue?</a>'
                        })
                    }
                }
            });
            return false;
        });
    });