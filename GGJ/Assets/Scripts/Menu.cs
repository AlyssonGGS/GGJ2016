using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject[] opcoes;
    private int contador;
	void Start ()
    {
        contador = 0;
	}
	
	void Update ()
    {
        alteraOpcao();
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GetComponent<AudioSource>().Play();
            StartCoroutine(troca());
        }
    }
    void alteraOpcao()
    {
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && contador >= 1)
        {
            contador--;
            modificaTextoOpcao(contador + 1);
        }

        else if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && contador < opcoes.Length - 1)
        {
            contador++;
            modificaTextoOpcao(contador - 1);
        }
    }
    void modificaTextoOpcao(int opAnterior)
    {
        opcoes[opAnterior].transform.localScale = new Vector3(1, 1, 1);
        opcoes[contador].transform.localScale = new Vector3(1.1f, 1.1f, 1) * (Screen.width/Screen.height);
    }

    IEnumerator troca()
    {
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        SceneManager.changeScene(opcoes[contador].name);
    }
}
