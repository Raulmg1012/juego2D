using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Animation anim = GetComponent<Animation>();

        if (Input.GetAxis("Horizontal") != 0)
        {
            anim.Play("HeroKnight_Run");
        }
        else
        {
            anim.Play("HeroKnigth_Idle");
        }
    }
}
