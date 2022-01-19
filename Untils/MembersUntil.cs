using System;
using System.Collections.Generic;
using System.Linq;
using C__Assignment___Day_1.Enum;

namespace C__Assignment___Day_1.Untils
{
    public class MembersUntil
    {
        public List<Member> Members;
        public MembersUntil()
        {
            Members = InitMembers();
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
        public Member GetOldestMember(List<Member> members)
        {
            return members.Where(m => m.Age == members.Max(m=>m.Age)).FirstOrDefault();
        }
        public List<string> FullNames(List<Member> members)
        {
            return members.Select(mem=>mem.MemberInfo).ToList();
        }
        public Member GetFirstMemberByBirthPlace(string birthPlace)
        {
            Member result = _members.First(member=> member.BirthPlace == birthPlace);
            return result;
        }
    }
}