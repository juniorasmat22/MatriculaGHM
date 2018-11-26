var tabla;
var dato;
//function eliminaDatos() {
//    var table 

//    table
//        .clear()
//        .draw();
//}
function agregarFilaDT(data) {
    //tabla = $("#tbl_Grado").DataTable();
    var html="";
    for (var i = 0; i < data.length; i++) {
        html += "<tr>"
        if (i < 10) {
            html += "<td>" + "GRA-0" + (i+1) + data[i].Codigo + "</td>"
        }
        else {
            html += "<td>" + "GRA-" + i + data[i].Codigo + "</td>"
        }
        html += "<td>" + data[i].Numero + "</td>"
        html += "<td>" + data[i].seccion + "</td>"
        html += "<td>" + data[i].nivel + "</td>"
        html += "<td>" + "<button class='btn-floating blue modal-trigger btn_editar' data-target='modalEditGrado'><i class= 'material-icons right' >loop</i></button >"
        html+= "<button class='btn-floating red btn_eliminar'><i class= 'material-icons right' >clear</i></button >" + "</td>"
        html += "</tr>"

    }

   $( "#tbl_body_grado").html(html);
}

function enviarDataAjax() {
    $.ajax({
        type: "POST",
        url: "Frm_Grado.aspx/ListarGrado",
        data: {},
        contentType: 'application/json;charset-utf-8',
        error: function (xhr, ajaxOptions, thrownError) { },
        success: function (data) {
            //console.log(data);
            agregarFilaDT(data.d)
        }

    });
}

function ActualizarDataAjax() {

    var obj = JSON.stringify({
        id: $("#modaltxtCodigo").val().substring(6),
        numero: $("#modaltxtGrado").val(),
        seccion: $("#modaltxtSeccion").val(),
        nivel: $("#nivel option:selected").text(),

    });
    console.log(obj);
    $.ajax({
        type: "POST",
        url: "Frm_Grado.aspx/ActualizarGrado",
        data: obj,
        dataType: "json",
        contentType: 'application/json;charset-utf-8',
        error: function (xhr, ajaxOptions, thrownError) { },
        success: function (response) {
            if (response) {
               
                swal({

                    type: 'success',
                    title: 'Grado Actualizado correctamente',
                    showConfirmButton: false,
                    timer: 1500

                });


                //setTimeout("location.href='Frm_Alumnos.aspx'", 1000);

                enviarDataAjax();
            }
            else {

                swal({
                    type: 'error',
                    title: 'Oops...',
                    text: 'Ocurrio un error al actualizar el Grado!',

                })
            }

        }

    });
}
function EliminarDataAjax() {
    var obj = JSON.stringify({ id: codigo.substring(6) });
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
                url: "Frm_Grado.aspx/EliminarGrado",
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


var codigo
///*al ejecutar el boton_editar*/
$(document).on('click', '.btn_editar', function (e) {
    e.preventDefault();//para qeu no hay postback

     codigo= $(this).parents("tr").find("td").eq(0).html();
    var grado = $(this).parents("tr").find("td").eq(1).html();
    var seccion = $(this).parents("tr").find("td").eq(2).html();
    var nivel = $(this).parents("tr").find("td").eq(3).html();
    fillDataModal(codigo,grado,seccion,nivel);
});

///*al ejecutar el boton_eliminar*/
$(document).on('click', '.btn_eliminar', function (e) {
    e.preventDefault();
    codigo = $(this).parents("tr").find("td").eq(0).html();
    EliminarDataAjax()
});


////cargar data al modal
function fillDataModal(codigo, grado, seccion, nivel) {
   
    $("#modaltxtCodigo").val(codigo);
    $("#modaltxtGrado").val(grado);
    $("#modaltxtSeccion").val(seccion);
    $("#modalnivel value="+0+"selected")=nivel;
 

    //if (nivel == "Primaria") {
    //    $("#modalnivel option[value=" + 1 + "]").attr("selected", true);
    //}
    //else {
    //    $("#modalnivel option[value=" + 2 + "]").attr("selected", true);
    //}
   
}


//
///*botones del modal*/
$("#btn_Update_Grado").click(function (e) {
    e.preventDefault();
    ActualizarDataAjax();

});
$(".btn_add_Grado").click(function (e) {
    e.preventDefault();
    var grado;
    var seccion;
    var nivel;
    grado = $("#txtGrado").val();
    seccion = $("#txtSeccion").val();
    nivel = $("#nivel option:selected").text();
    if (grado.length > 0) {
        if (seccion.length == 1 && isNaN(seccion)) {
            if (nivel.length != 15) {
                var obj = JSON.stringify({
                    numero: grado,
                    seccion: seccion,
                    nivel: nivel
                });
               /* console.log(obj)*/;
                $.ajax({
                        type: "POST",
                        url: "Frm_Grado.aspx/RegistrarGrado",
                        data: obj,
                        dataType: "json",
                        contentType: 'application/json;charset-utf-8',
                        error: function (xhr, ajaxOptions, thrownError) { },
                        success: function (response) {
                            if (response) {
                                //eliminaDatos();
                                swal({

                                    type: 'success',
                                    title: 'Grado Agregado correctamente',
                                    showConfirmButton: false,
                                    timer: 1500

                                });


                                //setTimeout("location.href='Frm_Alumnos.aspx'", 1000);

                                enviarDataAjax();
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
                    text: 'Campo Nivel no selecionado(debe selecionar una opcion )',
                    
                })
            }
        }
        else {
            swal({
                type: 'error',
                title: 'Oops...',
                text: 'Campo Seccion Vacio o incorrecto(debe ingrese una Letra : A,B,C ...)',
              
            })
        }
    } else {
        swal({
            type: 'error',
            title: 'Oops...',
            text: 'Campo Vacio o incorrecto(debe ingrese un digito)',
           
        })
    }
    
   

});