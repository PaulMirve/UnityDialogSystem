using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public Character character;

    private bool isInArea;
    private new SpriteRenderer renderer;

    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = character.sprites[0].image;
    }
    private void OnMouseDown()
    {
        if (isInArea)
        {
            References.player.canMove = false;
            References.dialogManager.conversation = character.dialogs[0];
            References.dialogManager.FollowConveration();
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
