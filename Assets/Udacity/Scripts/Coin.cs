using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	public GameObject coinPoof;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
		Object.Instantiate(coinPoof, transform.position, coinPoof.transform.rotation);
		// Destroy this coin 
		Destroy(gameObject, 0.5f); 

    }

}
