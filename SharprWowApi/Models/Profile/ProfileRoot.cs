using SharprWowApi.Models.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharprWowApi.Models.Profile
{
    public class ProfileRoot
    {
        public IEnumerable<CharacterRoot> Characters { get; set; }
    }
}
