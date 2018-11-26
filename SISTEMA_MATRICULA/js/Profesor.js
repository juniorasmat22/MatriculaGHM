var tabla;
var dato;
    function eliminaDatos() {
        var table = $('#tbl_Profesores').DataTable();

        table.clear().draw();
    }
    function agregarFilaDT(data) {
    tabla = $("#tbl_Profesores").DataTable();
    for (var i = 0; i < data.length; i++) {
        tabla.row.add([
            data[i].dni,
            data[i].nombre,
            data[i].apellido,
            data[i].correo,
            data[i].direccion,
            data[i].telefono,

            "<button class='btn-floating blue modal-trigger btn_editar' data-target='modalEditDocente'><i class= 'material-icons right' >loop</i></button >" + " " +
            "<button class='btn-floating red btn_eliminar'><i class= 'material-icons right' >clear</i></button >",
        ]).draw().node();
    }
}

    function enviarDataAjax() {
        $.ajax({
            type: "POST",
            url: "Frm_Docentes.aspx/ListarDocente",
            data: {},
            contentType: 'application/json;charset-utf-8',
            error: function (xhr, ajaxOptions, thrownError) { },
            success: function (data) {
                console.log(data);
                agregarFilaDT(data.d)
            }

        });
    }
    function ActualizarDataAjax() {
        var obj = JSON.stringify({
            id: dato[0], nombre: $("#txtNombre").val(),
            apellido: $("#txtApellido").val(),
            correo: $("#txtCorreo").val(),
            direccion: $("#txtDireccion").val()
        });
        $.ajax({
            type: "POST",
            url: "Frm_Docentes.aspx/ActualizarDocente",
            data: obj,
            dataType: "json",
            contentType: 'application/json;charset-utf-8',
            error: function (xhr, ajaxOptions, thrownError) { },
            success: function (response) {
                if (response) {
                    eliminaDatos();
                    swal({

                        type: 'success',
                        title: 'Docente Actualizado correctamente',
                        showConfirmButton: false,
                        timer: 1500

                    });

                    //$('#tbl_Profesores').DataTable().ajax.reload();
                    //setTimeout("location.href='Frm_Docentes'", 1000);

                    enviarDataAjax();
                }
                else {

                    swal({
                        type: 'error',
                        title: 'Oops...',
                        text: 'Ocurrio un error al actualizar el alumno!',

                    })
                }

            }

        });
    }
    function EliminarDataAjax() {
        var obj = JSON.stringify({ id: dato[0] });
        console.log(obj);
        swal({
            title: 'Esta seguro?',
            text: "Desea elimina el registro seleccionado!",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: 'Cancelar',
            confirmButtonText: 'Eliminar'
        }).then((result) => {
            if (result.value) {
                $.ajax({
                    type: "POST",
                    url: "Frm_Docentes.aspx/EliminarDocente",
                    data: obj,
                    dataType: "json",
                    contentType: 'application/json;charset-utf-8',
                    error: function (xhr, ajaxOptions, thrownError) { },
                    success: function (response) {
                        if (response) {
                            eliminaDatos();
                            swal({

                                type: 'success',
                                title: 'Alumno Eliminado correctamente',
                                showConfirmButton: false,
                                timer: 1500

                            });
                            enviarDataAjax();
                            //$('#tbl_Profesores').DataTable().ajax.reload();
                            //setTimeout("location.href='Frm_Docentes.aspx'", 1000);
                        }
                        else {

                            swal({
                                type: 'error',
                                title: 'Oops...',
                                text: 'Ocurrio un error al actualizar el alumno!',

                            })
                        }

                    }

                });

            }
        })


    }
    /*ejecutar la funcio ajax*/
    enviarDataAjax();


    /*al ejecutar el boton_editar*/
    $(document).on('click', '.btn_editar', function (e) {
        e.preventDefault();//para qeu no hay postback
        var fila = $(this).parent().parent()[0];
        dato = tabla.row(fila).data();
        console.log(dato);
        fillDataModal()
        //console.log( $(this).parent().parent().children().first().text());
    });

    /*al ejecutar el boton_eliminar*/
    $(document).on('click', '.btn_eliminar', function (e) {
        e.preventDefault();//para qeu no hay postback
        var fila = $(this).parent().parent()[0];
        dato = tabla.row(fila).data();
        //console.log(dato[0]);
        EliminarDataAjax()
    });


    //cargar data al modal
    function fillDataModal() {
        $("#e_txtDni").val(dato[0]);
        $("#e_txtNombre").val(dato[1]);
        $("#e_txtApellido").val(dato[2]);
        $("#e_txtDireccion").val(dato[3]);
        $("#e_txtCorreo").val(dato[4]);

    }
    /*botones del modal*/
    $("#btn_Update_Docente").click(function (e) {
        e.preventDefault()
        ActualizarDataAjax()

    });


    $(".btn_add_Docente").click(function (e) {


        e.preventDefault();
        var dni;
        var nombres;
        var apellidos;
        var direccion;
        var correo;
        var telefono;

        dniP = $("#txtDniDocente").val();
        nombresP = $("#txtNombreDocente").val();
        apellidosP = $("#txtApellidoDocente").val();
        direccionP = $("#txtDireccionDocente").val();
        telefonoP= $("#txtTelefono").val();;
        correoP = $("#txtCorreoDocente").val();
        if (dniP.length > 0) {
            if (nombresP.length > 0 && isNaN(nombres)) {
                if (apellidosP.length > 0) {
                    if (direccionP.length > 0) {
                        if (correoP.length > 0) {
                            if (telefonoP.length > 0) {
                                var obj = JSON.stringify({
                                    id: dniP,
                                    nombre: nombresP,
                                    apellido: apellidosP,
                                    direccion: direccionP,
                                    telefono: telefonoP,
                                    correo: correoP
                                });
                               
                                $.ajax({
                                    type: "POST",
                                    url: "Frm_Docentes.aspx/RegistrarDocente",
                                    data: obj,
                                    dataType: "json",
                                    contentType: 'application/json;charset-utf-8',
                                    error: function (xhr, ajaxOptions, thrownError) { },
                                    success: function (response) {
                                        if (response) {
                                            eliminaDatos();
                                            swal({

                                                type: 'success',
                                                title: 'Docente Agregado correctamente',
                                                showConfirmButton: false,
                                                timer: 1500

                                            })
                                            enviarDataAjax();
                                            //$('#tbl_Profesores').DataTable().ajax.reload();
                                            //setTimeout("location.href='Frm_Docentes.aspx'", 1000);


                                        }
                                        else {

                                            swal({
                                                type: 'error',
                                                title: 'Oops...',
                                                text: 'Ocurrio un error al Agregar Grado!',

                                            })
                                        }

                                    }

                                });
                                //RegistrarDataAjax(obj);
                            }
                            else {
                                swal({
                                    type: 'error',
                                    title: 'Oops...',
                                    text: 'Campo Telefono no valido',

                                })
                            }
                        }
                        else {
                            swal({
                                type: 'error',
                                title: 'Oops...',
                                text: 'Campo correo no valido',

                            })
                        }

                    }
                    else {
                        swal({
                            type: 'error',
                            title: 'Oops...',
                            text: 'Campo direccion no valido',

                        })
                    }

                }
                else {
                    swal({
                        type: 'error',
                        title: 'Oops...',
                        text: 'Campo apellido no valido',

                    })
                }
            }
            else {
                swal({
                    type: 'error',
                    title: 'Oops...',
                    text: 'Campo nombre no valido',

                })
            }
        }
        else {
            swal({
                type: 'error',
                title: 'Oops...',
                text: 'Campo dni Vacio o incorrecto(debe ingrese un digito)',

            })
        }



    });






