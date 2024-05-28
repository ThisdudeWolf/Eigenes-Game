using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    
    public float health;
    public float maxHealth;
    public float minHealth;
    public Image healthBar;
    [SerializeField] GameObject SlimeDamage;
    SlimeEnemyAttack slimeEnemyAttack;

    private void Awake()
    {
        slimeEnemyAttack = SlimeDamage.GetComponent<SlimeEnemyAttack>();
    }
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        healthBar.fillAmount = health / maxHealth;
    }
    public void TakeDamage()
    {
        health = health-slimeEnemyAttack.Damage;
        health = Mathf.Clamp(health, minHealth, maxHealth);
        Debug.Log("Damage taken");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TakeDamage();
    }
}
