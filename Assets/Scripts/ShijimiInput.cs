using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShijimiInput : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
        if(Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if(Physics.Raycast(ray, out hit, 100f))
            {
                if(hit.collider == null)
                {
                    return;
                }

                var other = hit.collider.gameObject;
                if(hit.collider.CompareTag("ButterflyPicture"))
                {
                    other.SendMessage("ShowButterfly");
                    other.SetActive(false);
                }
                else if(hit.collider.CompareTag("Butterfly"))
                {
                    other.GetComponentInParent<Butterfly>().SendMessage("FlyAway");
                }
            }
        }
	}
}
