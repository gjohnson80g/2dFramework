using UnityEngine;
using System.Collections;

public class fallout : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnCollisionEnter(Collision collision)
	{
			if(collision.gameObject.tag == "Player")
			{
				 Application.LoadLevel("Menu");
			}
			else
			{
				Destroy(collision.gameObject);
			}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
