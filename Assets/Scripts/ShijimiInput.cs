using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShijimiInput : MonoBehaviour {
    public GameObject touchEffect;

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
                    var touchPosition = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y - 2f, Input.mousePosition.z));
                    Instantiate(touchEffect, touchPosition, touchEffect.transform.rotation);

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
            if(GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "元に戻す"))
            {
                Butterfly.flyCount = 0;
                Application.LoadLevel("shijimi");
            }
        }
    }
}
