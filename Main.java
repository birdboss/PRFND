package com.company;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        Boolean inc = true;
        while (inc == true) {
            System.out.println("What would you like to do? Increment...\n Time : 1\n Date : 2\n Quit : 3");
            int choice = s.nextInt();

            switch (choice) {
                case 1:
                    Time time = inputTime(inc);
                    Date date = inputDate(inc);
                    timeMenu(time,date);
                    break;

                case 2:
                    date =inputDate(inc);
                    menuDate(date);
                    break;

                case 3:
                    inc = false;
                    break;
            }
        }


    }


    private static Time inputTime(Boolean inc) {
        Scanner s = new Scanner(System.in);
        //int choice;
        //        System.out.println("If you would like to enter a custom time press 1, if not press any other number...");
        //        choice = s.nextInt();

        //if (choice == 1) {
            System.out.println("Please enter the time in this format (24 hour) hour:minute:second");
            String input = s.next();
            String arr[] = input.split(":");
            int hour = Integer.parseInt(arr[0]);
            int minute = Integer.parseInt(arr[1]);
            int second = Integer.parseInt(arr[2]);
            Time time = new Time(hour, minute, second);
            //Date date = autoDate();
            return time;

        //}
        //else {
        //            Time time = autoTime();
        //            Date date = autoDate();
        //            timeMenu(time, date);
        //        }



    }

    //private static Time autoTime() {
    //        LocalDateTime ldt = LocalDateTime.now();
    //        DateTimeFormatter _dtf = DateTimeFormatter.ofPattern("HH:mm:ss");
    //        String _time = _dtf.format(ldt);
    //        String arrT[] = _time.split(":");
    //        int hour = Integer.parseInt(arrT[0]);
    //        int minute = Integer.parseInt(arrT[1]);
    //        int second = Integer.parseInt(arrT[2]);
    //        Time time = new Time(hour, minute, second);
    //        return time;
    //    }

    private static void timeMenu(Time time, Date date) {
        boolean inc = true;
        int choice;
        Scanner s = new Scanner(System.in);
        while (inc == true) {
            System.out.println("What would you like to do? Increment...\n Second : 1\n Minute : 2\n Hour : 3\n Quit : 4");
            choice = s.nextInt();
            switch (choice) {
                case 1:
                    time.tick(time, date);
                    System.out.println("\nTime: " + time+"\nDate: "+date);
                    System.out.println("\n");
                    break;
                case 2:
                    time.incrementMinute(time, date);
                    System.out.println("\nTime: " + time+"\nDate: "+date);
                    System.out.println("\n");
                    break;
                case 3:
                    time.incrementHour(time, date);
                    System.out.println("\nTime: " + time+"\nDate: "+date);
                    System.out.println("\n");
                    break;
                case 4:
                    inc = false;
                    break;
            }

        }
    }


    public static Date inputDate(boolean inc) {
        Scanner s = new Scanner(System.in);
        //System.out.println("If you would like to enter a custom time press 1, if not press any other number...");
        //        int choice = s.nextInt();
        //
        //        if (choice == 1) {
            System.out.println("Please enter the date in this format: mm/dd/yyyy");
            String input = s.next();
            String arr[] = input.split("/");
            int month = Integer.parseInt(arr[0]);
            int day = Integer.parseInt(arr[1]);
            int year = Integer.parseInt(arr[2]);
            Date date = new Date(month, day, year);
            return date;

       // } else {
        //            Date date = autoDate();
        //            menuDate(date);
        //        }



    }

    //private static Date autoDate() {
    //        LocalDateTime ldt = LocalDateTime.now();
    //        DateTimeFormatter dtf = DateTimeFormatter.ofPattern("MM/dd/yyyy");
    //        String _date = dtf.format(ldt);
    //        String arrD[] = _date.split("/");
    //        int month = Integer.parseInt(arrD[0]);
    //        int day = Integer.parseInt(arrD[1]);
    //        int year = Integer.parseInt(arrD[2]);
    //        Date date = new Date(month, day, year);
    //
    //        return date;
    //    }

    private static void menuDate(Date date) {
        boolean inc = true;
        Scanner s = new Scanner(System.in);
        while (inc == true) {
            System.out.println("What would you like to do? Increment...\n Date : 1\n Month : 2\n Year : 3\n Quit : 4");
            int choice = s.nextInt();
            switch (choice) {
                case 1:
                    date = date.incrementDay(date);
                    System.out.println("\n" + date);
                    System.out.println("\n");
                    break;
                case 2:
                    date = date.incrementMonth(date);
                    System.out.println("\n" + date);
                    System.out.println("\n");
                    break;
                case 3:
                    date = date.incrementYear(date);
                    System.out.println("\n" + date);
                    System.out.println("\n");
                    break;
                case 4:
                    inc = false;
                    break;
            }
        }
    }
}




