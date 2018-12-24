/* 
 * Auteur : Damien "Raikon" Campolo   -   Version : 0.2   -   Date de dernière modification : 23/12/2018
 * 
 * Class CardType -> class Backup (asset) - scriptableObjetc : CardType -> Forward, Backup, Summon, Monster<non implémenté>
 *        
 * Description : Asset correspondant au type Backup d'un carte.
 * 
 * ProjectName :    fftcgGame                -                Date de création du script : 22/11/2018
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
    [CreateAssetMenu(menuName = "CardType/Backup")]
    public class BackupCard : CardType
    {
        public override void OnSetType(CardViz viz)
        {
            base.OnSetType(viz);
            viz.powerHolder.SetActive(false);
        }

    }
}
