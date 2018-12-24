/* 
 * Auteur : Damien "Raikon" Campolo   -   Version : 0.2   -   Date de dernière modification : 23/12/2018
 * 
 *        abstract Class CardType    -   ScriptableObjetc : CardType -> Forward, Backup, Summon, Monster<non implémenté>
 *                         
 * Description : ...
 * 
 * ProjectName :    fftcgGame                -                Date de création du script : 22/12/2018
 * ProjectDescription : Make a fftcg game with the inspiration of unity tcg game made by Sharp Accent.
 * 
 * TutoFollowLink : https://sharpaccent.com/?c=course&id=29
 * ScriptableObjetcLink (propriétaire : Sharp Accent): https://github.com/sharpaccent/ScriptableObject-Library
 * 
 * Version Unity : 2018.3.0f2
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace fftcg { 

    public abstract class CardType : ScriptableObject
    {
        public string typeName;

        public virtual void OnSetType(CardViz viz)
        {
            Element t = Settings.GetResourcesManager().typeElement;
            CardVizProperties type = viz.GetProperty(t);
            type.text.text = typeName;
        }

    }
}
