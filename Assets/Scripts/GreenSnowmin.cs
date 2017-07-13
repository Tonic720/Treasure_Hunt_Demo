using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GreenSnowmin : MonoBehaviour {

	public Text hintText;
	public Transform player;



	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (player.position, transform.position) < 10f) {
			hintText.text = "I was so close but sadly i melted too much I won't be able to go any further. It just up head keep going north";
		} else {
			//hintText.text = "";
		}

	}


}
