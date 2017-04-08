using UnityEngine;
using System.Collections;

public class SkalaSpawner : MonoBehaviour
{
    public float ilosc_skal1;
    public float ilosc_skal2;
    public float ilosc_skal3;
    public float ilosc_skal4;
    public GameObject skala1;
    public GameObject skala2;
    public GameObject skala3;
    public GameObject skala4;

    // Use this for initialization
    void Start ()
    {
        for (int i = 0; i < ilosc_skal1; i++)
        {
            GameObject skala1_kontener = (GameObject)Instantiate(skala1);
            skala1_kontener.transform.position = new Vector2(Random.Range(-8, 8), Random.Range(50, 70));
            skala1_kontener.GetComponent<SkalaMove>().predkosc_spadania = 1f * Random.Range(2, 4) + 0.5f;
            skala1_kontener.transform.parent = transform;

        }
        for (int i = 0; i < ilosc_skal2; i++)
        {
            GameObject skala2_kontener = (GameObject)Instantiate(skala2);         
            skala2_kontener.transform.position = new Vector2(Random.Range(-8, 8), Random.Range(50, 70));
            skala2_kontener.GetComponent<SkalaMove>().predkosc_spadania = 1f * Random.Range(4, 6) + 0.5f;
            skala2_kontener.transform.parent = transform;

        }
        for (int i = 0; i <ilosc_skal3; i++)
        {
            GameObject skala3_kontner = (GameObject)Instantiate(skala3);
            skala3_kontner.transform.position = new Vector2(Random.Range(-8, 8), Random.Range(50, 70));
            skala3_kontner.GetComponent<SkalaMove>().predkosc_spadania = 1f * Random.Range(2,4) + 0.5f;
            skala3_kontner.transform.parent = transform;

        }
        for (int i = 0; i < ilosc_skal4; i++)
        {
            GameObject skala4_kontener = (GameObject)Instantiate(skala4);
            skala4_kontener.transform.position = new Vector2(Random.Range(-8, 8), Random.Range(50, 70));
            skala4_kontener.GetComponent<SkalaMove>().predkosc_spadania = 1f * Random.Range(4, 6) + 0.5f;
            skala4_kontener.transform.parent = transform;

        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
