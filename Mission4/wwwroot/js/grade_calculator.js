// on button click calculate the grade percentage
$("#btn").click(() => {
    // create variables to hold input values
    let assignment = $("#assignment").val()
    let groupproj = $("#group").val()
    let quiz = $("#quiz").val()
    let midterm = $("#midterm").val()
    let final = $("#final").val()
    let intex = $("#intex").val()

    let total = 
        (assignment * .5) + 
        (groupproj * .1) + 
        (quiz * .1) + 
        (midterm * .1) + 
        (final * .1) + 
        (intex * .1)
    let letter;
    // determine what the letter grade should be
    if (total >= 94) {
        letter = "A"
    }
    else if (total >= 90) {
        letter = "A-"
    }
    else if (total >= 87) {
        letter = "B+"
    }
    else if (total >= 84) {
        letter = "B"
    }
    else if (total >= 80) {
        letter = "B-"
    }
    else if (total >= 77) {
        letter = "C+"
    }
    else if (total >= 74) {
        letter = "C"
    }
    else if (total >= 70) {
        letter = "C-"
    }
    else if (total >= 67) {
        letter = "D+"
    }
    else if (total >= 64) {
        letter = "D"
    }
    else if (total >= 60) {
        letter = "D-"
    }
    else {
        letter = "E"
    }
    //set output text to percent grade and letter grade
    $("#grade").text(total + "% : " + letter);
    alert(total + "% : " + letter);
    
    
})
//Uncomment this for fun after grading because this makes it impossible to use the website ;)
//('input').on('mouseover', function () {
//    $(this).css({
//        'top': Math.random() * window.innerHeight + "px",
//        'left': Math.random() * window.innerWidth + "px"
//    });
//})
