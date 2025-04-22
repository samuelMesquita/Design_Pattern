namespace SimpleFactory.Messages
{
    public static class WeaponsMessages
    {
        public const string CanNotAtack = "You have {0} {1} left but need {2} to attack!";

        #region Magic Staff

        public const string MagicStaffAtack = "You strike with your Magic Staff, dealing {0} points of damage to your enemy.";
        public const string MagicStaffShield = "You raise your Magic Staff and create a mystical barrier, reducing the damage taken by {0} points.";
        public const string MagicStaffSkill = "You channel your energy through the Magic Staff and unleash a Fire Blast, dealing {0} points of damage!"; 
        public const string StaffReload = "You meditate and channel mystical energy, recovering your mana. Now you have {0} mana.";

        #endregion

        #region Gun

        public const string GunAtack = "You aim carefully and fire a shot, dealing {0} points of damage to your enemy!";
        public const string GunShield = "You quickly take cover and brace yourself, reducing the damage taken by {0} points.";
        public const string GunSkill = "You focus intensely and take the perfect shot! The bullet pierces your enemy’s weak point, dealing {0} points of critical damage!";
        public const string GunReload = "You reload your gun, refilling your ammunition, now you have {0}.";

        #endregion

        #region

        public const string SwordAtack = "You brandish your sword and strike the enemy, dealing {0} points of damage!";
        public const string SwordShield = "The best attack is defense. You take a defensive stance, but still feel the impact, reducing {0} points from your health.";
        public const string SwordSkill = "Your sword starts to shine, and you unleash a wind slash, dealing {0} points of damage!"; 
        public const string SwordReload = "You take a moment to catch your breath, recovering your stamina. Now you have {0} stamina.";

        #endregion
    }
}
