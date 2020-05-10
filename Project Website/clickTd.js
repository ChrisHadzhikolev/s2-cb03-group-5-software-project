var selectedDate = new Date();
var t = document.querySelector("#calendar-body");
t.addEventListener("click", function (e) {
    selectedTd.classList.remove("selected");
    var tdSelected = e.composedPath()[0];
    if(tdSelected.nodeName === "SPAN"){
        selectedDate.setFullYear(currentYear,currentMonth, tdSelected.innerText);
        tdSelected = e.composedPath()[1];
        console.log(selectedDate);
    }else{
        selectedDate.setFullYear(currentYear,currentMonth, tdSelected.childNodes[0].innerText);
        console.log(selectedDate);
    }
    tdSelected.classList.add("selected");
    selectedTd = tdSelected;


    document.cookie = "selectedDate =" + selectedDate;
    document.getElementById("date").innerHTML = selectedDate;
    console.log("hello");
   
});
