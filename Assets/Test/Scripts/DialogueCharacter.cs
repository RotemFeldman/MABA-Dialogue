using System;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class DialogueCharacter : MonoBehaviour
{
    public Image otherChar;
    public Image selfChar;

    private void Start()
    {
        selfChar = GetComponent<Image>();
    }

    [YarnCommand("speak")]
    public void Speak()
    {
        selfChar.color = Color.white;
        otherChar.color = new Color(0.5f, 0.5f, 0.5f, 1f);
    }
}
