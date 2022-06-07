using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject detailsPanel;
    public InputField inputField;
    public Text inpuText;
    public string nameOfPlayer;
    // Start is called before the first frame update
    public void Start()
    {
       // nameOfPlayer=;
        Debug.Log(nameOfPlayer);
    }
    public void Pause()
    {
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        Time.timeScale = 1f;
    }
    public void BackToHame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void OkButton()
    {
        detailsPanel.SetActive(false);
    }
}
