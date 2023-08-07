﻿/*
 
 Char er et ENKELT bogstav
 
 Syntax: char 'a'
 
 */


char ConvertPointsToGrade(int points) {
    
    switch (points) {
        case 10:
        case 9:
            return 'A';
        case 8:
        case 7:
        case 6:
            return 'B';
        case 5:
        case 4:
        case 3:
            return 'C';
        case 2:
        case 1:
            return 'D';
    }

    return 'a';
}