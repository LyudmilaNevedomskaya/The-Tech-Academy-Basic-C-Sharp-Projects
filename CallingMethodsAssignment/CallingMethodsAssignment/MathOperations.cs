using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class MathOperations
    {
        public static int Heal(int magic)
        {
            int hitpoints = magic + 10;
            return hitpoints;
        }

        public static int Defence(int defence)
        {
            int enemyStrength = 7;
            int weaponMt = 11;
            int triangleBonus = -1;
            int critCoeff = 1;
            int damage = (enemyStrength + (weaponMt + triangleBonus) - defence) * critCoeff;
            return damage;
        }

        public static int Attack(int strength)
        {
            int enemyDef = 4;
            int weaponMt = 8;
            int triangleBonus = 1;
            int critCoeff = 3;
            int damage = (strength + (weaponMt + triangleBonus) - enemyDef) * critCoeff;
            return damage;
        }
    }
}
