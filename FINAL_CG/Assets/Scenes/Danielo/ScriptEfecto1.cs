//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ScriptEfecto1 : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}


using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneEffectController : MonoBehaviour
{
    public Button botonEf1;      // Botón para activar el primer efecto
    //public Button botonEf2;      // Botón para activar el segundo efecto
    //public Button botonEf3;      // Botón para activar el tercer efecto
    public Button botonPausa;    // Botón para pausar el efecto
    public Button botonPlay;     // Botón para reanudar el efecto

    private bool isPaused = false;
    private string currentEffectScene = ""; // Variable para almacenar la escena cargada

    void Start()
    {
        // Vincular botones a sus métodos correspondientes
        botonEf1.onClick.AddListener(() => LoadEffectScene("HexagonShield"));
        //botonEf2.onClick.AddListener(() => LoadEffectScene("Escena de Isa"));
        //botonEf3.onClick.AddListener(() => LoadEffectScene("Escena de Matt"));
        botonPausa.onClick.AddListener(PauseEffect);
        botonPlay.onClick.AddListener(ResumeEffect);
    }

    void LoadEffectScene(string sceneName)
    {
        // Si ya hay una escena cargada, primero descargala
        if (!string.IsNullOrEmpty(currentEffectScene))
        {
            UnloadEffectScene(currentEffectScene);
        }

        // Cargar la nueva escena del efecto
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        currentEffectScene = sceneName;  // Actualizar la escena cargada
    }

    void PauseEffect()
    {
        if (!isPaused)
        {
            // Pausar el tiempo en la escena del efecto
            Time.timeScale = 0;
            isPaused = true;
        }
    }

    void ResumeEffect()
    {
        if (isPaused)
        {
            // Reanudar el tiempo en la escena del efecto
            Time.timeScale = 1;
            isPaused = false;
        }
    }

    void UnloadEffectScene(string sceneName)
    {
        // Descargar la escena del efecto
        SceneManager.UnloadSceneAsync(sceneName);
        currentEffectScene = "";  // Restablecer la escena cargada
    }
}


