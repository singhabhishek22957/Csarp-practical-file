using System;



// # Parrent class: person have name , age,  address  -> inherit subclass student with the parameters ID, Class , marks, percentage -> create a sub class of Employee with Id, qualification , Designations, salary . Print the information about two student and two employee  


public class Person {

    public string name = "";
    public int age = 0;
    public string  address= "";


}

public class Student : Person{
    public int id = 0;
    public string className = "";
    public double marks = 0;
    public double percentage= 0;

    public Student(int id , string className, string name , int age , string address , double marks , double percentage)
    {
        this.id = id;
        this.className = className;
        this.marks = marks;
        this.percentage = percentage;
        this.name = name;
        this.age = age;
        this.address = address;

    }

    public void DisplayStudentInfo(){
        Console.WriteLine("Student Id:"+id);
        Console.WriteLine("Student Name:"+name);
        Console.WriteLine("Student Age:"+age);
        Console.WriteLine("Student Address:"+address);
        Console.WriteLine("Student Class:"+className);
        Console.WriteLine("Student Marks:"+marks);
        Console.WriteLine("Student Percentage:"+percentage);
    }

}



public class Employee : Person{
    public int id = 0;
    public string qualification  = "";
    public string  designations = "";
    public double  salary= 0;

    public Employee(int id , string qualification, string name , int age , string address , string designations , double salary)
    {
        this.id = id;
        this.qualification = qualification;
        this.designations = designations;
        this.salary = salary;
        this.name = name;
        this.age = age;
        this.address = address;

    }

    public void DisplayStudentInfo(){
        Console.WriteLine("Student Id:"+id);
        Console.WriteLine("Student Name:"+name);
        Console.WriteLine("Student Age:"+age);
        Console.WriteLine("Student Address:"+address);
        Console.WriteLine("Student Class:"+qualification);
        Console.WriteLine("Student Marks:"+designations);
        Console.WriteLine("Student Percentage:"+salary);
    }

}

