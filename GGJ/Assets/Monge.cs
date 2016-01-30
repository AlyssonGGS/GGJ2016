using UnityEngine;
using System.Collections;

public class Monge : Personagem {
    #region singleton
    private static Monge instance = new Monge();
    public static Monge getInstance()
    {
        return instance;
    }
    #endregion
    //dicionarizinho
    //Abreviação -> Tecla
    //r -> rightArrow
    //l -> leftArrow
    //d -> downArrow
    //u -> upArrow
    //testa se a tecla digitada é igual à tecla esperada para o ritual;
    public string testaInput(char prox)
    {
        switch (prox)
        {
            case 'u':
                if (Input.GetKeyDown(KeyCode.UpArrow)) { return "certo"; }
                else { return "errado"; }
            case 'd':
                if (Input.GetKeyDown(KeyCode.DownArrow)) { return "certo"; }
                else { return "errado"; }
            case 'r':
                if (Input.GetKeyDown(KeyCode.RightArrow)) { return "certo"; }
                else { return "errado"; }
            case 'l':
                if (Input.GetKeyDown(KeyCode.LeftArrow)) { return "certo"; }
                else { return "errado"; }

            default:
                return "esperando";
        }
    }
}
