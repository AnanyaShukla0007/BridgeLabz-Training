using System;
class AccessModifier{
    //public - accesible everywhere
    public int num1=20;
    //private - accessible only inside the class
    private int num2=40;
    //protected - accessible in this class and subclass
    protected int num3=60;
    //internal - accessible in this project 
    internal int num4 = 80;
    // protected internal – accessible either
    // 1) in the same project OR
    // 2) in derived classes (even outside project)
    protected internal int num5 = 100;
    // private protected – accessible only in
    // derived classes within the same project
    private protected int num6 = 120;
    private void ShowPrivate(){
        Console.WriteLine("The private number is: " + num2); //40
    }
    public void display(){
        Console.WriteLine("The protected number is: " + num3); //60
        Console.WriteLine("The Public variable is: " + num1); //20
        Console.WriteLine("The internal variable is: " + num4); //80
        ShowPrivate();
    }
    static void Main(string[] args){
            AccessModifier am=new AccessModifier();
            am.display();
    }
}