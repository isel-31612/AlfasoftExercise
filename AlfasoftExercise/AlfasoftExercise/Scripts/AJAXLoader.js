var LoadUserList = function (table,quote) {
    $.ajax({
        url: 'http://localhost:1524/api/Users'       
    })
    .done(function (data) {
        fillUserList(table, quote, data);
    })
}

function fillUserList(t, q, data) {
    var table = $(t);
    var quote = $(q);
    table.empty();

    data.Users.forEach(function (e) {
        var tr = $("<tr> </tr>").text("Id = " + e.Id + " | Name = " + e.Name + " | Password = " + e.Password);
        table.append(tr)
    });

    quote.append(data);
}



var LoadAddUser = function (i,n,p) {
    var data = "Id=" + i.val()+"&Name=" + n.val()+"&Password=" + p.val();
    $.ajax({
        type: "POST",
        url: "http://localhost:1524/View/PostAddUser",
        data: data,
        success: function (a,b,c) {
            alert("done")
        },
    })
}

var LoadRemoveUser = function (elem) {

}