using System;
using C__Assignment___Day_1.Untils;
using C__Assignment___Day_1.Enum;
using System.Linq;
using System.Collections.Generic;

namespace C__Assignment___Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //bai 1
            MembersUntil membersUntil = new MembersUntil();
            var maleMembers = membersUntil.GetAllMembers().Where(m => m.Gender == Gender.Male);
            var femaleMembers = membersUntil.GetAllMembers().Where(m => m.Gender == Gender.Female);
            var otherMembers = membersUntil.GetAllMembers().Where(m => m.Gender == Gender.Other);
            Console.WriteLine("Female list: ");
            
            foreach (Member member in femaleMembers)
            {
                Console.WriteLine("{0}", member.MemberInfo);
            }

            Console.WriteLine("male list: ");
            foreach (Member member in maleMembers)
            {
                Console.WriteLine("{0}", member.MemberInfo);
            }

            Console.WriteLine("other list: ");
            foreach (Member member in otherMembers)
            {
                Console.WriteLine("{0}", member.MemberInfo);
            }
            // bài 2
            Member olderstMember = membersUntil.GetOldestMember(membersUntil.GetAllMembers());
            Console.WriteLine("Oldest: {0}", olderstMember.MemberInfo);
            // var max_age = 0;
            // foreach (Member member in members)
            // {
            //     if (member.Age < max_age)
            //     {
            //         max_age = member.Age;
            //     }
            // }
            // foreach (var item in members)
            // {
            //     if (item.Age == max_age)
            //     {
            //         Console.WriteLine("Oldest: {0} {1} {2}", item.FirstName, item.LastName, item.Age);
            //     }
            // }
            //bai 3
            foreach(string name in membersUntil.GetFullNames(membersUntil.GetAllMembers()))
            {
                Console.WriteLine("Full name in new list: "+ name);
            }
            // List<String> fullNames = membersUntil.FullNames(listMembers);
            // Console.WriteLine("Full name in new list: ");
            // fullNames.Foreach(m => { Console.WriteLine("Full name: " + m); });
            // // foreach (var people in members)
            // // {
            // //     newListMember.Add($"{people.FirstName} {people.LastName}");
            // // }
            // // foreach (string person in newListMember)
            // // {
            // //     Console.WriteLine(person);
            // // }
            //bai 4
            foreach(Member m in membersUntil.GetMembersByBirthYearEqual2000(membersUntil.GetAllMembers()))
            {
                Console.WriteLine("Members By Birth Year Equal 2000: " +m.MemberInfo);
            }
            membersUntil.GetMembersByBirthYearGreatThan2000(membersUntil.GetAllMembers()).ForEach(m=>Console.WriteLine("Members By Birth Year Great Than 2000: "+m.MemberInfo));
            // // Console.WriteLine("List of members who has birth year is 2000: ");
            // // foreach(Member member in members){
            // //     if(member.DateOfBirth.Year == 2000){
            // //         Console.WriteLine("{0} {1} {2}", member.FirstName, member.LastName, member.DateOfBirth);
            // //     }
            // // }
            // // Console.WriteLine("List of members who has birth year greater than 2000: ");
            // // foreach(Member member in members){
            // //     if(member.DateOfBirth.Year < 2000){
            // //         Console.WriteLine("{0} {1} {2}", member.FirstName, member.LastName, member.DateOfBirth);
            // //     }
            // // }
            // // Console.WriteLine("List of members who has birth year less than 2000: ");
            // // foreach(Member member in members){
            // //     if(member.DateOfBirth.Year > 2000){
            // //         Console.WriteLine("{0} {1} {2}", member.FirstName, member.LastName, member.DateOfBirth);
            // //     }
            // // }
            // // List<string> list1 = new List<string>();
            // // List<string> list2 = new List<string>();
            // // List<string> list3 = new List<string>();
            // // var T = 0;
            // // foreach (Member member in members)
            // // {
            // //     var birthYear = member.DateOfBirth.Year;
            // //     if (birthYear == 2000)
            // //     {
            // //         T = 0;
            // //     }
            // //     else if (birthYear > 2000)
            // //     {
            // //         T = 1;
            // //     }
            // //     else
            // //     {
            // //         T = 2;
            // //     }
            // //     switch (T)
            // //     {
            // //         case 0:
            // //             list1.Add($"{member.FirstName} {member.LastName} {member.Gender} {member.DateOfBirth} {member.PhoneNumber} {member.BirthPlace} {member.IsGraduated}");
            // //             break;
            // //         case 1:
            // //             list2.Add($"{member.FirstName} {member.LastName} {member.Gender} {member.DateOfBirth} {member.PhoneNumber} {member.BirthPlace} {member.IsGraduated}");
            // //             break;
            // //         case 2:
            // //             list3.Add($"{member.FirstName} {member.LastName} {member.Gender} {member.DateOfBirth} {member.PhoneNumber} {member.BirthPlace} {member.IsGraduated}");
            // //             break;
            // //     }
            // // }
            // // Console.WriteLine("--------------------------------------------------------------");
            // // Console.WriteLine("List of members who has birth year is 2000: ");
            // // foreach (string member in list1)
            // // {
            // //     Console.WriteLine(member);
            // // }
            // // Console.WriteLine("--------------------------------------------------------------");
            // // Console.WriteLine("List of members who has birth year greater than 2000: ");
            // // foreach (string member in list2)
            // // {
            // //     Console.WriteLine(member);
            // // }
            // // Console.WriteLine("--------------------------------------------------------------");
            // // Console.WriteLine("List of members who has birth year less than 2000:  ");
            // // foreach (string member in list3)
            // // {
            // //     Console.WriteLine(member);
            // // }
            // // Console.WriteLine("--------------------------------------------------------------");
            //bai 5
            Console.WriteLine("Return the first person who was born in Ha Noi: "+membersUntil.GetFirstMemberByBirthPlace(membersUntil.GetAllMembers(),"Ha Noi").MemberInfo);
            // // foreach (Member member in members)
            // // {
            // //     while (member.BirthPlace == "Ha Noi")
            // //     {
            // //         Console.WriteLine("{0} {1} {2} {3}", member.FirstName, member.LastName, member.Age, member.BirthPlace);
            // //     }
            // //     break;
            // // }
            // // Console.WriteLine("Return the first person who was born in Ha Noi.");
            // // int i = 0;
            // // while (true)
            // // {
            // //     if (members[i].BirthPlace == "Ha Noi")
            // //     {
            // //         Console.WriteLine("{0} {1} {2} {3}", members[i].FirstName, members[i].LastName, members[i].Age, members[i].BirthPlace);
            // //         break;
            // //     }
            // //     i++;
            // // }
            // Console.WriteLine("List of members who has birth less than 2000: ");
            // membersUntil.Members.Where(m->m.DateOfBirth.Year < 2000).Select(x->x.MemberInfo).ToList().Foreach(x->Console.WriteLine(x));
            // Console.WriteLine("List of members who has birth greater than 2000: ");
            // membersUntil.Members.Where(m->m.DateOfBirth.Year > 2000).Select(x->x.MemberInfo).ToList().Foreach(x->Console.WriteLine(x));
            // Console.WriteLine("List of members who has birth year is 2000: ");
            // membersUntil.Members.Where(m->m.DateOfBirth.Year == 2000).Select(x->x.MemberInfo).ToList().Foreach(x->Console.WriteLine(x));

        }
    }
}
