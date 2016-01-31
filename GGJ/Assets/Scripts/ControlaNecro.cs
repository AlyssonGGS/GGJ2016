using UnityEngine;
using System.Collections;
//classe usada para controlar as animações do necromance pelo teclado
public class ControlaNecro : MonoBehaviour {

    void Start()
    {
        transform.position = Vector3.left * Camera.main.orthographicSize;
    }
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
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Animator>().Play("Necro_Right");
        }
    }
}
