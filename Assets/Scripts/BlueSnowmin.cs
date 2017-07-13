using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BlueSnowmin : MonoBehaviour {
	public Text hintText;
	public Transform player;



	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (player.position, transform.position) < 10f) {
			hintText.text = "Sorry I just couldn't find the ice but I saw our last friend go north west hopefully he found it";
		} else {
			//hintText.text = "";
		}

	}


}

