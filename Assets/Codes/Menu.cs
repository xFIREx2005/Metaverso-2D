using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string nomeDaCena;
    public bool cre;

    private void Update()
    {
        if (cre == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Menu");
            } 
        }
    }
    public void MudarCena()
    {
        SceneManager.LoadScene(nomeDaCena);
    }

    public void SairCena()
    {
        Debug.Log("O jogo saiu");
        Application.Quit();
    }
}
