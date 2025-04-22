using SimpleFactory.Messages;

namespace SimpleFactory.Weapons
{
    public class MagicStaff : WeaponsStats, IWeapon
    {
        public MagicStaff()
        {
            InitialResource = 20;
            ResourcePerRecharge = 5;
            DamageAttack = 3;
            DamageSkill = 15;
            ResourcePerAttack = 2;
            ResourcePerSkill = 10;
            Defense = 3;
        }

        public void Atack()
        {
            if (!CanAttack(ResourcePerAttack))
            {
                CanNotAmount(ResourcePerAttack);
                return;
            }

            InitialResource -= ResourcePerAttack;

            Console.WriteLine(WeaponsMessages.MagicStaffAtack, ResourcePerAttack);
        }

        public bool CanAttack(int manaRequired) => InitialResource >= manaRequired;

        public void Shield() => Console.WriteLine(WeaponsMessages.MagicStaffShield, Defense);

        public void Skill()
        {
            if (!CanAttack(ResourcePerSkill))
            {
                CanNotAmount(ResourcePerSkill);
                return;
            }

            InitialResource -= ResourcePerSkill;
            Console.WriteLine(WeaponsMessages.MagicStaffSkill, DamageSkill);
        }

        public void Reload()
        {
            InitialResource += ResourcePerRecharge;
            Console.WriteLine(WeaponsMessages.StaffReload, InitialResource);
        }

        public void CanNotAmount(int manaRequired)
        {
            Console.WriteLine(WeaponsMessages.CanNotAtack, InitialResource, "mana", manaRequired);
        }
    }
}
