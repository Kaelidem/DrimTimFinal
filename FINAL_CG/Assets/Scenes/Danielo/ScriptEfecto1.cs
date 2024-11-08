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
    public Button botonEf1;      // Botón para activar el efecto
    public Button botonPausa;    // Botón para pausar el efecto
    public Button botonPlay;     // Botón para reanudar el efecto

    private bool isPaused = false;

    void Start()
    {
        // Vincular botones
        botonEf1.onClick.AddListener(LoadEffectScene);
        botonPausa.onClick.AddListener(PauseEffect);
        botonPlay.onClick.AddListener(ResumeEffect);
    }

    void LoadEffectScene()
    {
        // Cargar la escena del efecto
        SceneManager.LoadScene("HexagonShield", LoadSceneMode.Additive);
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

    void UnloadEffectScene()
    {
        // Descargar la escena del efecto
        SceneManager.UnloadSceneAsync("HexagonShield");
    }
}
