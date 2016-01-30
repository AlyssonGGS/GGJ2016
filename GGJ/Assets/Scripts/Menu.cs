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
        modificaTextoOpcao(0, 30);
	}
	
	void Update ()
    {
        alteraOpcao();
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
        opcoes[opAnterior].GetComponent<Text>().fontSize = 20;
        opcoes[contador].GetComponent<Text>().fontSize = 30;
    }
    void modificaTextoOpcao(int cont, int size)
    {
        opcoes[cont].GetComponent<Text>().fontSize = size;
    }
}
