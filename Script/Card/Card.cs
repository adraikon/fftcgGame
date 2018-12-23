/* 
 * Auteur : Damien "Raikon" Campolo   -   Version : 0.1   -   Date de dernière modification : 22/12/2018
 * 
 * Description : 
 * 
 * Projet : Make a fftcg game
 * 
 * Project : fftcgGame   -   Date de création du script : 10/11/2018
 * 
 * Version Unity : 2018.2.16f1
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace fftcg
{
    [CreateAssetMenu(fileName = "New Card", menuName = "Card")]
    public class Card : ScriptableObject
    {
        public CardType cardType;
        public CardProperties[] properties;

        //[Tooltip("The card's number")]
        //public string numberID;


        //[Tooltip("The card's rarety : C,R,H,L,S")]
        //public string rarety;


        //[Tooltip("The card's element : Fire, Ice, Wind, Earth,  Ligthning, Water, Light, Dark")]
        //[SerializeField]
        //private string _element;
        //public string element { get { return _element; } }

        //[Tooltip("The card's cost - A convertir de string to int")]
        //[SerializeField]
        //private int _cost;
        //public int cost { get { return _cost; } }

        //[Tooltip("The card's name")]
        //[SerializeField]
        //private string _nameCard;
        //public string nameCard { get { return _nameCard; } }

        //[Tooltip("The card's rarety : Triple, Ex")]
        //[SerializeField]
        //private string _attribute;
        //public string attribute { get { return _attribute; } }

        //[Tooltip("The card's type : Forward, Backup, Summon, Monster")]
        //[SerializeField]
        //private string _type;
        //public string type { get { return _type; } }

        //[Tooltip("The card's name")]
        //[SerializeField]
        //private string _job;
        //public string job { get { return _job; } }

        //[Tooltip("The card's category other : dissidia...")]
        //[SerializeField]
        //private string _categoryOther;
        //public string categoryOther { get { return _categoryOther; } }

        //[Tooltip("The card's category main : I,II,III,IV,V,VI,VII,VIII,IX,X,XI,XII,XII,XIV,XV...")]
        //[SerializeField]
        //private string _categoryMain;
        //public string categoryMain { get { return _categoryMain; } }

        //[Tooltip("The card's power - A convertir de string to int")]
        //[SerializeField]
        //private int _power;
        //public int power { get { return _power; } }



    }

}
