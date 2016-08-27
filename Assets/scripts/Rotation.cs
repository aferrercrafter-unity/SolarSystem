using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

    public float rotate_speed_y = 0.5f;
    public float rotate_speed_x = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(rotate_speed_x,rotate_speed_y,0);        
	}
}
