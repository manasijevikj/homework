var grades = [];
for(var i =0; i <= 4; i++) {
    let grade = parseInt(prompt("Grade of Exam number "+(i+1)));
    grades[i] = grade;
}


function semester(grades) {
    let avg = 0;
    for(var i =0; i <= 4; i++) {
        avg += grades[i];
    }
    avg = avg/5;

    if(avg >= 8) {
        alert("You have "+avg+" average, you passed the semester.")
    }
    else {
        alert("You have "+avg+" average, you failed the semester.")
    }
}

semester(grades);
