using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

// http://answers.unity3d.com/questions/47443/multiplayer-ids.html

public class PlayerColor : NetworkBehaviour {

	private TextMesh textMesh;

	private void Start() {
		textMesh = GameObject.FindGameObjectWithTag("Text").GetComponent<TextMesh>();

		if (isLocalPlayer) {
			GetComponent<Renderer>().material.color = Color.blue;
		}

		textMesh.text = "Player ID is " + Network.player.ToString();
	}

}
