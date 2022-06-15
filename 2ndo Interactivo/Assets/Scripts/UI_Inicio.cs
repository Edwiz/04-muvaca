using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Inicio : MonoBehaviour
{
    public GameObject panelIntroEspanol;
    public GameObject panelIntroIngles;
    public GameObject fadeOutPanel;

    // Start is called before the first frame update
    void Start()
    {
        panelIntroEspanol.SetActive(false);
        panelIntroIngles.SetActive(false);
        fadeOutPanel.SetActive(false);
    }

    public void BotonEspanol()
    {
        SceneManager.LoadScene(1);
    }

    public void BotonIngles()
    {
        SceneManager.LoadScene(1);
    }

    public void BotonContinuar()
    {
        fadeOutPanel.SetActive(true);
        StartCoroutine(SimpleDelay(1));
    }

    public void BotonNext()
    {
        fadeOutPanel.SetActive(true);
        StartCoroutine(SimpleDelay(2));
    }

    public void BotonHome()
    {
        fadeOutPanel.SetActive(true);
        StartCoroutine(SimpleDelay(0));
    }

    IEnumerator SimpleDelay(int sceneIndex)
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(sceneIndex);

    }
}
