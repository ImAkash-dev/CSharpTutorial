using CClassTutorial;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Versioning;
using System.Security;

//Bank class

//Bank bank = new Bank();
//bank.name = "PNB";
//bank.Branch = "Purkaji";
//Console.WriteLine("bank name is " + bank.name);
//bank.Accountopen();
//bank.CashDeposite();
//bank.PaasBookprint();
//bank.BalanceCheck();

//Bike class


//Bike bike= new Bike();
//bike.name = "splendor";
//Console.WriteLine(" bike name = " +bike.name);
//bike.company = "Honda";
//Console.WriteLine("bike company name = "+bike.company);
//bike.model = 2023;
//Console.WriteLine("bike model = " + bike.model);
//bike.fuelcapacity= 10;
//Console.WriteLine("bike fuelcapacity = "+bike.fuelcapacity);
//bike.gear = 4;
//Console.WriteLine("how many gear in bike = " + bike.gear);
//bike.start();
//bike.race();
//bike.speedup();
//bike.speeddown();
//bike.Break();
//bike.stop();
//Car class

//Car car=new Car();
//car.name = "Thar";
//Console.WriteLine("car name = "+car.name);
//car.company = "Mahindra";
//Console.WriteLine("car company name = "+car.company);
//car.model = 2022;
//Console.WriteLine("car model = " + car.model);
//car.fuelcapacity = 35;
//Console.WriteLine(" fuel capacity = " + car.fuelcapacity);
//car.seats = 5;
//Console.WriteLine(" total seats = " + car.seats);
//car.openwindow();
//car.Race();
//car.speedup();
//car.speeddown();
//car.Break();
//car.stop();
//car.openwindowAagain();
//car.closewindow();

//Company class
//Company company= new Company();
//company.Name = "HK PVT LTD";
//Console.WriteLine(" compnay name = " + company.Name);
//company.address = "haridwar,uttrakhand";
//Console.WriteLine("company address = " + company.address);
//company.registratinnumber = 234324;
//Console.WriteLine(" company registration number = "+company.registratinnumber);
//company.totalnumberofemploy = 34;
//Console.WriteLine(" total number of employ = "+company.totalnumberofemploy);
//company.work();
//company.sallry();

//institute class
//Institute institute= new Institute();
//institute.institutename = "Tech Yatra";
//Console.WriteLine("Institute Name = "+institute.institutename);
//institute.Address = "Purkaji,Uttart Pradesh";
//Console.WriteLine("institute address = " + institute.Address);
//institute.Teachername= "Nishant Gupta";
//Console.WriteLine(" Teacther Name = "+institute.Teachername);
//institute.Teacheraddress = "Purkaji, Uttar Pradesh";
//Console.WriteLine(" teacher address = "+institute.Teacheraddress);
//institute.Mobilenumber = 9878987645;
//Console.WriteLine("Teacher mobile number = "+institute.Mobilenumber);
//institute.totalstudent = 20;
//Console.WriteLine(" Total number of Student = " + institute.totalstudent);
//institute.entry();
//institute.study();
//institute.submitfee();

//Hotel class
//Hospital hospital= new Hospital();
//hospital.name = "City Hospital";
//{
//    Console.WriteLine("Hospital Name is = "+hospital.name);
//}
//hospital.address = "Haridwar,Uttrakhand";
//{
//    Console.WriteLine("Hospital Addres is = " + hospital.address);
//}
//hospital.totalnumberofflour = 6;
//{
//    Console.WriteLine("Total Number of Flour = " + hospital.totalnumberofflour);
//}
//hospital.totalnumberofdocter = 22;
//{
//    Console.WriteLine("Total Number Of Doctor = " +hospital .totalnumberofdocter);
//}
//hospital.Deanname = "Prakash Rawat";
//{
//    Console.WriteLine(" Dean name is = " + hospital.Deanname);
//}
//hospital.totalrooms = 24;
//{
//    Console.WriteLine("Total number of Rooms = " + hospital.totalrooms);
//}
//hospital.appointment();
//hospital.Medicine();
//hospital.submitbill();
//hospital.backtohome();

//constructor class
//Studentconstructor studentconstructor = new Studentconstructor();
//studentconstructor.name = "Akash Tygai";
//Console.WriteLine("Student Name = " + studentconstructor.name);
//studentconstructor.ID = 12;
//Console.WriteLine("Student ID number = " + studentconstructor.ID);
//studentconstructor.age = 24;
//Console.WriteLine("Student Age = " + studentconstructor.age);
//studentconstructor.address = "Ghumavati";
//Console.WriteLine("Student Address = " + studentconstructor.address);
//studentconstructor.entry();
//studentconstructor.study();

