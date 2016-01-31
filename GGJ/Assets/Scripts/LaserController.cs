using UnityEngine;
using System.Collections;

public class LaserController : MonoBehaviour
{
    void Start()
    {
    }    

    public void chamarRaio(Vector3 pos)
    {
        transform.position = pos;
        GetComponent<Animator>().Play("Beam");
    }

    public void realocar()
    {
        transform.position = Vector3.one * 100;
    }

    public void destruir()
    {
        GameObject.Find("Começar").GetComponent<ControleJogo>().inimigoDestruido(GameObject.Find("enemy"));
    }
}
