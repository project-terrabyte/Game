// Description: Action for the Formation button in the Lobby scene.
// Author: https://github.com/
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Lobby.UserInterface.Buttons {
    public class BtnStory : MonoBehaviour {

        [SerializeField] private AudioClip audioClip;
        [SerializeField] private AudioSource audioSource;

        public void OnClick() {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }
}
