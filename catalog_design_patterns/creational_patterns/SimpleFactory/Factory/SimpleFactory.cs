using SimpleFactory.Enums;
using SimpleFactory.Weapons;

namespace SimpleFactory.Factory
{
    public static class WeaponFactory
    {
        public static IWeapon CreateWeapon(WeaponType type)
        {
            return type switch
            {
                WeaponType.Sword => new Sword(),

                WeaponType.Gun => new Gun(),

                WeaponType.MagicStaff => new MagicStaff(),

                _ => throw new NotImplementedException(),
                
            };
        }
    }
}
