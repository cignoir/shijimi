using UnityEngine;
using System.Collections;

public class Butterfly : MonoBehaviour {
    static string[] animationNames;
    bool flying = false;
    float flyingSpeed = 2f;

	void Start () {
        animationNames = new string[] { "Fly Fast", "Fly Medium", "Fly Slow", "Wings Up and Idle" };
    }
	
	void Update () {
        if(flying)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + flyingSpeed * Time.deltaTime, Mathf.Sin(Time.time) * 1f);
        }
	}

    public void Animate()
    {
        animation.Play(animationNames[Random.Range(0, animationNames.Length)]);
    }

    public void FlyAway()
    {
        animation.Play("Fly Fast");
        flying = true;
    }
}
