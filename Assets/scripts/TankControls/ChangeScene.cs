﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour {

    public void ChangeToscene(string Changetank)
    {
        SceneManager.LoadScene(Changetank);
    }



}