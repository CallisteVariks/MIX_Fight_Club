using UnityEngine;
using UnityEngine.UI;

namespace Monster.DarkDragon
{
    public class DrkDragonAttack : MonoBehaviour
    {
        public Slider ManaSlider;
        public int currentMana;

        private GameObject enemy; //The enemy
        private DragonClass darkDragon; //The Dragon Attacking
        private Animator anim;
        private DragonClass enemyMonster;

        private void Awake()
        {
            darkDragon = GetComponent<DragonClass>();

            enemy = GameObject.FindGameObjectWithTag("Monster");
            enemyMonster = enemy.GetComponent<DragonClass>();

            anim = GetComponent<Animator>();
        }

        private void Start()
        {
            currentMana = darkDragon.mana;
        }

        private void Update()
        {
        }

        void Attack01()
        {
            int dmg = darkDragon.physycalDmg + 120;

            enemyMonster.TakeDamge(dmg);
        }

        void Attack02()
        {
            int dmg = darkDragon.magicDmg + 250;
            currentMana -= 350;
            ManaSlider.value = currentMana;
            enemyMonster.TakeDamge(dmg);
        }
    }
}