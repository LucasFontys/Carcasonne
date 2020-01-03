using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zoomCamera : MonoBehaviour
{
    public Button zoomInButton;
    public Button zoomoutButton;
    public Camera mainCamera;

    private float targetZoom;
    private float zoomFactor = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Button zoomInBttn = zoomInButton.GetComponent<Button>();
        Button zoomoutBttn = zoomoutButton.GetComponent<Button>();
        zoomInBttn.onClick.AddListener(ZoomIn);
        zoomoutBttn.onClick.AddListener(ZoomOut);

        targetZoom = mainCamera.orthographicSize;
    }

    void ZoomIn()
    {
        mainCamera.orthographicSize = 2.5f;

    }

    void ZoomOut()
    {
        mainCamera.orthographicSize = 5;
    }

}
