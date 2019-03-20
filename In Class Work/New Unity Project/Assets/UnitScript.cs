using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour
{
    public Renderer renderer;
    public Color unselectedColor;
    public Color selectedColor; 
    public Color hoverColor;

    public LayerMask movementLayerMask;
    private bool selected = false;
    private bool hover = false;

    CharacterController cc;
    float speed = 5f;
    Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        renderer.material.color = unselectedColor;
        destination = transform.position;
        cc = gameObject.GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (selected && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; 
            if (Physics.Raycast(ray, out hit, movementLayerMask))
            {
                destination = hit.point;
            }
        }

        //Movement

        float distance = Vector3.Distance(transform.position, destination);
        if (distance > 0.1f)
        {
            transform.LookAt(destination);
            cc.Move(transform.forward * speed * Time.deltaTime);
        }

    }

    private void OnMouseOver()
    {
        hover = true;
        updateColor();
    }

    private void OnMouseDown()
    {
        selected = true;
        updateColor();
    }

    private void OnMouseExit()
    { 
        updateColor();
    }

    public void updateColor()
    {
        if (selected)
        {
            renderer.material.color = selectedColor;
        }

        else
        {
            if (hover)
            {
                renderer.material.color = hoverColor;
            }

            else
            {
                renderer.material.color = unselectedColor;
            }
        }
    }
}
