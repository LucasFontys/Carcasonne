using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveCamera : MonoBehaviour
{
    public Button upButton;
    public Button downButton;
    public Button leftButton;
    public Button rightButton;
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        Button btnUP = upButton.GetComponent<Button>();
        Button btnDOWN = downButton.GetComponent<Button>();
        Button btnLEFT = leftButton.GetComponent<Button>();
        Button btnRIGHT = rightButton.GetComponent<Button>();
        btnUP.onClick.AddListener(MoveUp);
        btnDOWN.onClick.AddListener(MoveDown);
        btnLEFT.onClick.AddListener(MoveLeft);
        btnRIGHT.onClick.AddListener(MoveRight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveRight()
    {
        Debug.Log("You have clicked the button!");
        mainCamera.transform.position = mainCamera.transform.position + new Vector3(4, 0);
    }

    void MoveLeft()
    {
        Debug.Log("You have clicked the button!");
        mainCamera.transform.position = mainCamera.transform.position + new Vector3(-4, 0);
    }

    void MoveUp()
    {
        Debug.Log("You have clicked the button!");
        mainCamera.transform.position = mainCamera.transform.position + new Vector3(0, 4);
    }

    void MoveDown()
    {
        Debug.Log("You have clicked the button!");
        mainCamera.transform.position = mainCamera.transform.position + new Vector3(0, -4);
    }
}
