var selectedDate = new Date();
var t = document.querySelector("#calendar-body");
t.addEventListener("click", function (e) {
    selectedTd.classList.remove("selected");
    var tdSelected = e.composedPath()[0];
    if(tdSelected.nodeName === "SPAN"){
        selectedDate.setFullYear(currentYear,currentMonth, tdSelected.innerText);
        tdSelected = e.composedPath()[1];
    }else{
        selectedDate.setFullYear(currentYear,currentMonth, tdSelected.childNodes[0].innerText);
    }
    tdSelected.classList.add("selected");
    selectedTd = tdSelected;
});