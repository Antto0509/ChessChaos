using System;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    public AudioClip clip; // L'audio clip à jouer
    
    [Range(0f, 1f)]
    public float volume; // Le volume de l'audio clip 
    
    [Range(0.1f, 2.5f)]
    public float pitch; // Le pitch de l'audio clip
    
    private AudioSource _source; // La source audio

    private void Awake()
    {
        gameObject.AddComponent<AudioSource>(); // Ajoute un composant AudioSource à l'objet
        _source = GetComponent<AudioSource>(); // Récupère le composant AudioSource

        volume = 0.5f;
        pitch = 1f;
    }
    
    // Méthode pour jouer l'audio clip
    public void Start()
    {
        _source.clip = clip; // Attribue l'audio clip à la source audio
        _source.volume = volume; // Attribue le volume à la source audio
        _source.pitch = pitch; // Attribue le pitch à la source audio
    }
    
    // Méthode pour mettre en pause l'audio clip
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PayAndPause();
        }
        
        _source.volume = volume; // Attribue le volume à la source audio
        _source.pitch = pitch; // Attribue le pitch à la source audio
    }
    
    // Méthode pour jouer ou mettre en pause l'audio clip
    public void PayAndPause()
    {
        if (_source.isPlaying)
        {
            _source.Pause();
        }
        else
        {
            _source.Play();
        }
    }
}
