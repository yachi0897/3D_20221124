
using UnityEngine;


namespace FOX
{
    /// <summary>
    /// 音效系統
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class SoundSystem : MonoBehaviour
    {
        private AudioSource aud;
        private void Awake()
        {
            aud = GetComponent<AudioSource>();
        }

        ///<summary>
        ///播放音效
        ///</summary>
        ///<param name="sound">要播放的音效</param>
        public void PlaySound(AudioClip sound)
        {
            //音效來源 撥放一次音效(音效)；
            aud.PlayOneShot(sound);
        }

    }
}

