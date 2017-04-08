using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float predkosc_gracza;
    public float predkosc_obortu;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

        Vector3 pozycja = transform.position;

        Quaternion oborot = transform.rotation;

        pozycja.x += Input.GetAxis("Horizontal") * predkosc_gracza * Time.deltaTime;

        oborot.z -=Input.GetAxis("Horizontal")* predkosc_obortu * Time.deltaTime;

        transform.rotation = oborot;

        if (pozycja.x <= -6.2)
        {
            pozycja.x = System.Convert.ToSingle(-6.2);
        }
        else if (pozycja.x >= 6.2)
        {
            pozycja.x = System.Convert.ToSingle(6.2);
        }
        else
            transform.position = pozycja;
    }
}
