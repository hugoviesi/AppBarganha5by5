"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");

    var now = new Date();
    var time = now.toLocaleTimeString();

    var encodedMsg = "[" + time + "] " + user + ": " + msg;

    var li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("messagesList").appendChild(li);
});

connection.start().then(function () {
    var chatId = document.getElementById("chatId").value;
    connection.invoke('Register', chatId)
        .then(function (connectionId) {
            console.log("user in chat" + connectionId)
            document.getElementById("sendButton").disabled = false;
        }).catch(err => console.error(err.toString()));;

}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var chatId = document.getElementById("chatId").value;
    var userName = document.getElementById("userName").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", chatId, userName, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});