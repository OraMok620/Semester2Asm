using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreasureCollectors : MonoBehaviour
{
    private int TreasureCollected = 0;
    private int totalTreasures = 3;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Treasure"))
        {
            TreasureCollected++;
            Debug.Log("Treasure found! Total treasures: " + TreasureCollected);
            if (TreasureCollected >= totalTreasures)
            {
                Debug.Log("All treasures found! Loading GameWinScene...");
                SceneManager.LoadScene("GameWinScene");
            }
        }
    }
}
