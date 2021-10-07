using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject objetoPausa;
    public Transform posicionCamera;
    public float distanciaALaCamara = 5f;

    public float tiempoApp = 5f;

    private void Start()
    {
        objetoPausa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PonerPausa();
        }

        if (tiempoApp <= 0)
        {
            SceneManager.LoadScene(0);
        }
        else
            tiempoApp -= Time.deltaTime;
    }

    public void PonerPausa()
    {
        objetoPausa.transform.position = posicionCamera.position + (posicionCamera.forward * distanciaALaCamara);
        objetoPausa.transform.LookAt(posicionCamera);
        objetoPausa.SetActive(true);
    }


}
