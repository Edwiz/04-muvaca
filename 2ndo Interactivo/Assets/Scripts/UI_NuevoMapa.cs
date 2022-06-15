using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_NuevoMapa : MonoBehaviour
{
    public Slider mainSlider;
    public GameObject SliderGO;
    public GameObject cameraGO;
    public GameObject pestana1GO;
    public GameObject pestana2GO;
    public GameObject pestana3GO;

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;

    private Animator cameraAnim;
    private Animator sliderAnim;

    private Animator panel1Anim;
    private Animator panel2Anim;
    private Animator panel3Anim;

    private Animator pestana1Anim;
    private Animator pestana2Anim;
    private Animator pestana3Anim;

    // Start is called before the first frame update
    void Start()
    {
        cameraAnim = cameraGO.GetComponent<Animator>();
        sliderAnim = SliderGO.GetComponent<Animator>();
        panel1Anim = panel1.GetComponent<Animator>();
        panel2Anim = panel2.GetComponent<Animator>();
        panel3Anim = panel3.GetComponent<Animator>();
        pestana1Anim = pestana1GO.GetComponent<Animator>();
        pestana2Anim = pestana2GO.GetComponent<Animator>();
        pestana3Anim = pestana3GO.GetComponent<Animator>();
    }

    public void CheckSliderValue1()
    {
        if(mainSlider.value == 1)
        {
            cameraAnim.SetBool("toPointA", true);
        }
        else
        {
            cameraAnim.SetBool("toPointA", false);
        }

    }

    public void CheckSliderValue2()
    {
        if (mainSlider.value == 2)
        {
            cameraAnim.SetBool("toPointB", true);
        }
        else
        {
            cameraAnim.SetBool("toPointB", false);
        }

    }

    public void CheckSliderValue3()
    {
        if (mainSlider.value == 3)
        {
            cameraAnim.SetBool("toPointC", true);
        }
        else
        {
            cameraAnim.SetBool("toPointC", false);
        }
    }


    public void EnterPanel1()
    {
        sliderAnim.SetBool("sliderOff", true);
        panel1.SetActive(true);
    }

    public void EnterPanel2()
    {
        sliderAnim.SetBool("sliderOff", true);
        panel2.SetActive(true);
    }

    public void EnterPanel3()
    {
        sliderAnim.SetBool("sliderOff", true);
        panel3.SetActive(true);
    }


    public void ReturntoMap1()
    {
        sliderAnim.SetBool("sliderOff", false);
        panel1Anim.SetBool("fadeOut", true);
        cameraAnim.SetBool("toPointA", false);
        //pestana1Anim.SetBool("pestanaOn", false);
        StartCoroutine(SimpleDelayOFF(panel1));
    }


    public void ReturntoMap2()
    {
        sliderAnim.SetBool("sliderOff", false);
        panel2Anim.SetBool("fadeOut", true);
        cameraAnim.SetBool("toPointB", false);
        //pestana2Anim.SetBool("pestanaOn", false);
        StartCoroutine(SimpleDelayOFF(panel2));
    }

    public void ReturntoMap3()
    {
        sliderAnim.SetBool("sliderOff", false);
        panel3Anim.SetBool("fadeOut", true);
        cameraAnim.SetBool("toPointC", false);
        //pestana3Anim.SetBool("pestanaOn", false);
        StartCoroutine(SimpleDelayOFF(panel3));
    }

    public void Pestana1()
    {
        pestana1Anim.SetBool("pestanaOn", true);
    }

    public void Pestana2()
    {
        pestana2Anim.SetBool("pestanaOn", true);
    }

    public void Pestana3()
    {
        pestana3Anim.SetBool("pestanaOn", true);
    }
    
    //Invoked when a submit button is clicked.
    public void SubmitSliderSetting()
    {
        //Displays the value of the slider in the console.
        Debug.Log(mainSlider.value);
    }


    IEnumerator SimpleDelay(GameObject theObject)
    {
        yield return new WaitForSeconds(2.5f);
        {
            theObject.SetActive(true);
        }
    }

    IEnumerator SimpleDelayOFF(GameObject theObject)
    {
        yield return new WaitForSeconds(5f);
        {
            theObject.SetActive(false);
        }
    }
}
