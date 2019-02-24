using UnityEngine;
using UnityEngine.UI;

namespace Monsters
{
    public class DragonClass : MonoBehaviour
    {
        public int health,
            mana,
            armor,
            magicDmg,
            physycalDmg;

        public int currentHealth;
        public Slider HealthSlider;

        private Animator anim;
        internal bool isDead;
        private bool isDamaged;
        public bool isWinner;


        private void Awake()
        {
            anim = GetComponent<Animator>();
        }

        // Start is called before the first frame update
        void Start()
        {
            currentHealth = health;
        }


        // Update is called once per frame
        void Update()
        {
            if (!isDamaged)
            {
                isDamaged = false;
            }
            else
            {
                // anim.SetTrigger("GetHit");
                isDamaged = false;
            }
        }

        public void TakeDamge(int amount)
        {
            isDamaged = true;

            var totalDmg = amount - (armor / 100) * 5;
            currentHealth -= totalDmg;
            HealthSlider.value = currentHealth;

            if (!isDead && currentHealth <= 0)
            {
                Debug.Log("I AM DEAD: " + tag);
                Death();
            }
        }

        void Death()
        {
            isDead = true;
            anim.SetBool("Death", true);
            Debug.Log("I AM DYING: " + tag);
        }
    }
}