/* 
 * Auteur : Damien "Raikon" Campolo   -   Version : 0.2   -   Date de dernière modification : 23/12/2018
 * 
 *                           Class CardProperties           -                System.Serializable
 * 
 * Description : Permet de programmer les différentes propriétés d'une carte
 *
 * ProjectName :    fftcgGame                -                Date de création du script : 10/11/2018
 * ProjectDescription : Make a fftcg game with the inspiration of unity tcg game made by Sharp Accent.
 * 
 * TutoFollowLink : https://sharpaccent.com/?c=course&id=29
 * ScriptableObjetcLink (propriétaire : Sharp Accent): https://github.com/sharpaccent/ScriptableObject-Library
 * 
 * Version Unity : 2018.3.0f2
 */
using UnityEngine;
using System.Collections;

namespace fftcg
{
    [System.Serializable]
    public class CardProperties
    {
        public string stringValue;
        public int intValue;
        public Sprite sprite;
        public Element element;
       
    }
}
