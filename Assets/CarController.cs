using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

    float _velocity = 10.0f;
    float _angularVelocity = 100.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float aZ = Input.GetAxis("Vertical") * Time.deltaTime * _velocity;

        float _rotFactor = Input.GetAxis("Vertical");
        float aR = Input.GetAxis("Horizontal") * Time.deltaTime * _angularVelocity * _rotFactor;
        
        transform.Translate(0.0f, 0.0f, aZ);
        transform.Rotate(0.0f, aR, 0.0f);
	}
}
