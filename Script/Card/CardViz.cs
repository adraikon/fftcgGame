/* 
 * Auteur : Damien "Raikon" Campolo   -   Version : 0.2   -   Date de dernière modification : 23/12/2018
 * 
 *                            Class CardViz            -                 MonoBehaviour : Card
 * 
 * Description : ...
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
using UnityEngine.UI;

namespace fftcg
{
    public class CardViz : MonoBehaviour
    {
        
        public Card card;

        public CardVizProperties[] properties;

        public GameObject powerHolder;

        private void Start()
        {
            Loadcard(card);

            
        }

        public void Loadcard(Card c)
        {

            if (c == null)
                return;

            card = c;

            c.cardType.OnSetType(this);

            for (int i = 0; i < c.properties.Length; i++)
            {
                
                CardProperties cp = c.properties[i];

                CardVizProperties p = GetProperty(cp.element);

                if (p == null)
                    continue;

                if (cp.element is ElementInt)
                {
                    p.text.text = cp.intValue.ToString();
                }
                else if (cp.element is ElementText)
                {
                    p.text.text = cp.stringValue;
                }
                else if (cp.element is ElementImage)
                {
                    p.image.sprite = cp.sprite;
                }
                
            }

        }

        public CardVizProperties GetProperty(Element e)
        {
            CardVizProperties result = null;
            for (int i = 0; i < properties.Length; i++)
            {
                if (properties[i].element == e)
                {
                    result = properties[i];
                    break;
                }
            }
            return result;
        }

    }
}

