using System;
class YoungTall{
    static void Main(){
        double[] salary=new double[10];
        double[] years=new double[10];
        double[] bonus=new double[10];
        double[] newSalary=new double[10];
        double totalBonus=0,totalOld=0,totalNew=0;
        for(int i=0;i<10;i++){
            Console.Write($"Salary of Employee {i+1}: "0);
            salary[i] = double.Parse(Console.ReadLine());
            Console.Write($"Years of service: ");
            years[i] = double.Parse(Console.ReadLine());
            if (salary[i]<=0||years[i]<0){
                Console.WriteLine("Invalid input");
                i--;
                continue;
            }
        }
        for (int i = 0; i < 10; i++){
            bonus[i]=years[i]>5?salary[i]*0.05:salary[i]*0.02;
            newSalary[i]=salary[i]+bonus[i];
            totalBonus += bonus[i];
            totalOld += salary[i];
            totalNew += newSalary[i];
        }
        Console.WriteLine($"Total Bonus = {totalBonus}");
        Console.WriteLine($"Total Old Salary = {totalOld}");
        Console.WriteLine($"Total New Salary = {totalNew}");
    }
}