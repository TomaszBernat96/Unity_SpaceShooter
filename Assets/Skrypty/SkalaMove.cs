using UnityEngine;
using System.Collections;

public class SkalaMove : MonoBehaviour
{
    public float predkosc_spadania=1;
    public float predkosc_obortu;
    int licznik=0;
    public int fala;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        
        Vector2 pozycja_skaly = transform.position;
        transform.Rotate(0, 0, 15 * predkosc_obortu * Time.deltaTime);

        pozycja_skaly = new Vector2(pozycja_skaly.x, (pozycja_skaly.y - (predkosc_spadania * Time.deltaTime)));

        transform.position = pozycja_skaly;

        if (transform.position.y < -8)
        {
            transform.position = new Vector2(Random.Range(-8, 8), Random.Range(45, 50));
            licznik++;
            if(licznik==fala)
            {
                Destroy(gameObject);
            }
        }
    }
}
