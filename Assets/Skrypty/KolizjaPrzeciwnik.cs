using UnityEngine;
using System.Collections;

public class KolizjaPrzeciwnik : MonoBehaviour
{
    public int zycie;
    GameObject referencja_do_wyniku;
    public GameObject ekspolozja;
    // Use this for initialization
    void Start ()
    {
        referencja_do_wyniku = GameObject.FindGameObjectWithTag("punkt");
	}
	
	// Update is called once per frame
	void Update ()
    {
	
        if(zycie<=0)
        {
            Zniszcz();
        }

	}
    void OnTriggerEnter2D(Collider2D kolizja)
    {
        if (kolizja.tag == "PociskGracza")
        {
            Animacja();
            zycie--;
        }
        if(kolizja.tag == "Tarcza")
        {
            Animacja();
            zycie -= zycie;
        }
    }
    void Zniszcz()
    {
        referencja_do_wyniku.GetComponent<AktualizacjaWyniku>().Punkt+=100;
        Destroy(gameObject);
    }
    void Animacja()
    {
        GameObject wybuch = (GameObject)Instantiate(ekspolozja);
        wybuch.transform.position = transform.position;
    }
}
