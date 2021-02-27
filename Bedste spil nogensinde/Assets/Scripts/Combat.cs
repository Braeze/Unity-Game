using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    bool hit;
    static public int health;
    static public int baseHealth = 10;
    GameObject attack;
    private float timeBfAttack; //time before you can attack
    public float startTimeBfAttack;

    public LayerMask whereEnemyIs;
    public Transform attackPos;
    public float attackrange;
    public int damage;
    public Healthbar healthBar;
    public LayerMask whereinteractableIs;


    void Start()
    {
        health = baseHealth;
        healthBar.SetMaxHealth(baseHealth);

    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        Interact();
    }

    void Attack()
    {
        if (timeBfAttack <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Collider[] enemyToDamage = Physics.OverlapSphere(attackPos.position, attackrange, whereEnemyIs);
                for (int i = 0; i < enemyToDamage.Length; i++)
                {
                    enemyToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                }
                timeBfAttack = startTimeBfAttack;
            }
        }
        else
        {
            timeBfAttack -= Time.deltaTime;
        }
    }
    void Interact()
    {
        Collider[] interactable = Physics.OverlapSphere(attackPos.position, attackrange, whereinteractableIs);

        if (Input.GetKeyDown("e"))
        {
            for (int i = 0; i < interactable.Length; i++)
            {
                var interactableObject = interactable[i].GetComponent<IInteractable>();
                interactableObject.Interact();

            }
        }
    }
    public void Health(int damage)
    {
        health = health - damage;

        healthBar.SetHealth(health); 
        if (health <= 0)
        {
            Destroy(gameObject);

        }

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackrange);
    }
}