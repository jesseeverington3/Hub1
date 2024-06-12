// login.js
function validateLogin() {
    const username = document.getElementById('username').value;
    const password = document.getElementById('password').value;

    // Validate credentials (you can replace this with your own logic)
    if (username === 'yourUsername' && password === 'yourPassword') {
        // Redirect to the next page (e.g., dashboard.html)
        window.location.href = 'dashboard.html';
    } else {
        alert('Invalid credentials. Please try again.');
    }
}

