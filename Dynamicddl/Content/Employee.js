$(document).ready(function () {
    GetEmployeeList();
    GetSNameListddl();
    DDLCityChange();


});

var SaveEmployee = function () {
    var firstname = $("#txtfirstname").val();
    var lastname = $("#txtlastname").val();
    var email = $("#txtemail").val();
    var address = $("#txtaddress").val();
    var state = $("#ddlState_Id").val();
    var city = $("#ddlCity_Id").val();
    var model = { FirstName: firstname, Lastname: lastname, Email: email, Address: address, State: state, City: city };
    $.ajax({
        url: "/Employee/SaveEmployee",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (response) {
            alert("Data Saved Successfully");
        }

    });
}

var GetSNameListddl = function () {
    debugger;
    $.ajax({
        url: "/State/GetStateNameListddl",
        method: "Post",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#ddlState_Id").empty();
            var html = '<option value=1>Select State name</option>';
            $.each(response.model, function (index, elementValue) {
                html += "<option value=" + elementValue.State_Id + ">" + elementValue.State_Name + "</option>";

            });
            $("#ddlState_Id").append(html);
        }
    });
}

var GetEmployeeList = function () {
    debugger;
    $.ajax({
        url: "/Employee/GetEmployeeList",
        method: "Post",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#tblEmp tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.Id +
                    "</td><td>" + elementValue.FirstName +
                    "</td><td>" + elementValue.Lastname +
                    "</td><td>" + elementValue.Email +
                    "</td><td>" + elementValue.Address +
                    "</td><td>" + elementValue.State_Name +
                    "</td><td>" + elementValue.City_Name + "</td></tr>";
            });
            $("#tblEmp tbody").append(html);
        }
    });
}

var GetCityNameddl = function () {
    debugger;
    $.ajax({
        url: "/City/GetCityNameddl?State_Id=" + $("#ddlState_Id").val(),
        method: "Post",
        /* data: JSON.stringify(model),*/
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            //debugger
            $("#ddlCity_Id").empty();
            html += "<option value ='0'>Select City</option>";
            $.each(response.model, function (index, elementValue) {
                html += "<option value =" + elementValue.City_Id + ">" + elementValue.City_Name + "</option>";
            });

            $("#ddlCity_Id").append(html);
        }
    });
}

function DDLCityChange() {
    GetCityNameddl();
}

