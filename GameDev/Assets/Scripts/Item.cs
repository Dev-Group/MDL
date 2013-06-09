using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{
	private int entityID;
	
	[SerializeField]
	private SharedDefs.Items item;
	
	void Awake()
	{
		
	}

	void Start()
	{
		if(ItemManager.Instance())
		{
			ItemManager.Instance().RegisterItem(this.gameObject);
		}
	}
	
	void OnDestroy()
	{
		if(ItemManager.Instance())
		{
			ItemManager.Instance().UnRegisterItem(this.gameObject);
		}
	}
	
	void Update()
	{
		
	}
	
	public int ID
	{
		get { return this.entityID; }
		set { this.entityID = value; }
	}
}
