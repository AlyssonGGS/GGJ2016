using UnityEngine;
using System.Collections;
//classe usada para controlar as animações do necromance pelo teclado
public class ControlaNecro : MonoBehaviour {
    public AudioClip[] audios;
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Animator>().Play("Necro_Up");
            tocar(0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Animator>().Play("Necro_Left");
            tocar(1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Animator>().Play("Necro_Down");
            tocar(2);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Animator>().Play("Necro_Right");
            tocar(3);
        }
    }

    private void tocar(int som)
    {
        GetComponent<AudioSource>().clip = audios[som];
        GetComponent<AudioSource>().Play();
    }
}
