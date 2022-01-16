using System;
using System.Collections.Generic;

namespace C__Assignment___Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>(){
                new Member{
                FirstName = "Bui",
                LastName = "Huong",
                Gender = "Male",
                DateOfBirth = new DateTime(2000,6,26),
                PhoneNumber = "0338559513",
                BirthPlace = "Ha Noi",
                IsGraduated = false,
                },
                new Member{
                FirstName = "Nguyen",
                LastName = "Loc",
                Gender = "Female",
                DateOfBirth = new DateTime(1999,6,26),
                PhoneNumber = "0338559513",
                BirthPlace = "Ha Noi",
                IsGraduated = false,
                },
                new Member{
                FirstName = "Hong",
                LastName = "Tung",
                Gender = "Female",
                DateOfBirth = new DateTime(2001,6,26),
                PhoneNumber = "0338559513",
                BirthPlace = "Ha Noi",
                IsGraduated = true,
                },
            };
            //bai 1
            foreach (Member member in members)
            {
                if (member.Gender == "Male")
                {
                    Console.WriteLine("{0} {1}", member.FirstName, member.LastName);
                }

            }
            //bài 2
            var max_age = 0;
            foreach (Member member in members)
            {
                if (member.Age < max_age)
                {
                    max_age = member.Age;
                }
            }
            foreach (var item in members)
            {
                if (item.Age == max_age)
                {
                    Console.WriteLine("Oldest: {0} {1} {2}", item.FirstName, item.LastName, item.Age);
                }
            }
            //bai 3
            List<string> newListMember = new List<string>();
            Console.WriteLine("Full name in new list: ");
            foreach (var people in members)
            {
                newListMember.Add($"{people.FirstName} {people.LastName}");
            }
            foreach (string person in newListMember)
            {
                Console.WriteLine(person);
            }
            //bai 4
            // Console.WriteLine("List of members who has birth year is 2000: ");
            // foreach(Member member in members){
            //     if(member.DateOfBirth.Year == 2000){
            //         Console.WriteLine("{0} {1} {2}", member.FirstName, member.LastName, member.DateOfBirth);
            //     }
            // }
            // Console.WriteLine("List of members who has birth year greater than 2000: ");
            // foreach(Member member in members){
            //     if(member.DateOfBirth.Year < 2000){
            //         Console.WriteLine("{0} {1} {2}", member.FirstName, member.LastName, member.DateOfBirth);
            //     }
            // }
            // Console.WriteLine("List of members who has birth year less than 2000: ");
            // foreach(Member member in members){
            //     if(member.DateOfBirth.Year > 2000){
            //         Console.WriteLine("{0} {1} {2}", member.FirstName, member.LastName, member.DateOfBirth);
            //     }
            // }

            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            var T = 0;
            foreach (Member member in members)
            {
                var birthYear = member.DateOfBirth.Year;
                if (birthYear == 2000)
                {
                    T = 0;
                }
                else if (birthYear > 2000)
                {
                    T = 1;
                }
                else
                {
                    T = 2;
                }
                switch (T)
                {
                    case 0:
                        list1.Add($"{member.FirstName} {member.LastName} {member.Gender} {member.DateOfBirth} {member.PhoneNumber} {member.BirthPlace} {member.IsGraduated}");
                        break;
                    case 1:
                        list2.Add($"{member.FirstName} {member.LastName} {member.Gender} {member.DateOfBirth} {member.PhoneNumber} {member.BirthPlace} {member.IsGraduated}");
                        break;
                    case 2:
                        list3.Add($"{member.FirstName} {member.LastName} {member.Gender} {member.DateOfBirth} {member.PhoneNumber} {member.BirthPlace} {member.IsGraduated}");
                        break;
                }
            }
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("List of members who has birth year is 2000: ");
            foreach (string member in list1)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("List of members who has birth year greater than 2000: ");
            foreach (string member in list2)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("List of members who has birth year less than 2000:  ");
            foreach (string member in list3)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine("--------------------------------------------------------------");
            //bai 5
            Console.WriteLine("Return the first person who was born in Ha Noi.");
            foreach (Member member in members)
            {
                while (member.BirthPlace == "Ha Noi")
                {
                    Console.WriteLine("{0} {1} {2} {3}", member.FirstName, member.LastName, member.Age, member.BirthPlace);
                }
                break;
            }
        }
    }
}
