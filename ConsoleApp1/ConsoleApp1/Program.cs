// regular switch statements

char ConvertPointsToGrade(int points)
{
    char grade;
    switch (points)
    {
        case 90:
            grade = 'A';
            break;
        case 80:
            grade = 'B';
            break;
        case 70:
            grade = 'C';
            break;
        case 60:
            grade = 'D';
            break;
        default:
            grade = 'F';
            break;
    }
    return grade;
}

//swtich statements (clean ver)

char ConvertPointsToGrade2(int points)
{
        return points switch
        {
            90 => 'A',
            80 => 'B',
            70 => 'C',
            60 => 'D',
            _ => 'F',
        };
}

// switch with pattern matching

char ConvertPointsToGrade3(int points)
{
    return points switch
    {
        >=90 => 'A',
        >=80 => 'B',
        >=70 => 'C',
        >=60 => 'D',
        _ => 'F', //anything below 50 is an F
    }
;
}