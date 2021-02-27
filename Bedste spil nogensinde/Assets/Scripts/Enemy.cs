using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //  public bool hit = false;
    public int hp = 10;
    public LayerMask wherePlayerIs;
    public Transform attackPos1;
    public float attackrange2;
    public int damage = 1;
    private float timeBfAttack; //time before you can attack
    public float startTimeBfAttack;
    public GameObject Coin;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DoDamage();
        Collider[] circle = Physics.OverlapSphere(transform.position, 1);

    }

    public void TakeDamage(int damage)
    {
        hp = hp - damage;
        Debug.Log("damage taken");

        if (hp <= 0)
        {
            //coin kode skal rykkes over i noget andet på et tidspunkt
            //random virker kun 1 gang
           int randomNumber = Random.Range(0, 4);
            for (int i = 0; i <= randomNumber; i++)
            {
                // var randomPos = (Vector2)Random.insideUnitCircle * 2;
                //randomPos += transform.position;
                //Instantiate(Coin, randomPos, transform.rotation);
                var trajectory = UnityEngine.Random.insideUnitCircle * 200f;
                {
                    GameObject coin = Instantiate(Coin);
                    coin.transform.position = transform.position;

                    //må være en smartere måde at gøre det på
                    int randomNumber_up = Random.Range(-3, 3);
                    int randomNumber_right = Random.Range(-3, 3);

                    Rigidbody coinComponet = coin.GetComponent<Rigidbody>();

                    // de her skal ændres til 3d
                    coinComponet.AddForce(transform.up * randomNumber_up, ForceMode.Impulse);
                    coinComponet.AddForce(transform.right * randomNumber_right, ForceMode.Impulse);
                    // lidt skrald

                    Invoke("DoSomething", 1);
                }
           
                


                Object.Destroy(gameObject);
                Debug.Log("død");
            }

        }
    }

        void DoDamage()
        {

            if (timeBfAttack <= 0)
            {
                Collider[] playerToDamage = Physics.OverlapSphere(attackPos1.position, attackrange2, wherePlayerIs);
                for (int i = 0; i < playerToDamage.Length; i++)
                {
                    playerToDamage[i].GetComponent<Combat>().Health(damage);

                    timeBfAttack = startTimeBfAttack;
                    print("av");

                }
            }



            else
            {
                timeBfAttack -= Time.deltaTime;
            }

        }

        void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
           Gizmos.DrawWireSphere(attackPos1.position, attackrange2);
        }
    }
