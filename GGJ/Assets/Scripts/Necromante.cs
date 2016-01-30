using UnityEngine;
using System.Collections;

public class Necromante : Personagem{
    #region singleton
    private static Necromante instance = new Necromante();
    public static Necromante getInstance()
    {
        return instance;
    }
    #endregion
    //dicionarizinho
    //Abreviação -> Tecla
    //w -> W
    //s -> S
    //a -> A
    //x -> D(pra nao confundir com o D das teclas direcionais(down))
    public string testaInput(char prox)
    {
        switch (prox)
        {
            case 'w':
                if (Input.GetKeyDown(KeyCode.W)) { return "certo"; }
                else { return "errado"; }
            case 's':
                if (Input.GetKeyDown(KeyCode.S)) { return "certo"; }
                else { return "errado"; }
            case 'x':
                if (Input.GetKeyDown(KeyCode.D)) { return "certo"; }
                else { return "errado"; }
            case 'a':
                if (Input.GetKeyDown(KeyCode.A)) { return "certo"; }
                else { return "errado"; }

            default:
                return "esperando";
        }
    }
}
