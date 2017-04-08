using UnityEngine;
using System.Collections;
using System.Threading;

public class EnemySpawn : MonoBehaviour
{

    int j = 0,k=0,l=0;
    bool a = true, b=false, c=false;
    EnemySpawn koniec;
    public GameObject przeciwnik,przeciwnik1,przeciwnik2;

    float ilosc_przeciwnikow = 7;
    float opoznienie_fal = 45f;
    float opoznienie_holder = 0;

    // Use this for initialization
    void Start ()
    {
        koniec = GetComponent<EnemySpawn>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
            opoznienie_holder -= Time.deltaTime;

            if (opoznienie_holder <= 0)
            {
                opoznienie_holder = opoznienie_fal;
                for (int i = 0; i < ilosc_przeciwnikow; i++)
                {

                       if (a == true)
                       {
                       
                            GameObject przeciwnik_kontener = (GameObject)Instantiate(przeciwnik);
                            przeciwnik_kontener.transform.position = new Vector2(-6.12f + i * 2f, 13f);
                            k++;
                            if(k==7)
                            {
                                a = false;
                                b = true;
                                continue;
                            }
                       
                       }
                       
                       if(b==true)
                       {    
                             
                       
                             GameObject przeciwnik_kontener = (GameObject)Instantiate(przeciwnik1);
                             przeciwnik_kontener.transform.position = new Vector2(-6.12f + i * 2f, 13f);
                             l++;
                             if (l == 7)
                             {
                                 b = false;
                                 c = true;
                                 continue;
                             }
                       
                       }
                       
                       
                       if (c == true)
                       {
                           GameObject przeciwnik_kontener = (GameObject)Instantiate(przeciwnik2);
                           przeciwnik_kontener.transform.position = new Vector2(-6.12f + i * 2f, 13f);
                       
                       }

                }

                j++;
                if (j == 3)
                {
                    koniec.enabled = false;
                }

            }

    }



    
}
