using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject instructionPanel1;
    public GameObject instructionPanel2;
    public GameObject instructionPanel3;
    //public Button start;
    void Start()
    {
      // start.onClick.AddListener(Instruction1);
    }

    public void Instruction1()
    {
        instructionPanel1.SetActive(true);
        instructionPanel2.SetActive(false);
    }
    public void Instruction2()
    {
        instructionPanel1.SetActive(false);
        instructionPanel2.SetActive(true);
        instructionPanel3.SetActive(false);
    }
    public void Instruction3()
    {
        instructionPanel2.SetActive(false);
        instructionPanel3.SetActive(true);
    }
    public void LetsPlay()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
