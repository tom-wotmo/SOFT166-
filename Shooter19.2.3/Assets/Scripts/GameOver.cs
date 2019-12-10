using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject player;
    public GameObject endScreen;
    // Update is called once per frame
    void Update()
    {
        if(player.activeSelf == false)
        {
           endScreen.SetActive(true);
        }
        else
        {
            endScreen.SetActive(false);
        }
      
      
    }
}
