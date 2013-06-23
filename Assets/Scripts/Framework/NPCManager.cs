using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPCManager : MonoBehaviour
{
	private List<GameObject> npcs = new List<GameObject>();
	
	public void RegisterNPC(GameObject npc)
	{
	}
	
	public void UnRegisterNPC(GameObject npc)
	{
	}
	
	public static NPCManager Instance()
	{
		if(!GameObject.Find("GlobalGameObject"))
			return null;

		return GameObject.Find("GlobalGameObject").GetComponent<NPCManager>();
	}
}
