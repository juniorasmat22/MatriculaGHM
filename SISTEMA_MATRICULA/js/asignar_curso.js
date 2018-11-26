
$("#btn_asignar_Curso").click(function (e) {
    e.preventDefault()
    //ActualizarDataAjax()
    var dni = document.getElementById("DropDownList3").value;
    var seccion = document.getElementById("DropDownList1").value; 
    var curso = document.getElementById("DropDownList2").value;
    if (curso > 0) {
        if (seccion > 0) {
            if (dni>0) {
                asignar_curso(curso, dni, seccion)
            }
            else {
                swal({
                    type: 'error',
                    title: 'Oops...',
                    text: 'Debe seleccionar un profesor!',

                })
            }

        }
        else {
            swal({
                type: 'error',
                title: 'Oops...',
                text: 'Debe seleccionar una seccion!',

            })
        }

    }
    else {
        swal({
            type: 'error',
            title: 'Oops...',
            text: 'Debe seleccionar un curso!',
            
        })
    }
});

function asignar_curso(curso, dni, seccion) {
    var obj = JSON.stringify({
        codCurso: curso,
        codProfesor: dni,
        codGrado: seccion
    });
    console.log(obj);
    $.ajax({
        type: "POST",
        url: "Frm_AsignarCurso.aspx/Asignar_Curso",
        data: obj,
        dataType: "json",
        contentType: 'application/json;charset-utf-8',
        error: function (xhr, ajaxOptions, thrownError) { },
        success: function (response) {
            if (response) {
                //eliminaDatos();
                swal({

                    type: 'success',
                    title: 'Datos asignados correctamente',
                    showConfirmButton: false,
                    timer: 1500

                });


                //setTimeout("location.href='Frm_Alumnos.aspx'", 1000);

                //enviarDataAjax();
            }
            else {

                swal({
                    type: 'error',
                    title: 'Oops...',
                    text: 'Ocurrio un error al Asigra el curso!',

                })
            }

        }

    });
}