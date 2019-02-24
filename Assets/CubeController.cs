using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {



    private Rigidbody rgb;

    // Use this for initialization
    void Start () {
        this.rgb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider otherObj)
    {
        if (otherObj.gameObject.tag == "TrafficConeTag" || otherObj.gameObject.tag == "CarTag" || otherObj.gameObject.tag == "CoinTag")
        {
            Destroy(otherObj.gameObject);
        }
    }
}
