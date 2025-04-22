using SimpleFactory.Messages;

namespace SimpleFactory.Weapons
{
    public class Gun : WeaponsStats, IWeapon
    {

        public Gun()
        {
            InitialResource = 6;
            ResourcePerRecharge = 3;
            DamageAttack = 6;
            DamageSkill = 10;
            ResourcePerAttack = 1;
            Defense = 2;
            ResourcePerSkill = 3;
        }

        public void Atack()
        {
            if (!CanAttack(ResourcePerAttack))
            {
                CanNotAmount(ResourcePerAttack);
                return;
            }

            InitialResource -= ResourcePerAttack;

            Console.WriteLine(WeaponsMessages.GunAtack, ResourcePerAttack);
        }

        public bool CanAttack(int bulletsRequired) => InitialResource >= bulletsRequired;

        public void Shield() => Console.WriteLine(WeaponsMessages.GunShield, Defense);

        public void Skill()
        {
            if (!CanAttack(ResourcePerSkill))
            {
                CanNotAmount(ResourcePerSkill);
                return;
            }

            InitialResource -= ResourcePerSkill;
            Console.WriteLine(WeaponsMessages.GunSkill, DamageSkill);
        }

        public void Reload()
        {
            InitialResource += ResourcePerRecharge;
            Console.WriteLine(WeaponsMessages.GunReload, InitialResource);
        }

        public void CanNotAmount(int bulletsRequired)
        {
            Console.WriteLine(WeaponsMessages.CanNotAtack, InitialResource, "bullets", bulletsRequired);
        }
    }
}
