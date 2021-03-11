package com.company;

public class Sales {
    String Name;
    double Total;

    Sales (String name, double total)
    {
        Name = name;
        Total = total;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public double getTotal() {
        return Total;
    }

    public void setTotal(double total) {
        Total = total;
    }
}
