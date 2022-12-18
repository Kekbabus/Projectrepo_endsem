using UnityEngine;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour
{
    public Canvas currentCanvas;

    public void UnpauseGame()
    {
        Time.timeScale = 1;
        currentCanvas.gameObject.SetActive(false);
    }
}