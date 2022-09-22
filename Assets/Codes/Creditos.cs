using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
    private void Update()
    {
        if(GameObject.FindWithTag("Enemy") == null)
        {
            MudarCena();
        }
    }
    public void MudarCena()
    {
        SceneManager.LoadScene("Creditos");
    }
}
