using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	
	public float totalHealth;
	public float remainingHealth;
	

	// Use this for initialization
	void Start () {
		
		remainingHealth = totalHealth;
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	
	}
	
	public void Damage(float damage)
	{
			remainingHealth -= damage;
	}
	
	public void Heal(float damage)
	{
		remainingHealth += damage;
	}
	
	public void Kill()
	{
		//do some kind of death animation then go to the game over screen
	}
	
}
