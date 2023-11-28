using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class vbScript : MonoBehaviour
{
    public VirtualButtonBehaviour vbutton;
    //public Animator astronautAnimator;
    public GameObject cube;
    void Start()
    {
        vbutton.RegisterOnButtonPressed(OnButtonPressed);
        vbutton.RegisterOnButtonReleased(OnButtonReleased);
        //astronautAnimator = GetComponent<Animator>();
        cube.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("ButtonPressed");
        //astronautAnimator.SetBool("IsWaving", true);  // 애니메이션 시작
        cube.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("ButtonReleased");
        //astronautAnimator.SetBool("IsWaving", false);  // 애니메이션 중지
        cube.SetActive(false);
    }

    void Update()
    {
        
    }
}
