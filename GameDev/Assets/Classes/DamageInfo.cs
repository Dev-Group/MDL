using UnityEngine;
using System.Collections;

// ----------------------------------------------------------//
// Purpose: To easily send data about damage between classes
// ----------------------------------------------------------//
public class DamageInfo
{
	private float damage;
	private int damageType;
	
	public DamageInfo(float damage, int damageType)
	{
		this.damage = damage;
		this.damageType = damageType;
	}
	
	public float Damage
	{
		get { return this.damage; }
	}
	
	public int DamageType
	{
		get { return this.damageType; }
	}
}
