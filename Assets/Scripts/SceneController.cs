using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    [Header("Pantallas a Encender")]
    public GameObject MenuPause;
    public GameObject ExitButton;
    public GameObject OcultarButton;
    public GameObject ContainerButton;


    public void Continuar()
    {
        SceneManager.LoadScene("Game");
    }

    public void Atras()
    {
        SceneManager.LoadScene("Menu");
    }
    public void HowTo()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void Pause()
    {
       // MenuPause.SetActive(true);
        ContainerButton.SetActive(true);
    }

    public void Ocultar()
    {
        ContainerButton.SetActive(false);
    }

    

}

