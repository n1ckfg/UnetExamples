using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

// http://answers.unity3d.com/questions/47443/multiplayer-ids.html

public class PlayerColor : NetworkBehaviour {

	private void Start() {
		if (isLocalPlayer) {
			GetComponent<Renderer>().material.color = Color.blue;
		}

		Debug.Log("Player ID is " + Network.player.ToString());
	}

}
