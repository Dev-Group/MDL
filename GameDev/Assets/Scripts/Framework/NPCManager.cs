using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPCManager : MonoBehaviour
{
	private Dictionary<SharedDefs.NPCs, GameObject> npcs = new Dictionary<SharedDefs.NPCs, GameObject>();

	public void AddCharacter(SharedDefs.NPCs name, GameObject obj)
	{
		if(this.npcs.ContainsKey(name))
			return;
		
		this.npcs.Add(name, obj);
	}
	
	public void RemoveCharacter(SharedDefs.NPCs name)
	{
		if(!this.npcs.ContainsKey(name))
			return;
		
		this.npcs.Remove(name);
	}
	
	public static NPCManager Instance()
	{
		if(!GameObject.Find("GlobalGameObject"))
			return null;

		return GameObject.Find("GlobalGameObject").GetComponent<NPCManager>();
	}
}
