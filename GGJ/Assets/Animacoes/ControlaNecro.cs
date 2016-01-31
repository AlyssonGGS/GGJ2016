using UnityEngine;
using System.Collections;

public class ControlaNecro : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Animator>().Play("Necro_Up");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Animator>().Play("Necro_Left");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Animator>().Play("Necro_Down");
        }
    }
}
