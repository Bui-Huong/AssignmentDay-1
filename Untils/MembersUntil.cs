using System;
using System.Collections.Generic;
using System.Linq;
using C__Assignment___Day_1.Enum;

namespace C__Assignment___Day_1.Untils
{
    public class MembersUntil
    {
        private List<Member> members;
        public MembersUntil()
        {
            members = InitMembers();
        }
        private List<Member> InitMembers()
        {
            return new List<Member>(){
                new Member{
                FirstName = "Bui",
                LastName = "Huong",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(2000,6,26),
                PhoneNumber = "0338559513",
                BirthPlace = "Ha Noi",
                IsGraduated = false,
                },
                new Member{
                FirstName = "Nguyen",
                LastName = "Loc",
                Gender = Gender.Female,
                DateOfBirth = new DateTime(1999,6,26),
                PhoneNumber = "0338559513",
                BirthPlace = "Ha Noi",
                IsGraduated = false,
                },
                new Member{
                FirstName = "Hong",
                LastName = "Tung",
                Gender = Gender.Other,
                DateOfBirth = new DateTime(2001,6,26),
                PhoneNumber = "0338559513",
                BirthPlace = "Ha Noi",
                IsGraduated = true,
                },
            };
        }
        public Member GetOldestMember(List<Member> abc)
        {
            return members.Where(m => m.Age == members.Max(m=>m.Age)).FirstOrDefault();
        }
        public List<string> GetFullNames(List<Member> members)
        {
            return members.Select(mem=>mem.MemberInfo).ToList();
        }
        public Member GetFirstMemberByBirthPlace(List<Member> members,string birthPlace)
        {
            Member result = members.FirstOrDefault(member=> member.BirthPlace == birthPlace);
            return result;
        }
        public List<Member> GetAllMembers()
        {
            return members;
        }
        public List<Member> GetMembersByBirthYearEqual2000(List<Member> members)
        {
            return members.Where(m => m.DateOfBirth.Year == 2000).ToList();
        }
        public List<Member> GetMembersByBirthYearLessThan2000(List<Member> members)
        {
            return members.Where(m => m.DateOfBirth.Year < 2000).ToList();
        }        public List<Member> GetMembersByBirthYearGreatThan2000(List<Member> members)
        {
            return members.Where(m => m.DateOfBirth.Year > 2000).ToList();
        }
    }
}