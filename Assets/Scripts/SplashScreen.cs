using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

	[SerializeField] float loadDelay = 3;

	void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}
	// Use this for initialization
	void Start () {
		
		Invoke("LoadLevel1", loadDelay);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LoadLevel1(){
		SceneManager.LoadScene("Level1");
	}
}
