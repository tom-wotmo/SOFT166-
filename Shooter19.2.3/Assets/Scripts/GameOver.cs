using UnityEngine;

public class GameOver : MonoBehaviour
{
    //input 
    public GameObject player;
    public GameObject endScreen;
    // Update is called once per frame
    void Update()
    {
        //checking if the player object is active on every update
        if(player.activeSelf == false)
        {
            //if the player object is set to disactive e.g. it's dead then it will set the endscreen object active
           endScreen.SetActive(true);
        }
        else
        {
            //if not then do not set the endscreen active
            endScreen.SetActive(false);
        }
      
      
    }
}
