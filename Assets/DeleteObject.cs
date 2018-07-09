using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// 通過したオブジェクトを破棄
		if (MyCameraController.unitychan.transform.position.z > this.transform.position.z) {
			Destroy (this.gameObject);
		}
	}
}
