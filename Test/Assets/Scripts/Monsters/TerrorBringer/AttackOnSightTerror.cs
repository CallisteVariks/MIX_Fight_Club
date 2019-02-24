using System.Collections;
using System.Collections.Generic;
using Monsters.TerrorBringer;
using UnityEngine;

namespace Monsters.TerrorBringer
{
    public class AttackOnSightTerror : MonoBehaviour
    {
        public GameObject dragon;

        // Start is called before the first frame update
        void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.gameObject.tag);

            if (dragon.GetComponent<DragonClass>().currentHealth > 0)
            {
                if (other.gameObject.CompareTag("DrkDragon"))
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
            dragon.GetComponent<TerrorBringerAtk>().currentMana -= 20;
            dragon.GetComponent<TerrorBringerAtk>().ManaSlider.value =
                dragon.GetComponent<TerrorBringerAtk>().currentMana;

            return dmg;
        }
    }
}