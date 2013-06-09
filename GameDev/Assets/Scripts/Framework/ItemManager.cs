using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// ----------------------------------------------------------//
// Purpose: Manages Items
// ----------------------------------------------------------//
public class ItemManager : MonoBehaviour
{
	private int entityCount = 0;
	private List<GameObject> items = new List<GameObject>();
	
	public void RegisterItem(GameObject obj)
	{
		this.items.Add(obj);
		obj.GetComponent<Item>().ID = this.entityCount;
		this.entityCount++;
	}

	public void UnRegisterItem(GameObject obj)
	{
		this.items.Remove(obj);
	}
	
	public void UnRegisterItem(int objNum)
	{
		foreach(GameObject item in this.items)
		{
			if(item.GetComponent<Item>().ID == objNum)
			{
				this.items.Remove(item);
				return;
			}
		}
	}
		
	public static ItemManager Instance()
	{
		if(!GameObject.Find("GlobalGameObject"))
			return null;

		return GameObject.Find("GlobalGameObject").GetComponent<ItemManager>();
	}
}
