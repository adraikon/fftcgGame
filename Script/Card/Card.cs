/* 
 * Auteur : Damien "Raikon" Campolo   -   Version : 0.2   -   Date de dernière modification : 23/12/2018
 * 
 *                            Class Card (asset)           -                 ScriptableObject : new Card
 * 
 * Description : Stock les données de l'une carte qui sont : - un cardType (Forward, Backup, Summon, Monster<non implémenté>) 
 *                                                           - un tableau de CardProperties (numberID, Rarety, ...)
 *         
 * 
 * ProjectName :    fftcgGame                -                Date de création du script : 10/11/2018
 * ProjectDescription : Make a fftcg game with the inspiration of unity tcg game made by Sharp Accent.
 * 
 * TutoFollowLink : https://sharpaccent.com/?c=course&id=29
 * ScriptableObjetcLink (propriétaire : Sharp Accent): https://github.com/sharpaccent/ScriptableObject-Library
 * 
 * Version Unity : 2018.3.0f2
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
