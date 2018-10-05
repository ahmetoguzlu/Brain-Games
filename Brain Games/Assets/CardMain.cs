using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMain : MonoBehaviour {


	// Use this for initialization
	void Start () {
		changeMaterialWithLoc("Number/DummyNum");
	}

	// Update is called once per frame
	void Update () {
	}

	// Other Functions

	void changeMaterialWithLoc(string local_address){
		GetComponent<Renderer>().material = Resources.Load(local_address, typeof(Material)) as Material;
	}
}
