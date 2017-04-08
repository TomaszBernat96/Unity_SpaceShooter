using UnityEngine;
using System.Collections;

public class StrzalBossa : MonoBehaviour
{
    public Vector3 oddalnie_pocisku = new Vector3(0, 0.2f, 0);
    public GameObject pocisk;
    public float opoznienie;
    float opoznienie_timer = 0;
      
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        opoznienie_timer -= Time.deltaTime;
        if(opoznienie_timer<=0)
        {
            GetComponent<AudioSource>().Play();
            opoznienie_timer = opoznienie;
            Vector3 oddalneie = transform.rotation * oddalnie_pocisku;
            GameObject pocisk_kontener = (GameObject)Instantiate(pocisk, transform.position + oddalneie, transform.rotation);
        }
	}
}
