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
            }
        }
	}

    void OnGUI()
    {
        if(Butterfly.flyCount >= 10)
        {
            if(GUI.Button(new Rect(0, 0, 100, 50), "元に戻す"))
            {
                Butterfly.flyCount = 0;
                Application.LoadLevel("shijimi");
            }
        }
    }
}
