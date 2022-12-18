using UnityEngine;
using UnityEngine.UI;

public class ControlsButton : MonoBehaviour
{
    public Canvas secondCanvas;

    public void OpenSecondCanvas()
    {
        secondCanvas.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}