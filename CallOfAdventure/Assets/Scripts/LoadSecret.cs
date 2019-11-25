using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSecret : MonoBehaviour {


    public GameObject player;
    //public string SceneToLoad; // this makes it reusable and we can add what ever Scene we want into it.
    public float Trigger = 1f;
    public int x;
    public string LoadLevel;

    // Update is called once per frame
    private void Update() {

        player = GameObject.FindWithTag("Player");
        // Looks for a tag of player if true and in that block it goes on.
            float distance = Vector2.Distance(player.transform.position, transform.position);
            if (distance <= Trigger)
            {
                PlayerPrefs.SetInt("Portal", x);
                PlayerPrefs.Save();

                Debug.Log("Near");
                SceneManager.LoadScene(LoadLevel);
               
            }
        
    }
}
