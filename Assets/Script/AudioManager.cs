using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * AudioType : Contient les informations sur le son à jouer
 * AudioSource : Source de l'émission du son
 * AudioListener : Écoute et joue les sons pour le joueur
*/

// Enumération des types de sons
public enum AudioType
{
    GameSound,
    ClickSound,
}

// Enumération des sources de sons
public enum AudioSourceType
{
    Game,
    Player
}

// Classe de gestion des sons
public class AudioManager : MonoBehaviour
{
    static public AudioManager Instance; // Instance de la classe

    public float volume = 1f; // Volume du son

    public AudioSource gameSource; // Source de son du jeu
    public AudioSource playerSource; // Source de son du joueur

    // Structure de données pour les sons
    [System.Serializable]
    public struct AudioData
    {
        public AudioClip clip; // Clip audio
        public AudioType type; // Type de son
    }

    public AudioData[] audioData; // Tableau des données des sons

    // Fonction d'initialisation
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Fonction de démarrage
    void Start()
    {
        gameSource.volume = volume;
        playerSource.volume = volume;
    }

    // Fonction de lecture du son
    public void PlaySound(AudioType type, AudioSourceType sourceType)
    {
        AudioClip clip = getClip(type);

        if (sourceType == AudioSourceType.Game)
        {
            gameSource.PlayOneShot(clip);
        }
        else if (sourceType == AudioSourceType.Player)
        {
            playerSource.PlayOneShot(clip);
        }
    }

    // Fonction de récupération du son
    AudioClip getClip(AudioType type)
    {
        foreach (AudioData data in audioData)
        {
            if (data.type == type)
            {
                return data.clip;
            }
        }
        Debug.LogError("AudioManager: No clip found for type " + type);
        return null;
    }
}