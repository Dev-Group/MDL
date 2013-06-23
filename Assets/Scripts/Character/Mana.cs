using UnityEngine;
using System.Collections;

// ----------------------------------------------------------//
// Purpose: Mana
// ----------------------------------------------------------//
public class Mana : MonoBehaviour
{
	[SerializeField]
	private bool regenerate = false;
	[SerializeField]	
	private float regenerationInterval = 5.0f;
	private float timeInterval = 0.0f;

	[SerializeField]
	private int mana = 100;
	[SerializeField]
	private int maxMana = 100;
	
	void Start()
	{
	
	}
	
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
	
	public void SetMana(int value_mana)
	{
		this.mana += value_mana;
		Helper.Clamp(this.mana, 0, this.maxMana);
	}
}
