using UnityEngine;
using UnityEngine.UI;

namespace Monsters.TerrorBringer
{
    public class TerrorBringerAtk : MonoBehaviour
    {
        public Slider ManaSlider;
        public int currentMana;

        private DragonClass terrorBringer; //The Dragon Attacking
        private Animator anim;
        public bool Loaded { get; set; }

        public Transform dark_dragon;


        private void Awake()
        {
            terrorBringer = GetComponent<DragonClass>();
            Debug.Log(tag);

            anim = GetComponent<Animator>();
        }


        // Start is called before the first frame update
        void Start()
        {
            currentMana = terrorBringer.mana;
        }

        // Update is called once per frame
        void Update()
        {
            if (terrorBringer.currentHealth > 0 && !terrorBringer.isWinner)
            {
                transform.LookAt(dark_dragon);
                if (Vector3.Distance(dark_dragon.transform.position, this.transform.position) < 0.175)
                {
                    anim.SetTrigger("Attack");
                }

            }
            else if (terrorBringer.isWinner)
            {
                anim.Play("idle");
            }
        }
    }
}