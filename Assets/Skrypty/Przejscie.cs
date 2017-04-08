using UnityEngine;
using System.Collections;

public class Przejscie : MonoBehaviour {

    public Texture2D teksturka;
    public float szybkosc_zanikania = 0.8f;

    private int drawDepth = -1000;
    private float alpha = 1.0f;
    private int fadeDir = -1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        alpha += fadeDir * szybkosc_zanikania * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), teksturka);

    }

    public float BeginFade(int direction)
    {
        fadeDir = direction;
        return (szybkosc_zanikania);
    }

    void OnLevelWasLoaded ()
    {
        BeginFade(-1);
    }
}