//Console.WriteLine(" ");
//Console.WriteLine("Second Student Information : ");
//Console.WriteLine(" ");
//Studentconstructor studentconstructor2 = new Studentconstructor();
//studentconstructor2.name = "Rakshak";
//Console.WriteLine("Student Name = " + studentconstructor2.name);
//Console.WriteLine("Student ID Number = " + studentconstructor2.ID);
//studentconstructor2.age = 23;
//Console.WriteLine("Student age = " + studentconstructor2.age);
//studentconstructor2.address = "Purkazi";
//Console.WriteLine("Student Address = " + studentconstructor2.address);
//studentconstructor2.entry();
//studentconstructor2.study();

//Village class

//Village village= new Village();
//village.name = "Ghumavati";
//    Console.WriteLine(" My Village name is = "+village.name);
//village.Address = "Ghumavati ,muzaffarnagar";
//Console.WriteLine(" village address is = "+village.Address);
//village.totalnoofroad = 12;
//Console.WriteLine("Total number of Road = "+village.totalnoofroad);
//village.totalnoofhouse = 765;
//Console.WriteLine(" Total number od House = " + village.totalnoofhouse);
//village.population = 1900;
//Console.WriteLine(" Total Population = "+village.population);
//village.playing();
//village.walk();



//Bank2 claas
//Bank2 bank2=new Bank2();
//bank2.bankname = "PNB";
//Console.WriteLine("Bank name is = " + bank2.bankname);
//bank2.address = "Tuglakuur,Kamhera";
//Console.WriteLine("Bank address is = " + bank2.address);
//bank2.employid = 23123;
//Console.WriteLine("Empoy id is = " + bank2.employid);
//bank2.employname = "Akash Tyagi ";
//Console.WriteLine("Emploiy name is = "+bank2.employname);
//bank2.employaddress = "Ghumavati";
//Console.WriteLine("Employ addrees = "+bank2.employaddress);
//bank2.entry();
//bank2.openbankaccoumt();
//bank2.depositecash();
//bank2.printpassbok();
//Console.WriteLine(" ");
//Console.WriteLine("Second Coustomer Information");
//Console.WriteLine(" ");
//Bank2 bank3 = new Bank2();
//bank3.address = "Tuglakuur,Kamhera";
//Console.WriteLine("Bank address is = " + bank3.address);
//bank3.employid = 22123;
//Console.WriteLine("Empoy id is = " + bank3.employid);
//bank3.employname =" Aman Tyagi ";
//Console.WriteLine("Emploiy name is = " + bank3.employname);
//bank3.employaddress = "Ghumavati";
//Console.WriteLine("Employ addrees = " + bank3.employaddress);
//bank3.entry();
//bank3.openbankaccoumt();
//bank3.depositecash();
//bank3.printpassbok();


////copy constructor example
//Student.Age = 12;
//Console.WriteLine(Student.Age);
//Student.PrintName("Aakash", "sharma");


//Student student = new Student();
//student.Id = 1;
//student.firstname = "Aakash";
//student.lastname = "Bhardwaj";
//student.mobile = 234567676;
//Student student2 = new Student(student);
//Console.WriteLine(student2.Id + " - " + student2.firstname);


//Prameterized constructor exaple


//Student student = new Student(12334, "fname", "lname");
//Console.WriteLine("student Mobile number = " + student.mobile);
//student.firstname = "Akash";
//student.lastname = "Bhardwaj";
//Console.WriteLine("Student full Name = " + student.firstname + " " + student.lastname);

//Console.WriteLine(" ");
//Console.WriteLine("Second student iformation");
//Console.WriteLine(" ");
//Student student2 = new Student(7310909155, "Arjun", "Tyagi");
//Console.WriteLine("Student Mobile Number = " + student2.mobile);
//Console.WriteLine("Student FUll Name = " + student2.firstname + " " + student2.lastname);

      //house class example

House house=new House();
house.Address = "Ghumavati";
Console.WriteLine("House address is = "+house.Address);
house.room = 5;
Console.WriteLine("total room in the  house  = " + house.room);
house.stears= 10;
Console.WriteLine("total no of stears = "+house.stears);
Console.WriteLine("total no of stears = "+house.stears);
Console.WriteLine("total no of stears = "+house.stears);

house.entry();
house.study();
house.sleep();