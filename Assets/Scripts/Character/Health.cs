using UnityEngine;
using System.Collections;

// ----------------------------------------------------------//
// Purpose: Health Script
// ----------------------------------------------------------//
public class Health : MonoBehaviour
{
	[SerializeField]
	private bool regenerate = false;
	[SerializeField]	
	private float regenerationInterval = 5.0f;
	private float timeInterval = 0.0f;
	
	[SerializeField]
	private int health = 100;
	[SerializeField]
	private int maxHealth = 100;
	
	void Start()
	{
		this.timeInterval = this.regenerationInterval;
	}
	
	// Called once PER FRAME (30 times per second)
	void Update()
	{
		if(this.regenerate)
		{
			this.timeInterval -= Time.deltaTime;
			
			if(this.timeInterval > 0)
			{
				this.timeInterval = this.regenerationInterval;	
			}
		}
	}
	
	public void SetHealth(int value_health)
	{
		this.health += value_health;
		Helper.Clamp(this.health, 0, this.maxHealth);
	}
}
