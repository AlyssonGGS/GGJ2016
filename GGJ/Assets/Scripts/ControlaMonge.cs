using UnityEngine;
using System.Collections;

public class ControlaMonge : MonoBehaviour {

    public AudioClip[] audios;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Animator>().Play("Monge_Up");
            tocar(0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<Animator>().Play("Monge_Left");
            tocar(1);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GetComponent<Animator>().Play("Monge_Down");
            tocar(2);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<Animator>().Play("Monge_Right");
            tocar(3);
        }
    }

    private void tocar(int som)
    {
        GetComponent<AudioSource>().clip = audios[som];
        GetComponent<AudioSource>().Play();
    }
}
