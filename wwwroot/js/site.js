// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

async function addUser(event){
    const user = {
        email: document.getElementById("email").value}
    console.log(9);

    const response = await fetch("/api/Users/CreateUser", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(user)
        });
         console.log(18);


    const res = await fetch("/api/Users/GetUsers");
    const users = await res.json();

    let h = document.getElementById("Display-user");

    // h.textContent = users[0].email; .
    users.forEach(user => {
        h.textContent += user.email + " ";
    });

}


