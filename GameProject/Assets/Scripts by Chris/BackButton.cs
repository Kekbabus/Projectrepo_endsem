using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public Canvas previousCanvas;

    public void GoBack()
    {
        previousCanvas.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}