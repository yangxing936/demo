using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        private static IMapper _mapper;
        public Program(IMapper mapper) 
        {
            _mapper = mapper;
        }
        static void Main(string[] args)
        {
            UserInfoS c = new UserInfoS()
            {
                Age = "1",
                Name = "2",
                Tel = "3"
            };

            List<UserInfoS> userInfoS = new List<UserInfoS>();
            userInfoS.Add(c);

            var UserInfo = Mapper.Map<List<UserInfo>>(userInfoS);
            Console.Read();
        }
    }
    public class UserInfo
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Tel { get; set; }
    }
    public class UserInfoS
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Tel { get; set; }
    }
}
