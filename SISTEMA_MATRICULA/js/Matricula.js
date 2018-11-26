var dniEstudiante = 0;
var tabla;
var dato;
function eliminaDatos() {
    //var table = $('#tbl_Matricula').DataTable();

    table.clear().draw();
}
function agregarFilaDT(data) {
    tabla = $("#tbl_Matricula").DataTable();
    for (var i = 0; i < data.length; i++) {
        tabla.row.add([
            data[i].Codigo,
            data[i].Dni,
            data[i].Nombre,
            data[i].Grado,
            data[i].Seccion,
            //data[i].nacimiento,
            //"<button class='btn-floating blue modal-trigger btn_editar' data-target='modalEditCurso'><i class= 'material-icons right' >loop</i></button >" + " " +
            //"<button class='btn-floating red btn_eliminar'><i class= 'material-icons right' >clear</i></button >",
        ]).draw().node();
    }
}

function enviarDataAjax() {
    $.ajax({
        type: "POST",
        url: "Frm_Matricula.aspx/ListarMatricula",
        data: {},
        contentType: 'application/json;charset-utf-8',
        error: function (xhr, ajaxOptions, thrownError) { },
        success: function (data) {
            console.log(data);
            agregarFilaDT(data.d)
        }

    });
}
enviarDataAjax();
$(".btn_buscar").on('click', function (e) {
    e.preventDefault();
    document.getElementById("txtDni").disabled = true;
    var dni = $("#txtDni").val();
    if (dni.length > 0) {
        buscarEstudiante(dni);
    } else {
        swal({
            type: 'error',
            title: 'Oops...',
            text: 'Ingrese Dni de Estudiante',
           
           
        })
    }


});
$(".btn_nueva_busqueda").on('click', function (e) {

    e.preventDefault();
    document.getElementById("txtDni").disabled = false;
    limpiarDatosPaciente();
});
$(".btn_registra_matricula").on('click', function (e) {
    var grado = document.getElementById("Secciones").value;
    var fecha = document.getElementById("txtFecha").value;
    var hora = document.getElementById("txtHora").value;
    var empleado = document.getElementById("codEmpleado").value;
    if (dniEstudiante != 0) {
        if (grado > 0) {
            registrarMatricula(dniEstudiante, grado, fecha, hora, empleado);
            limpiarDatosPaciente()
        }
        else {
            swal({
                type: 'error',
                title: 'Oops...',
                text: 'Grado no seleccionado!',

            })
        }
    }
    else {
        swal({
            type: 'error',
            title: 'Oops...',
            text: 'dni no valido!',

        })
    }
});
function registrarMatricula(dni, grado, fecha, hora, empleado) {
    var dato = JSON.stringify({
        dni: dni,
        grado:grado,
        hora:hora,
        fecha:fecha,
        empleado:empleado,
    });
    $.ajax({
        type: "POST",
        url: "Frm_Matricula.aspx/RegistrarMatricula",
        data: dato,
        contentType: 'application/json;charset-utf-8',
        error: function (xhr, ajaxOptions, thrownError) { },
        success: function (data) {
            //console.log(data.d);
            if (data) {
                swal({
                    
                    type: 'success',
                    title: 'Matricula registrada correctamente',
                    showConfirmButton: false,
                    timer: 1500
                })
            }
            else {
                swal({
                    type: 'error',
                    title: 'Oops...',
                    text: 'erro al registra matricula!',

                })

            }

        }

    });

}
function buscarEstudiante(dni) {
   var dato= JSON.stringify({dni:dni})
    $.ajax({
        type: "POST",
        url: "Frm_Matricula.aspx/BuscarEstudiante",
        data: dato,
        contentType: 'application/json;charset-utf-8',
        error: function (xhr, ajaxOptions, thrownError) { },
        success: function (data) {
            console.log(data.d);
            if (data.d==null) {
                swal({
                    type: 'error',
                    title: 'Oops...',
                    text: 'no se encotro al alumno con el dni proporcionado!',

                })
            }
            else {
                llenarDatosPaciente(data.d)
                dniEstudiante = dni;
                alert(dniEstudiante);
               
            }
          
        }

    });
}

function llenarDatosPaciente(obj) {
    $("#nombre").val(obj.nombre);
    $("#apellidos").val(obj.apellido);
    $("#direccion").val(obj.direccion);
    $("#correo").val(obj.correo);

}
function limpiarDatosPaciente() {
    $("#nombre").val("");
    $("#apellidos").val("");
    $("#direccion").val("");
    $("#correo").val("");
    $("#txtDni").val("");

}
