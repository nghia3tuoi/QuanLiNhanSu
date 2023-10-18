
var profileImg = document.querySelector(".profile-img");
var slidebarRight = document.querySelector(".app-right");
var closeRight = document.querySelector(".close-right");
profileImg.addEventListener("click", (e) => {
    e.preventDefault();
    slidebarRight.style.display = "block";
    closeRight.addEventListener("click", (e) => {
        slidebarRight.style.display = "none";
    })
    document.addEventListener("click", function (event) {
        if (!slidebarRight.contains(event.target) && event.target !== profileImg) {
            // Kiểm tra xem sự kiện click xảy ra bên ngoài thẻ mục tiêu và không phải là thẻ <a>
            slidebarRight.style.display = "none";
        } 
    });
})
