using UnityEngine;

namespace Monsters.DarkDragon
{
    public class AttackOnSightDrkDragon : MonoBehaviour
    {
        public GameObject dragon;

        // Start is called before the first frame update
        void OnTriggerEnter(Collider other)
        {
            if (dragon.GetComponent<DragonClass>().currentHealth > 0)
            {
                if (other.gameObject.CompareTag("Terror"))
                {
                    var dragonEnemy = other.gameObject.GetComponent<DragonClass>();
                    if (!dragonEnemy.isDead)
                    {
                        dragonEnemy.TakeDamge(Attack01());
                        dragonEnemy.isWinner = false;
                    }
                    else
                    {
                        dragon.GetComponent<DragonClass>().isWinner = true;
                    }
                
                }
            }
        }

        private int Attack01()
        {
            int dmg = dragon.GetComponent<DragonClass>().physycalDmg + 35;
            dragon.GetComponent<DrkDragonAttack>().currentMana -= 20;
            dragon.GetComponent<DrkDragonAttack>().ManaSlider.value =
                dragon.GetComponent<DrkDragonAttack>().currentMana;
            return dmg;
        }
    }
}