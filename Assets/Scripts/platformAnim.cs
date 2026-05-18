using UnityEngine;


public class platformAnim : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator animator;
    [SerializeField] GameManager gm;
    [SerializeField] string prompt;
    public string InteractionPrompt => prompt;

    public void Interact()
    {
        if(gm.GotCat() >= 7)
        {
            Debug.Log("nice!!");
        }
    }

}
