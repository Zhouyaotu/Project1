using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudiManager : MonoBehaviour
{
    public static AudiManager Instance;

    private AudioSource bgmSource;

    void Awake()
    {
        Instance = this;
    }

    public void Init()
    {
        if(this.bgmSource == null)
        {
            this.bgmSource = this.gameObject.AddComponent<AudioSource>();
        }
    }

    public void PlayBGM(string name, bool isLoop = true)
    {
        var clip =  Resources.Load<AudioClip>("Sounds/BGM/" + name);

        this.bgmSource.clip = clip;
        this.bgmSource.loop = isLoop;

        this.bgmSource.Play();
    }

    public void PlayEffect(string name)
    {
        var clip = Resources.Load<AudioClip>("Sounds/Effect/" + name);

        AudioSource.PlayClipAtPoint(clip, this.transform.position);
    }
}
