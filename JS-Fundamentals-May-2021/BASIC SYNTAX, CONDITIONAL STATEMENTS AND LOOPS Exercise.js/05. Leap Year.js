function leapYear(year) {
    if (year % 400 === 0) {
        console.log("yes");
    }else if (year % 4 === 0 && year % 100 === 0) {
        console.log("no");
    } else if (year % 4 === 0) {
        console.log("yes");
    } 
    else {
        console.log("no");
    }
}
leapYear(1984)
leapYear(2003)
leapYear(4)
leapYear(1900)