using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Buttons : MonoBehaviour
{
   GameManager gm = new GameManager();
   int tur=0;

    public void ButtonOnClick(string isim)
   {
        gm.game.GameCycle(isim);
        //Debug.Log(isim);
        GameObject buton = GameObject.Find(isim);
        buton.GetComponent<Button>().interactable = false;
        tur++;
        gm.game.GameControl();
        Debug.Log(tur);
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
