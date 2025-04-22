using System;
namespace SimpleFactory.Weapons
{
    public interface IWeapon
    {
        void Atack();
        void Shield();
        void Skill();
        bool CanAttack(int amount);
        void CanNotAmount(int damage);
        void Reload();
    }
}
