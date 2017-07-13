using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RedSnowmin : MonoBehaviour {

	public Text hintText;
	public Transform player;



	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (player.position, transform.position) < 10f) {
			hintText.text = "I could not find the ice but maybe the others did. One them headed to the east";
		} else {
			//hintText.text = "";
		}

	}


}
