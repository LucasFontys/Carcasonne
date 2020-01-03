using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateScript : MonoBehaviour
{
    public GameObject grabbedObject;


    private bool amHolding = false;

    private Vector2 mousePos;

    public LayerMask placedTiles;
    public LayerMask grabableTiles;


    // Update is called once per frame
    void Update()
    {
        // check if something grabbable under
        Vector2 mouseRay = Camera.main.ScreenToWorldPoint(mousePos);
        RaycastHit2D rayHitGrabbable = Physics2D.Raycast(mousePos, Vector2.zero, Mathf.Infinity, grabableTiles);
        RaycastHit2D rayHitPlaced = Physics2D.Raycast(mousePos, Vector2.zero, Mathf.Infinity, placedTiles);

        // mouse position 
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (amHolding)
        {
            
            grabbedObject.transform.position = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));

            if (Input.GetKeyDown(KeyCode.R))
            {
                RotateRight();
            }
        }      

        if (Input.GetMouseButtonDown(0))
        {
            if (amHolding)
            {
                if (rayHitPlaced.collider == null)
                {
                    //drop held object
                    grabbedObject.layer = 9;

                    grabbedObject = null;
                    amHolding = false;
                }
                else
                {
                    //cant drop
                    Debug.Log("cant drop");
                }
              
            }
            else{
                

                if(rayHitGrabbable.collider == null)
                {
                    // niks gevonden om op te pakken
                    Debug.Log("Miss");
                }
                else
                {
                    Debug.Log("Hit");
                    grabbedObject = rayHitGrabbable.collider.gameObject;
                    amHolding = true;
                }


            }
        }

        

        
    }

    void RotateRight()
    {
        Debug.Log("Turn right");
        grabbedObject.transform.Rotate(Vector3.forward * -90);
    }
}
