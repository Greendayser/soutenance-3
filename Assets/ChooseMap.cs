using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ChooseMap : MonoBehaviour
{

    private AudioSource Audio;


    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Loadlevel1()
    {
        SceneManager.LoadScene("first_scene_all");
    }

    public void Loadlevel2()
    {
        SceneManager.LoadScene("second_scene_all");
    }
}
