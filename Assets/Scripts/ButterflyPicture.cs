using UnityEngine;
using System.Collections;

public class ButterflyPicture : MonoBehaviour {
    public GameObject[] butterflies;

	void Start () {
	
	}
	
	void Update () {
        
	}

    void ShowButterfly()
    {
        foreach(GameObject bf in butterflies)
        {
            bf.transform.position = new Vector3(bf.transform.position.x + 5f, bf.transform.position.y, bf.transform.position.z);
            bf.SendMessage("Animate");
        }
    }
}
