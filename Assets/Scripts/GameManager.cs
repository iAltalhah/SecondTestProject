using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int catsCollected;



    public void GotCat()
    {
        catsCollected++;
    }
}
