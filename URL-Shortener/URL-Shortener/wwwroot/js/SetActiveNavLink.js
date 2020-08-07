function SetActiveNav(pageName) {
    $(".nav-item").removeClass("active");
    $("#"+pageName).addClass("active");
};