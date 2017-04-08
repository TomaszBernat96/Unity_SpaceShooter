using UnityEngine;
using System.Collections;

public class DamageOnColission : MonoBehaviour {
    
    public int health = 1;
    public float niedotyklanosWartosc = 0;
    float niedotykalnoscTimer = 0;
    int correctLayer;

    void Start()
    {
        correctLayer = gameObject.layer;
    }
    void OnTriggerEnter2D(Collider2D kolizja)
    {        
       
            health--;
            niedotykalnoscTimer = niedotyklanosWartosc;
            gameObject.layer = 10;
            
            
    }
    void Update()
    {
        niedotykalnoscTimer -= Time.deltaTime;
        if(niedotykalnoscTimer<=0)
        {
            gameObject.layer = correctLayer;
        }

        if (health <= 0)
            Die();
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
