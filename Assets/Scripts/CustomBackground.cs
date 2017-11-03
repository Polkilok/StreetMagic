using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBackground : MonoBehaviour {

	public GameObject Background;
	public GameObject Player;
	private const float BackgroundDistance = 3f;
	// Use this for initialization
	void Start () {
		//transform.position = Player.transform.position + Player.transform.forward * BackgroundDistance;
		//transform.LookAt(Player.transform.position + Player.transform.forward * (BackgroundDistance + 1f));
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Player.transform.position + Player.transform.forward * BackgroundDistance;
		transform.LookAt(Player.transform.position + Player.transform.forward * (BackgroundDistance + 1f));
	}
}
