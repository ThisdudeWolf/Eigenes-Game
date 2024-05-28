using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackArea : MonoBehaviour
{
    private int damage = 3;
    [SerializeField] GameObject EnemyHealth;
    Enemy enemy;


    private void Awake()
    {
        enemy = EnemyHealth.GetComponent<Enemy>();
    }
    

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<Enemy>() != null)
        {
            enemy.Health = enemy.Health - damage;
            Debug.Log("Damage done");
        }
    }
}
