using UnityEngine;
using System.Collections;

public class KoniecSceny : MonoBehaviour
{
    public float czas;
    public bool wejscie = true;
    

    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        Koniec();

    }

    void Koniec()
    {
        if (wejscie == true)
        {
            czas -= Time.deltaTime;
            if (czas <= 0)
            {
               
                GetComponent<PlayerShooting>().enabled = false;
                GetComponent<PlayerMovement>().enabled = false;
                GetComponent<RuchGraczaPrzody>().enabled = true;
                wejscie = false;

            }
        }
    }


}
