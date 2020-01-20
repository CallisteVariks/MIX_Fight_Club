using SceneScripts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
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
        public Slider healthSlider;
        public bool isWinner;
        public GameObject winnerText;
        public GameObject rematchButton;

        internal bool isDead;
        internal bool wasFound;
        
        private Animator anim;
        private bool isDamaged;

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
            healthSlider.value = currentHealth;

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

            winnerText.GetComponent<Text>().text = tag + " loses";
            
            rematchButton.SetActive(true);
            winnerText.SetActive(true);

        }
    }
}