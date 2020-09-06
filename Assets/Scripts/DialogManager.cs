using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public Dialog conversation;
    public GameObject dialog;

    private DialogScript dialogScript;
    private int currentLineIndex;

    private void Start()
    {
        dialogScript = dialog.GetComponent<DialogScript>();
        FollowConveration();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentLineIndex++;
            FollowConveration();
        }
    }

    public void FollowConveration()
    {
        if (currentLineIndex < conversation.lines.Length)
        {
            Line currentLine = conversation.lines[currentLineIndex];
            dialogScript.Dialog = currentLine.text;
            dialogScript.Name = currentLine.character.name;
            dialogScript.Image = currentLine.character.images.FirstOrDefault(sprite => sprite.name == currentLine.spriteName).image;
        }
        else
        {
            References.player.canMove = true;
            dialog.SetActive(false);
        }
    }
}
