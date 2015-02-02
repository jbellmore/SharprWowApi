﻿
namespace SharprWowApi.WowModels
{
    public class CharacterFeed
    {
        public string Type { get; set; }
        public long Timestamp { get; set; }
        public int ItemId { get; set; }
        public CharacterFeedAchivements Achievement { get; set; }
        public bool? FeatOfStrength { get; set; }
        public CharacterFeedAchievementCriteria Criteria { get; set; }
        public int? Quantity { get; set; }
        public string Name { get; set; }
    }
}