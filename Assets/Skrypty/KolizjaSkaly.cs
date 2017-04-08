using UnityEngine;
using System.Collections;

public class KolizjaSkaly : MonoBehaviour
{
    public float zycie;
    public GameObject ekspolozja;
    GameObject referencja_do_wyniku;

    // Use this for initialization
    void Start ()
    {
        referencja_do_wyniku = GameObject.FindGameObjectWithTag("punkt");
    }
    void OnTriggerEnter2D(Collider2D kolizja)
    {
        if (kolizja.tag == "PociskGracza")
        {
            zycie--; 
            if(zycie<=0)
            {
            referencja_do_wyniku.GetComponent<AktualizacjaWyniku>().Punkt += 100;

            }         
        }
        if (kolizja.tag == "StatekGracza")
        {
            zycie -= 3;
        }
        if(kolizja.tag == "Tarcza")
        {
            zycie -= zycie;
        }
    }

        // Update is called once per frame
        void Update ()
    {

	  if(zycie <=0)
        {
            //referencja_do_wyniku.GetComponent<AktualizacjaWyniku>().Punkt += 100;
            Zniszcz();
        }

	}
    void Zniszcz()
    {
        Animacja();
        Destroy(gameObject);
    }
    void Animacja()
    {
        GameObject wybuch = (GameObject)Instantiate(ekspolozja);
        wybuch.transform.position = transform.position;
    }
}
