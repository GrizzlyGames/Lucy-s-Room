using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player_Script : MonoBehaviour
{
    public Text subtitle_Text;
    private RaycastHit rayHit;
    private Ray ray;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Identifies interactable objects
        if (Physics.Raycast(ray, out rayHit, 3, 1 << 8))
        {
            subtitle_Text.text = "Debug: " + rayHit.collider.gameObject.name;
        }
        else
            subtitle_Text.text = "";
    }
}
