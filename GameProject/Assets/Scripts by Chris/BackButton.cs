using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public Canvas currentCanvas;

    public void goBack()
    {
        currentCanvas.gameObject.SetActive(false);
    }
}