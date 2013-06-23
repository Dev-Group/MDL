using UnityEngine;
using System.Collections;

public class ExternalController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1))
			this.GetComponent<PuppetController>().SwapCharacters(SharedDefs.Characters.Demon);
		
		if(Input.GetKeyDown(KeyCode.Alpha2))
			this.GetComponent<PuppetController>().SwapCharacters(SharedDefs.Characters.Laser);
		
		if(Input.GetKeyDown(KeyCode.Alpha3))
			this.GetComponent<PuppetController>().SwapCharacters(SharedDefs.Characters.Mecha);		
	}
}
