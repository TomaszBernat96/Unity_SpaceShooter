using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour
{
    public float predkosc_pocisku_przcwinika;


	// Use this for initialization
	void Start ()
    {
        //GameObject miejsce_przecwnika;
       
	}
	
	// Update is called once per frame
	void Update ()
    {

        Vector2 pozycja_pocisku = transform.position;
        pozycja_pocisku = new Vector2(pozycja_pocisku.x, (pozycja_pocisku.y - (predkosc_pocisku_przcwinika * Time.deltaTime)));
        transform.position = pozycja_pocisku;

	}
}
