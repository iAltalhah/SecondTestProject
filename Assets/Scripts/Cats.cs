using System.Collections;
using UnityEngine;

public class Cats : MonoBehaviour, IInteractable
{
    [SerializeField] string prompt;
    [SerializeField] Animator catAnim;

    [SerializeField] GameManager gm;

    public string InteractionPrompt => prompt;

    public void Interact()
    {
        gm.GotCat();
        catAnim.SetTrigger("goIdle");
        gameObject.GetComponent<SphereCollider>().enabled = false;
        StartCoroutine(SetCatInactive());

    }

    IEnumerator SetCatInactive()
    {
        yield return new WaitForSeconds(1.2f);
        Destroy(gameObject);

    }

}
