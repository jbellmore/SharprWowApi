using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharprWowApi.Models.Profile
{
    public class ProfileCharacter
    {
        public long AchievementPoints { get; set; }
        public string BattleGroup { get; set; }
        public int Class { get; set; }
        public int Gender { get; set; }
        public string GuildRealm { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public int Race { get; set; }
        public string Realm { get; set; }
        public ProfileCharacterSpec Spec { get; set; }
        public string Thumbnail { get; set; }
    }
}
