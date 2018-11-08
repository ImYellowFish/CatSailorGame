using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_wave : MonoBehaviour {
    public float moveSpeed;
    public float moveDist;
    private float originalX;

	// Use this for initialization
	void Start () {
        originalX = transform.position.x;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        float currentX = transform.position.x;
        if(Mathf.Abs(currentX - originalX) >= moveDist)
        {
            var pos = transform.position;
            pos.x = originalX;
            transform.position = pos;
        }
	}
}
