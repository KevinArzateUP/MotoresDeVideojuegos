using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public Text[] textos_Puntuaciones;
    public List<int> puntuacionesTotales;

    public int scoreTotal;
    public string pathArchivo;
    private void Start()
    {

        pathArchivo = Path.Combine(Application.persistentDataPath, "scores.txt");

        puntuacionesTotales = new List<int>();
        if (File.Exists(pathArchivo))
        {
            string textoLeido = File.ReadAllText(pathArchivo);
            string[] arregloLeido = textoLeido.Split(',');
            for (int i = 0; i < 5; i++)
            {
                puntuacionesTotales.Add(int.Parse(arregloLeido[i]));
            }
            puntuacionesTotales.Sort();
        }
        else
        {
            for (int i = 0; i < 5; i++)
                puntuacionesTotales.Add(0);

            GuardarListaEnArchivo();
        }

    }


    [ContextMenu("Ejecutar lista de textos")]
    public void LlenarListaDeTextos()
    {
        puntuacionesTotales.Add(scoreTotal);
        puntuacionesTotales.Sort();
        if (puntuacionesTotales.Count>5)
        {
            puntuacionesTotales.RemoveAt(0);
        }

        GuardarListaEnArchivo();


        for (int i = 0; i < textos_Puntuaciones.Length; i++)
            textos_Puntuaciones[i].text = puntuacionesTotales[i].ToString();
    }

    public void GuardarListaEnArchivo()
    {
        string textoArchivo = "";

        for (int i = 0; i < 5; i++)
        {
            textoArchivo = textoArchivo + puntuacionesTotales[i].ToString() + ",";
        }

        Debug.Log(textoArchivo);

        File.WriteAllText(pathArchivo, textoArchivo);
        Debug.Log(pathArchivo);
    }
}
