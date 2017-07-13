using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coward_Snowmin : MonoBehaviour {
	public Text hintText;
	public Transform player;



	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(player.position,transform.position) < 10f)
		{
			hintText.text = "Go look for the never melting ice so we can survive. I think they went west." +
				" I'll just stay here";
		}
		else {
			//hintText.text = "";
		}





	}
}
