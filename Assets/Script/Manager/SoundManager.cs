using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager
{
    AudioSource[] _audioSources = new AudioSource[(int)Define.Sound.MaxCount];

    public void Init()
    {
        GameObject root = GameObject.Find("@Sound");

        if (root == null)
        {
            root = new GameObject("@Sound");
            Object.DontDestroyOnLoad(root);

            string[] sounds = System.Enum.GetNames(typeof(Define.Sound));

            for (int i = 0; i < (int)Define.Sound.MaxCount; i++)
            {
                GameObject go = new GameObject() { name = sounds[i] };
                _audioSources[i] = go.AddComponent<AudioSource>();
                go.transform.parent = root.transform;
            }
        }

        _audioSources[(int)Define.Sound.Bgm].loop = true;
    }

    public void Play(string path, Define.Sound type)
    {
        AudioClip audioClip = GameManager.Resource.Load<AudioClip>(path);
        AudioSource audioSource = _audioSources[(int)type];

        if (audioClip == null)
        {
            Debug.Log($"thay have no {path} sound");
            return;
        }

        if (type == Define.Sound.Bgm)
        {
            audioSource.Stop();

            audioSource.clip = audioClip;
            audioSource.Play();
        }
        if (type == Define.Sound.Effect)
        {
            audioSource.PlayOneShot(audioClip);
        }
    }

}
