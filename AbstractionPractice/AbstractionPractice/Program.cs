using AbstractionPractice.Abstract;
using AbstractionPractice.Concrete;

BasePerson softwareDeveloper1  = new SoftwareDeveloper("Yılmaz", "Çınar", "IT");

BasePerson projectManager1 = new ProjectManager("Gökmen", "Özdanak", "IT");

BasePerson salesRepresentative1 = new SalesRepresentative("Ali", "Fırat","Sales and Marketing");


softwareDeveloper1.Gorev();
projectManager1.Gorev();
salesRepresentative1.Gorev();
