// Description: 
// Author: https://github.com/
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UiController : MonoBehaviour {

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip[] audioClips;

    private void Start() {
        audioSource.clip = audioClips[0];
        audioSource.Play();
    }
}
