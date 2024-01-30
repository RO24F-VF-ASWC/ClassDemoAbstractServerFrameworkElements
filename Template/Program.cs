// See https://aka.ms/new-console-template for more information
using Template.TemplateDesignPattern;

//AbstractADT adt = new ListADT();
AbstractADT adt = new SetADT();

adt.Add("Peter");
adt.Add("Anders");
adt.Add("Jens Peter");
adt.Add("Michael");
adt.Add("Michael"); // <- two times

Console.WriteLine(adt);