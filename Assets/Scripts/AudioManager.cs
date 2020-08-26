using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

	public static AudioManager instance;

	public AudioMixerGroup mixerGroup;

	public Sound[] sounds;

    public static bool SFX_disabled;
    public static bool  music_disabled;

	void Awake()
	{
		if (PlayerPrefs.GetInt("SFX", 0) == 0) SFX_disabled = false;
		else SFX_disabled = true;
		if (PlayerPrefs.GetInt("Music", 0) == 0) music_disabled = false;
		else music_disabled = true;

		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}

		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.loop = s.loop;
			s.source.playOnAwake = s.playOnAwake;

			s.source.outputAudioMixerGroup = mixerGroup;
		}
	}

	public void Play(string sound)
	{
		if (!SFX_disabled ||sound == MusicTrigger.sceneName)
		{

			Sound s = Array.Find(sounds, item => item.name == sound);
			if (s == null)
			{
				Debug.LogWarning("Sound: " + name + " not found!");
				return;
			}

			s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
			s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));

			s.source.Play();
		}
	}


	public void PlayMusic()
	{
		if (!music_disabled)
		{
			string sound = MusicTrigger.sceneName;
			Sound s = Array.Find(sounds, item => item.name == sound);
			if (s == null)
			{
				Debug.LogWarning("Sound: " + name + " not found!");
				return;
			}

			s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
			s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));

			s.source.Play();
		}
	}
	//for background music 
	public void StopMusic()
	{
		string sound = MusicTrigger.sceneName;
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("music: " + sound + " not found!");
			return;
		}
		s.source.Stop();
	}

}
