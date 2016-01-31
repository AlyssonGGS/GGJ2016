using UnityEngine;
using System.Collections;

public class SceneManager
{
    public static void changeScene(string name)
    {
        if(name != "Sair")
        {
            Application.LoadLevel(name);
        }
        else { Application.Quit(); }
    }
}
