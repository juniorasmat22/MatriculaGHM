var tabla;
var dato;
function eliminaDatos() {
    var table = $('#tbl_Curso').DataTable();

    table
        .clear()
        .draw();
}
function agregarFilaDT(data) {
    tabla = $("#tbl_Curso").DataTable();
    for (var i = 0; i < data.length; i++) {
        tabla.row.add([
            data[i].Codigo,
            data[i].nombre,
            data[i].horas,
            data[i].descripcion,
            //data[i].sexo,
            //data[i].nacimiento,
            "<button class='btn-floating blue modal-trigger btn_editar' data-target='modalEditCurso'><i class= 'material-icons right' >loop</i></button >" + " " +
            "<button class='btn-floating red btn_eliminar'><i class= 'material-icons right' >clear</i></button >",
        ]).draw().node();
    }
}

function enviarDataAjax() {
    $.ajax({
        type: "POST",
        url: "Frm_Cursos.aspx/ListarCursos",
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
        codigo: dato[0], nombre: $("#txtNombre").val(),
        horas: $("#txtApellido").val(),
        descripcion: $("#txtCorreo").val(),

    });
    $.ajax({
        type: "POST",
        url: "Frm_Cursos.aspx/ActualizarCurso",
        data: obj,
        dataType: "json",
        contentType: 'application/json;charset-utf-8',
        error: function (xhr, ajaxOptions, thrownError) { },
        success: function (response) {
            if (response) {
                eliminaDatos();
                swal({

                    type: 'success',
                    title: 'Curso Actualizado correctamente',
                    showConfirmButton: false,
                    timer: 1500

                });

                //$('#tbl_Profesores').DataTable().ajax.reload();
                //setTimeout("location.href='Frm_Cursos'", 1000);

                enviarDataAjax();
            }
            else {

                swal({
                    type: 'error',
                    title: 'Oops...',
                    text: 'Ocurrio un error al actualizar el Curso!',

                })
            }

        }

    });
}
function EliminarDataAjax() {
    var obj = JSON.stringify({ codigo: dato[0] });
   
    swal({
        title: 'Esta seguro?',
        text: "Desea elimina el Curso seleccionado!",
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
                url: "Frm_Cursos.aspx/EliminarCurso",
                data: obj,
                dataType: "json",
                contentType: 'application/json;charset-utf-8',
                error: function (xhr, ajaxOptions, thrownError) { },
                success: function (response) {
                    if (response) {
                        eliminaDatos();
                        swal({

                            type: 'success',
                            title: 'Curso Eliminado correctamente',
                            showConfirmButton: false,
                            timer: 1500

                        });

                        //$('#tbl_Profesores').DataTable().ajax.reload();
                        //setTimeout("location.href='Frm_Cursos.aspx'", 1000);
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
    })


}
/*ejecutar la funcio ajax*/
enviarDataAjax();


/*al ejecutar el boton_editar*/
$(document).on('click', '.btn_editar', function (e) {
    e.preventDefault();//para qeu no hay postback
    var fila = $(this).parent().parent()[0];
    dato = tabla.row(fila).data();
    //console.log(dato);
    fillDataModal()
    //console.log( $(this).parent().parent().children().first().text());
});

/*al ejecutar el boton_eliminar*/
$(document).on('click', '.btn_eliminar', function (e) {
    e.preventDefault();//para qeu no hay postback
    var fila = $(this).parent().parent()[0];
    dato = tabla.row(fila).data();
    EliminarDataAjax()
});


//cargar data al modal
function fillDataModal() {
    $("#txtCodigo").val(dato[0]);
    $("#txtNombre").val(dato[1]);
    $("#txtHoras").val(dato[2]);
    $("#txtDescripcion").val(dato[3]);

}
/*botones del modal*/
$("#btn_Update_Alumno").click(function (e) {
    e.preventDefault()
    ActualizarDataAjax()

});

                            //RegistrarDataAjax(obj);

$(".btn_add_Curso").click(function (e) {


    e.preventDefault();
    var nombre;
    var horas;
    var descripcion;
    

    nombre = $("#txtNombreCurso").val();
    horas = $("#txtHorasCurso").val();
    descripicon = $("#txtDesCurso").val();
   
    if (nombre.length > 0) {
        if (horas.length > 0) {
            if (descripicon.length > 0) {
                var obj = JSON.stringify({
                   
                    nombre: nombre,
                    horas: horas,
                    descripcion: descripicon
                    
                });

                $.ajax({
                    type: "POST",
                    url: "Frm_Cursos.aspx/RegistrarCurso",
                    data: obj,
                    dataType: "json",
                    contentType: 'application/json;charset-utf-8',
                    error: function (xhr, ajaxOptions, thrownError) { },
                    success: function (response) {
                        if (response) {
                            eliminaDatos();
                            swal({

                                type: 'success',
                                title: 'Curso Agregado correctamente',
                                showConfirmButton: false,
                                timer: 1500

                            })
                            enviarDataAjax();
                            //$('#tbl_Profesores').DataTable().ajax.reload();
                            //setTimeout("location.href='Frm_Cursos.aspx'", 1000);


                        }
                        else {

                            swal({
                                type: 'error',
                                title: 'Oops...',
                                text: 'Ocurrio un error al Agregar Curso!',

                            })
                        }

                    }

                });
            }
            else {
                swal({
                    type: 'error',
                    title: 'Oops...',
                    text: 'Campo dni Vacio o incorrecto(debe ingrese un digito)',

                })
            }
        }
        else {
            swal({
                type: 'error',
                title: 'Oops...',
                text: 'Campo Vacio o incorrecto',

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






