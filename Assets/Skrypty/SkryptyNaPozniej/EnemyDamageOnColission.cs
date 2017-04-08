using UnityEngine;
using System.Collections;

public class EnemyDamageOnColission : MonoBehaviour
{
    public int health;

    // Use this for initialization
    void Start ()
    {
      

    }
    void OnTriggerEnter2D()
    {
        health--; 
    }
    // Update is called once per frame
    void Update ()
    {
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
