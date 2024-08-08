using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine1
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage {  get; set; }
        public int RewardExpriencePoints {  get; set; }
        public int RewardGold {  get; set; }

        public Monster(int id, string name, int maximumDamage, int rewardExperiencePoints, int rewardGold,
            int currentHitPoints, int maximumHitPoints) : base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExpriencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
        }
    }
}
