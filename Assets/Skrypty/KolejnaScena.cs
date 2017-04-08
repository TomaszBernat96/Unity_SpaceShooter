using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KolejnaScena : MonoBehaviour
{
    public float czas=130;
    public string nazwa_sceny;
    float predkosc=3;
    bool rusz=true;
    public float predkosc_obrotu;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 5 * predkosc_obrotu * Time.deltaTime);
        if (rusz==true)
        {
            czas -= Time.deltaTime;
            if(czas<=0)
            {
                Vector2 pozycja = transform.position;
                pozycja = new Vector2(pozycja.x, pozycja.y - (predkosc * Time.deltaTime));
                transform.position = pozycja;
                if(pozycja.y<=4.4)
                {
                    rusz = false;         
                }
            }

         }

      
    }

    void OnTriggerEnter2D(Collider2D kolizja)
    {
        if (kolizja.tag == "StatekGracza")
        {
            SceneManager.LoadScene(nazwa_sceny);
          
           
        }
    }
    IEnumerator ZmienPoziom()
    {
        float fadeTime = GameObject.Find("background").GetComponent<Przejscie>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
    }
}
