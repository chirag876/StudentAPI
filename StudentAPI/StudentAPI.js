$(document).ready(function () {
    $("#savebtton").click(function () {
      // debugger;
    //   var taskId = $("#taskId").val();
      var Name = $("#Name").val();
      var Age = $("#Age").val();
      var Marks = $("#Marks").val();
  
  
      $.ajax({
        url: "https://localhost:7296/api/Student",
        method: "POST",
        dataType: "json",
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
        },
        data: JSON.stringify({
            // taskId: taskId,
            Name: Name,
            Age: Age,
            Marks:Marks,
          
        }),
        success: function (data, status, xhr) {
          // success callback function
          $("p").append(
            "Name: " + data.Name + " " + "Age: " + data.Age+ " " +"Marks: " + data.Marks
          );
        },
        error: function (request, status, error) {
          alert("Error: " + request.responseText);
        },
      });
    });
  });