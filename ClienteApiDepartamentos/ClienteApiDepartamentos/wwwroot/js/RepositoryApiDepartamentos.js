function cargarTablaDepartamentosAsync(callback) {
    var urlApi = "https://apidepartamentosdvb.azurewebsites.net/api/Departamentos";
    $.ajax({
        url: urlApi,
        type: "GET",
        success: function (data) {
            var html = "";
            $.each(data, function (key, value) {
                html += "<tr>";
                html += "<td>" + value.Numero + "</td>";
                html += "<td>" + value.Nombre + "</td>";
                html += "<td>" + value.Localidad + "</td>";
                html += "</tr>";
            });
            callback(html);
        }
    });
}

function cargarJsonDepartamentosAsync(callback) {
    var urlApi = "https://apidepartamentosdvb.azurewebsites.net/api/Departamentos";
    $.ajax({
        url: urlApi,
        type: "GET",
        success: function (data) {
            callback(data);
        }
    });
}

function deleteDepartamento(id, callback) {
    var urlApi = "https://apidepartamentosdvb.azurewebsites.net/api/Departamentos/" + id;
    $.ajax({
        url: urlApi,
        type: "DELETE",
        success: function () {
            callback();
        }
    });
}