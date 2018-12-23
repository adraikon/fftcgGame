
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

 using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace fftcg
{
    public class CardViz : MonoBehaviour
    {
        
        public Card card;

        public CardVizProperties[] properties;

        public GameObject statsHolder;

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

