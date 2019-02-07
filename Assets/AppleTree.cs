using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {

    [Header("Set In Inspector")]

    public GameObject applePrefab;

    public float speed = 1f;

    public float leftAndRightEdge = 20f;

    public float chanceToChangeDirections = 0.1f;

    public float secondsBetweenAppleDrops = 1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
	}
}
