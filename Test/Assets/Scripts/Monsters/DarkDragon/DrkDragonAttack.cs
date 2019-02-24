using UnityEngine;
using UnityEngine.UI;

namespace Monsters.DarkDragon
{
    public class DrkDragonAttack : MonoBehaviour
    {
        public Slider ManaSlider;
        public int currentMana;

        private DragonClass darkDragon; //The Dragon Attacking
        private Animator anim;
        public Transform terror_dragon;

        private void Awake()
        {
            darkDragon = GetComponent<DragonClass>();
            anim = GetComponent<Animator>();
        }

        private void Start()
        {
            currentMana = darkDragon.mana;
        }

        private void Update()
        {
            Debug.Log(darkDragon.isDead);
            Debug.Log(darkDragon.isWinner);
            if (darkDragon.currentHealth > 0 && !darkDragon.isWinner)
            {
                transform.LookAt(terror_dragon);
                if (Vector3.Distance(terror_dragon.transform.position, this.transform.position) < 0.175)
                {
                    anim.SetTrigger("Attack");
                }
            }
            else if (darkDragon.isWinner)
            {
                anim.Play("idle");
            }
        }

    
    }
}