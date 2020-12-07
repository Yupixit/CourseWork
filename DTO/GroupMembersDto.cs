using System.Collections.Generic;
using System.IO;
using MySocialNetwork.DAO;

namespace MySocialNetwork.DTO
{
    public class GroupMembersDTO
    {
        public GroupRoles GroupRoles { get; set; }
        public List<IEnumerable<UserDto>> Members { get; set; }
    }
}