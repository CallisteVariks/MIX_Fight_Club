using UnityEngine;

namespace Monsters
{
    public class PlayOnStateChange : MonoBehaviour
    {
        public AudioClip entryClip;


        private AudioSource source;

        void Awake()
        {
            source = GetComponent<AudioSource>();
            source.enabled = false;
        }


        public void Initialize()
        {
            source.enabled = true;
        }


        public void PlayOnAppear()
        {
            source.clip = entryClip;
            source.Play();
        }
    }
}