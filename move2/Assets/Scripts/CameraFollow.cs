using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class CameraFollow : NetworkBehaviour {
	
	void Update () {
		if (!isLocalPlayer) return;
		
		Camera.main.transform.LookAt(transform.position);
	}

}
