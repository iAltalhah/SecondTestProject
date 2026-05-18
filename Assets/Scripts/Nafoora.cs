using UnityEngine;
using UnityEngine.UI;

public class Nafoora : MonoBehaviour, IInteractable
{
    [SerializeField] string prompt;
    public string InteractionPrompt => prompt;

    public void Interact()
    {
        Debug.Log("Hello");
    }
}
