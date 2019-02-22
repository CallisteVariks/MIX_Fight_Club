using UnityEngine;
using UnityEngine.UI;

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

    private bool isDead;

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
            return;
        }

        //perform GetHit animation
        anim.SetTrigger("GetHit");
        isDamaged = false;
    }

    public void TakeDamge(int amount)
    {
        isDamaged = true;

        var totalDmg = amount - armor;
        currentHealth -= totalDmg;
        HealthSlider.value = currentHealth;

        if (!isDead && currentHealth <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;
        anim.SetTrigger("Death");
    }
}