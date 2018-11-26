var tabla;
var dato;
function eliminaDatos() {
    var table = $('#tbl_Alumnos').DataTable();

    table
        .clear()
        .draw();
}
function agregarFilaDT(data) {
    tabla = $("#tbl_Alumnos").DataTable();
    for (var i = 0; i < data.length; i++) {
        tabla.row.add([
           data[i].dni,
           data[i].nombre,
           data[i].apellido,
           data[i].correo,
           data[i].direccion,
            //data[i].sexo,
            //data[i].nacimiento,
            "<button class='btn-floating blue modal-trigger btn_editar' data-target='modalEditAlumno'><i class= 'material-icons right' >loop</i></button >" +" "+
            "<button class='btn-floating red btn_eliminar'><i class= 'material-icons right' >clear</i></button >",
        ]).draw().node();
    }
}

function enviarDataAjax() {
    $.ajax({
        type: "POST",
        url: "Frm_Alumnos.aspx/ListarAlumnos",
        data: {},
        contentType:'application/json;charset-utf-8',
        error: function (xhr, ajaxOptions, thrownError) { },
        success: function (data) {
            //console.log(data)
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
        url: "Frm_Alumnos.aspx/ActualizarAlumnos",
        data:obj,
        dataType:"json",
        contentType: 'application/json;charset-utf-8',
        error: function (xhr, ajaxOptions, thrownError) { },
        success: function (response) {
            if (response) {
                eliminaDatos();
                swal({

                    type: 'success',
                    title: 'Alumno Actualizado correctamente',
                    showConfirmButton: false,
                    timer: 1500

                });

                //$('#tbl_Alumnos').DataTable().ajax.reload();
                //setTimeout("location.href='Frm_Alumnos.aspx'", 1000);
                
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
                url: "Frm_Alumnos.aspx/EliminarAlumnos",
                data: obj,
                dataType: "json",
                contentType: 'application/json;charset-utf-8',
                error: function (xhr, ajaxOptions, thrownError) { },
                success: function (response) {
                    if (response) {
                        
                        swal({

                            type: 'success',
                            title: 'Alumno Eliminado correctamente',
                            showConfirmButton: false,
                            timer: 1500

                        });

                        $('#tbl_Alumnos').DataTable().ajax.reload();

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
    //console.log(dato[0]);
    EliminarDataAjax()
});


//cargar data al modal
function fillDataModal() {
    document.getElementById("txtDni").focus()
    
        /***********/
  
    $("#txtDni").val(dato[0]);
    $("#txtNombre").val(dato[1]);
    $("#txtApellido").val(dato[2]);
    $("#txtCorreo").val(dato[3]);
    $("#txtDireccion").val(dato[4]);
    //document.getElementById("dlSexo").value = dato[5];
    //$("#txtFecha").val(dato[6]);

    
   
}
/*botones del modal*/
$("#btn_Update_Alumno").click(function (e) {
    e.preventDefault()
    ActualizarDataAjax()
   
});

