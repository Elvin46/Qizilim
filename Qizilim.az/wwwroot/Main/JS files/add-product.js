const { log } = require("../../admin/assets/plugins/fullcalendar/js/fullcalendar");

const imageInput = document.getElementById("images");
const mainFile = document.querySelector("main_file");
var ortukEt;
const addImgContainer = document.querySelector(".add-img-container");
let arr = []
imageInput.addEventListener('change', (e) => {
    arr = Object.values(e.target.files)
    var num = 0;
    arr.forEach((it, index) => {
        const div = document.createElement("div")
        div.classList.add("cover_image")
        const button = document.createElement("button");
        button.innerHTML = "Örtük et";
        button.classList.add("do_cover");
        button.setAttribute("id", `${num}`)
        num++;
        button.type = "button";
        const image = document.createElement("img");
        const reader = new FileReader();
        reader.addEventListener("load", () => {
            image.src = reader.result;
            div.appendChild(image)
            div.appendChild(button)
            addImgContainer.appendChild(div);

        });
        reader.readAsDataURL(e.target.files[index]);


    })
    ortukEt = document.getElementsByClassName("do_cover");
})
for (var i = 0; i < ortukEt; i++) {
    ortukEt[i].addEventListener('click', (e) => {
        for (var j = 0; j < 50; i++) {
            if (ortukEt.id == j) {
                console.log(imageInput.files[j]);
                mainFile.innerHTML = imageInput.files[j].name;
                mainFile.value = imageInput.files[j].name;
            }
        }
    })
}
