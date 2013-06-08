using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// ----------------------------------------------------------//
// Purpose: Manages Puppets
// ----------------------------------------------------------//
public class PuppetManager : MonoBehaviour
{
	private Dictionary<SharedDefs.Characters, GameObject> characters = new Dictionary<SharedDefs.Characters, GameObject>();
	private GameObject currentCharacter;

	public void AddCharacter(SharedDefs.Characters name, GameObject obj)
	{
		if(this.characters.ContainsKey(name))
			return;
		
		this.characters.Add(name, obj);
	}
	
	public void RemoveCharacter(SharedDefs.Characters name)
	{
		if(!this.characters.ContainsKey(name))
			return;
		
		this.characters.Remove(name);
	}
	
	public void PushCharacter(SharedDefs.Characters name)
	{
		if(!this.characters.ContainsKey(name))
			return;
		
		if(this.currentCharacter != null)
		{
			// Pull the current character
			this.currentCharacter.GetComponent<Puppet>().Pull();
		}
		
		// Push the new character & make it the current
		this.currentCharacter = this.characters[name];
		this.currentCharacter.GetComponent<Puppet>().Push();
	}
	
	public GameObject CurrentCharacter
	{
		get { return this.currentCharacter; }	
	}
	
	public static PuppetManager Instance()
	{
		if(!GameObject.Find("GlobalGameObject"))
			return null;

		return GameObject.Find("GlobalGameObject").GetComponent<PuppetManager>();
	}
}
