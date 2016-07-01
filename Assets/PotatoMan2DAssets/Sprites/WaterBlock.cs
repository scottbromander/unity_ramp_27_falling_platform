using UnityEngine;
using System.Collections;

public class WaterBlock : MonoBehaviour {

	private Animator animationController;


	// Use this for initialization
	void Start () {
		animationController = GetComponent<Animator> ();
	}

	void OnTriggerEnter2D(Collider2D hit){
		if (hit.CompareTag ("Player")) {
			animationController.SetTrigger ("Fall");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
