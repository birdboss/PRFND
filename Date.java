package com.company;

public class Date {
    private int month; // 1-12
    private int day; // 1-31 based on month
    private int year;

    private static final int[] daysPerMonth = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

    Date() {

    }

    // constructor: confirm proper value for month and day given the year
    public Date(int month, int day, int year) {
        // check if month in range
        if (month <= 0 || month > 12) {
            throw new IllegalArgumentException(
                    "month (" + month + ") must be 1-12");
        }
        // check if day in range for month
        if (day <= 0 ||
                (day > daysPerMonth[month] && !(month == 2 && day == 29))) {
            throw new IllegalArgumentException("day (" + day +
                    ") out-of-range for the specified month and year");
        }
        // check for leap year if month is 2 and day is 29
        if (month == 2 && day == 29 && !(year % 400 == 0 ||
                (year % 4 == 0 && year % 100 != 0))) {
            throw new IllegalArgumentException("day (" + day + ") out-of-range for the specified month and year");
        }
        if (year > 3000 || year < 1900) {
            throw new IllegalArgumentException("year (" + year + ") out-of-range and must be between 1900-3000");
        }
        this.month = month;
        this.day = day;
        this.year = year;
        System.out.printf("Date object constructor for date %s%n", this);
    }

    // return a String of the form month/day/year
    public String toString() {
        return String.format("%d/%d/%d", month, day, year);
    }

    public Date incrementDay(Date date) {
        if (month == 2 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))) {
            daysPerMonth[2] = 29;
        }
        if (day < daysPerMonth[month] && day > 0) {
            day += 1;
        } else if (day == daysPerMonth[month]) {
            day = 1;
            if (month < 12) {
                month += 1;
            } else {
                month = 1;
                year += 1;
            }
        }
        return date;
    }

    public Date incrementMonth(Date date) {
        if (date.month == 2 && (date.year % 400 == 0 || (date.year % 4 == 0 && date.year % 100 != 0))) {
            daysPerMonth[2] = 29;
        }
            if (date.month < 12) {
                date.month += 1;
            }
            else {
                date.month = 1;
                date.year += 1;
            }

        return date;
    }

    public Date incrementYear(Date date) {
        if (year<3000){
            date.year+=1;
        }
        else{
            throw new IllegalArgumentException("The year cannot go any higher.");
        }
        return date;
    }
}
