using UnityEngine;
using System.Collections;

// ----------------------------------------------------------//
// Purpose: Used by the managers to determine what's a puppet
// ----------------------------------------------------------//
public class Puppet : MonoBehaviour
{
	[SerializeField]
	private SharedDefs.Characters character;
	
	void Awake()
	{
		
	}

	void Start()
	{
		if(PuppetManager.Instance())
		{
			PuppetManager.Instance().AddCharacter(this.character, this.gameObject);
		}
	}
	
	void OnDestroy()
	{
		if(PuppetManager.Instance())
		{
			PuppetManager.Instance().RemoveCharacter(this.character);
		}
	}
	
	public void Push()
	{
		
	}
	
	public void Pull()
	{
		
	}
}
