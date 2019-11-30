using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAnimationOnFound : MonoBehaviour
{
    private bool rendering = false;
    private Renderer renderer;
    public Animation anim;
    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }
    void Update()
    {
        if (renderer.enabled != rendering)
        {
            rendering = renderer.enabled;
            if (rendering)
            {
                // anim.clip.wrapMode = WrapMode.Loop;
                anim.Play();
            }
            else
                anim.Stop();
        }
    }
}
