using UnityEngine;
using System.Collections;

public class UprodageMove : MonoBehaviour
{
    public float predkosc_spadania;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 pozycja_ulepszenia = transform.position;

        pozycja_ulepszenia = new Vector2(pozycja_ulepszenia.x, (pozycja_ulepszenia.y - (predkosc_spadania * Time.deltaTime)));

        transform.position = pozycja_ulepszenia;

        if (transform.position.y < -8)
        {
            transform.position = new Vector2(Random.Range(-8, 8), 30);
        }
    }
}
