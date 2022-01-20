$("#calculate").click(function () { /*performs the calculation for the grade and grade letter when the 'submit' button is pressed*/
    var iGrade =((($('#assignments').val() / 100 * 55) + ($('#group').val() / 100 * 5) + ($('#quizzes').val() / 100 * 10) +
        ($('#exams').val() / 100 * 20) + ($('#intex').val() / 100 * 10))) /*creates a iGrade variable. Its value is assigned based off of the function
         receiving the values submitted in the calculation form, and then performing the following math calculation to determine the final grade*/

    var iLetter = "n/a" /* initializes the variable that will hold the letter grade */

    if (iGrade >= 94) /*if the calculated grade is greater than or equal to 94 */
        { iLetter = "A" }

    else if (iGrade >= 90) /*if the calculated grade is greater than or equal to 90, less than 94 */
        { iLetter = "A-" }

    else if (iGrade >= 87) /*if the calculated grade is greater than or equal to 87, less than 90 */
        { iLetter = "B+" }

    else if (iGrade >= 84) /*if the calculated grade is greater than or equal to 84, less than 87 */
        { iLetter = "B" }

    else if (iGrade >= 80) /*if the calculated grade is greater than or equal to 80, less than 84 */
        { iLetter = "B-" }

    else if (iGrade >= 77) /*if the calculated grade is greater than or equal to 77, less than 80 */
        { iLetter = "C+" }

    else if (iGrade >= 74) /*if the calculated grade is greater than or equal to 74, less than 77 */
        { iLetter = "C" }

    else if (iGrade >= 70) /*if the calculated grade is greater than or equal to 70, less than 74 */
        { iLetter = "C-" }

    else if (iGrade >= 67)/* if the calculated grade is greater than or equal to 67, less than 70 */
        { iLetter = "D+" }

    else if (iGrade >= 64) /*if the calculated grade is greater than or equal to 64, less than 67 */
        { iLetter = "D" }

    else if (iGrade >= 60) /*if the calculated grade is greater than or equal to 60, less than 64*/
        { iLetter = "D-" }

    else { iLetter = "E" } /*if the calculated grade is less than 60 */

    ($("#final").html(iLetter + " " + iGrade+"%") /* prints final output of the letter grade, and grade percentage */
)})



