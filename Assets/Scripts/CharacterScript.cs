using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    private bool isInArea;
    private void OnMouseDown()
    {
        if (isInArea)
        {
            References.player.canMove = false;
            References.dialog.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isInArea = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isInArea = false;
    }
}
