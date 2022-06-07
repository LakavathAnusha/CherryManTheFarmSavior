using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
   public void Restart()
    {
        SceneManager.LoadScene(1); 
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
