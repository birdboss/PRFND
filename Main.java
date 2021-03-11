package com.company;

import java.util.ArrayList;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        boolean running = true;
        Sales sales = new Sales("Dylan", 10.00);
        ArrayList<Sales> itemsSold = new ArrayList();
        double[][] itemCost = new double[4][2];
        itemCost=populateArray(itemCost);
        while (running) {
            mainMenu(itemsSold, itemCost);
            running = false;
        }


    }

    private static void mainMenu(ArrayList<Sales> itemsSold, double[][] itemCost) {
        String choice;
        Scanner s = new Scanner(System.in);
        System.out.println("Please make a selection:\nNew entry: 1\nDisplay: 2\nQuit: 3");
        choice = s.next();
        switch (choice){

            case "1":
                newEntry(itemCost, itemsSold);
                break;
            case "2":
                getEmployee(itemsSold);
                break;
            case "3":
                return;
        }
    }

    private static void getEmployee(ArrayList<Sales> itemsSold) {
        Scanner s = new Scanner(System.in);
        for(int i = 0; i < itemsSold.size(); i ++){
            System.out.println(itemsSold.get(i));
            //System.out.println("Name: "+ itemsSold.get(i));
            //System.out.println("Total: "+sales.getTotal());
        }



    }

    private static void newEntry(double[][] itemCost, ArrayList<Sales> itemsSold) {
        Scanner s = new Scanner(System.in);
        String name;
        double total;
        System.out.println("Enter the employee's Name:");
        name = s.next();
        total = getTotal(itemCost);
        Sales sales = new Sales(name, total);
        itemsSold.add(sales);
        System.out.println("New employee successfully entered.");
        mainMenu(itemsSold,itemCost);
    }

    private static double getTotal(double[][] itemCost) {
        Scanner s = new Scanner(System.in);
        double total = 0;
        int i;
        boolean running = true;
        System.out.println("Enter the information for the product sold");
        while(running)
        {
            int qty;
            double price;
            System.out.print("ID: ");
            i = s.nextInt();
            System.out.print("Quantity: ");
            qty = s.nextInt();
            price = itemCost[i][1];
            double _total = price * qty;
            total = ((total + _total)*0.09)+(total+_total);

            System.out.println("Would you like to add another item?\nYes: 1\nNo: 2");
            int choice = s.nextInt();
            if (choice == 2)
            {
                running = false;
            }
        }
        return total;
    }


    private static double[][] populateArray(double[][] itemCost) {
        itemCost[0][0] = 1;
        itemCost[0][1] = 239.99;
        itemCost[1][0] = 2;
        itemCost[1][1] = 129.75;
        itemCost[2][0] = 3;
        itemCost[2][1] = 99.95;
        itemCost[3][0] = 4;
        itemCost[3][1] = 350.89;
        return itemCost;
    }
}
