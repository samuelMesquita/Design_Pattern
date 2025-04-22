using SimpleFactory.Messages;

namespace SimpleFactory.Weapons
{
    public class Sword : WeaponsStats, IWeapon
    {
        public Sword()
        {
            InitialResource = 10;
            DamageAttack = 7;
            DamageSkill = 10;
            Defense = 5;
            ResourcePerRecharge = 5;
            ResourcePerAttack = 5;
            ResourcePerSkill = 10;
        }

        public void Atack()
        {
            if (!CanAttack(ResourcePerAttack))
            {
                CanNotAmount(ResourcePerAttack);
                return;
            }

            InitialResource -= ResourcePerAttack;

            Console.WriteLine(WeaponsMessages.SwordAtack, DamageAttack);
        }

        public bool CanAttack(int manaRequired) => InitialResource >= manaRequired;

        public void Shield() => Console.WriteLine(WeaponsMessages.SwordShield, Defense);

        public void Skill()
        {
            if (!CanAttack(ResourcePerSkill))
            {
                CanNotAmount(ResourcePerSkill);
                return;
            }

            InitialResource -= ResourcePerSkill;

            Console.WriteLine(WeaponsMessages.SwordSkill, DamageSkill);
        }

        public void Reload()
        {
            InitialResource += ResourcePerRecharge;
            Console.WriteLine(WeaponsMessages.SwordReload, InitialResource);
        }

        public void CanNotAmount(int staminaRequired)
        {
            Console.WriteLine(WeaponsMessages.CanNotAtack, InitialResource, "stamina", staminaRequired);
        }
    }
}
