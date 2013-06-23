using UnityEngine;
using System.Collections;

// ----------------------------------------------------------//
// Purpose: Controlles puppet swapping
// ----------------------------------------------------------//
public class PuppetController : MonoBehaviour
{
	[SerializeField]
	private SharedDefs.Characters currentCharacter;
	
	void Start()
	{
	}
	
	void Update()
	{
	}
	
	public void SwapCharacters(SharedDefs.Characters character)
	{
		if(this.currentCharacter != character)
		{
			Debug.Log("Swapping!");
			this.currentCharacter = character;
			
			switch(this.currentCharacter)
			{
			case SharedDefs.Characters.Demon :
				break;
				
			case SharedDefs.Characters.Laser :
				break;
				
			case SharedDefs.Characters.Mecha :
				break;
			}
		}
		else
		{
			Debug.Log("Can't swap!");
		}
	}
}
