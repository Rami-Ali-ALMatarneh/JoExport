let navbar = document.getElementById("navbarId");
window.onscroll = function () {
    if (window.scrollY > 76) {
        navbar.classList.add("navbarBg");
    }
    else {
        navbar.classList.remove("navbarBg");
    }
}