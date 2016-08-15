using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personal_details
{
    class Program
    {
        
         public class Personal_det{
  
                    String firstName, address, lastName;
                    int age;
                    string sex;
                    int phoneNumber;
  
          public Personal_det(){
                     firstName = address = lastName = "";
                     age = 0;
                     sex = "";
                     phoneNumber = 0;
             }

             public void setDetails(String firstName,String lastName,int age,string sex,int phoneNumber,String address){
                    this.firstName = firstName;
                    this.address = address;
                    this.lastName = lastName;
                    this.age = age;
                    this.sex = sex;
                    this.phoneNumber = phoneNumber;
            }
            public void printDetails(){
                   Console.WriteLine("\n\tStudent Details\nName: " + firstName
                   + "\nlastName: " + lastName + "\nSex: " + sex
                  + "\nAge: " + age + "\nPhone Number: " + phoneNumber 
                     + "\nAddress: " + address);
                }
            public static void Main(string[] args)
            {
               // string firstName, lastName,  Add;
               // int Age, Phone;
               // string Sex;
                //Console.WriteLine("Enter the firstname,lastname,age,sex,phone,address ");
                //firstName = Console.ReadLine();
                //lastName = Console.ReadLine();
               // Age = int.Parse(Console.ReadLine());
               //  Sex = Console.ReadLine();
               //  Phone = int.Parse(Console.ReadLine());
                 //Add = Console.ReadLine();
                Personal_det p1 = new Personal_det();              
                p1.setDetails("anu", "daniel", 20,"f",99665584, "kochi");
                p1.printDetails();
                Console.ReadLine();

            }
              
                
         }
      }                

}
    
    

