using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour
{
    public float predkosc_gwiazdy;


	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

        Vector2 pozycja_gwiazdy = transform.position;

        pozycja_gwiazdy = new Vector2(pozycja_gwiazdy.x, (pozycja_gwiazdy.y -(predkosc_gwiazdy * Time.deltaTime)));
        transform.position = pozycja_gwiazdy;

        if (transform.position.y < -8)
        {
            transform.position = new Vector2(Random.Range(-8, 8), 7);
        }

    }
}
