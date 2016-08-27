using UnityEngine;
using System.Collections;

public class Translation : MonoBehaviour {

	public float translate_speed_y; 

	// Use this for initialization
	void Start () {
		translate_speed_y = Random.value;
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(new Vector3(0,0,0), new Vector3(0,1,0), translate_speed_y);
	}
}
