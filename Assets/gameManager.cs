using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

    public static gameManager instance = null;

    public GameObject WinText;
    public GameObject WinBlackBG;
    public float resetDelay;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
    }

    public void Win()
    {
        WinText.SetActive(true);
        WinBlackBG.SetActive(true);
        Time.timeScale = 0.5f;
        Invoke("Reset", resetDelay);
    }

    private void Reset()
    {
        Time.timeScale = 1f;
        Application.LoadLevel (Application.loadedLevel);
    }
}
