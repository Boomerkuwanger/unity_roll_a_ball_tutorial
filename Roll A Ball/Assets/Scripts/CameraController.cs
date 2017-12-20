using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    public float speedMod;

    private Vector3 offset;
    

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate () {
        transform.position = player.transform.position + offset;
        // transform.LookAt(player.transform.position);
        // transform.RotateAround(player.transform.position, new Vector3(0.0f, 1.0f, 0.0f), 20 * Time.deltaTime * speedMod);
    }
}
