using UnityEngine;
using System.Collections;

// ----------------------------------------------------------//
// Purpose: Used my the search to determine what's an NPC
// ----------------------------------------------------------//
public class NPC : MonoBehaviour
{
	[SerializeField]
	private SharedDefs.NPCs npc;
	
	void Awake()
	{
		
	}

	void Start()
	{
		if(NPCManager.Instance())
		{
			NPCManager.Instance().AddCharacter(this.npc, this.gameObject);
		}
	}
	
	void OnDestroy()
	{
		if(NPCManager.Instance())
		{
			NPCManager.Instance().RemoveCharacter(this.npc);
		}
	}
}
