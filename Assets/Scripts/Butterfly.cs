using UnityEngine;
using System.Collections;

public class Butterfly : MonoBehaviour {
    public static int flyCount;
    static string[] animationNames;
    bool flying = false;
    float flyingSpeed = 2f;
    float default_z;

	void Start () {
        animationNames = new string[] { "Fly Fast", "Fly Medium", "Fly Slow", "Wings Up and Idle" };
        default_z = transform.position.z;
    }
	
	void Update () {
        if(flying)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + flyingSpeed * Time.deltaTime, default_z + Mathf.Sin(Time.time) * 0.8f);
        }
	}

    public void Animate()
    {
        flyCount++;
        animation.Play(animationNames[Random.Range(0, animationNames.Length)]);
        FlyAway();
    }

    public void FlyAway()
    {
        animation.Play("Fly Fast");
        flying = true;
    }
}
