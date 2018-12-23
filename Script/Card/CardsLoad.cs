/* 
 * Auteur : Damien "Raikon" Campolo   -   Version : 0.1   -   Date de dernière modification : 22/12/2018
 * 
 * Description : Script placé sur le game manager. Charge à partir de la base de donnée (fichier csv) 
 *              les informations des cartes des différents opus.
 * 
 * Projet : Make a fftcg game
 * 
 * Project : fftcgGame   -   Date de création du script : 10/11/2018
 * 
 * Version Unity : 2018.2.16f1
 * 
 * 
 * 
 * Méthode pour charger les sprites à partir de la base de donnée.
       [Tooltip("The sprite of card")]
       public Sprite[] upCard = new Sprite[217];
       upCard[i] = Resources.Load<Sprite>("OpusI/" + numberID[i]);
 */


using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System;

namespace fftcg
{
            
    public class CardsLoad : MonoBehaviour
    {
        //Chemin d'accées au fichier text de la base de donnée.
        string path = "Assets/Data/Resources/DataOPI.csv";

        
        [Tooltip("The card's number")]
        public List<string> numberID = new List<string>();
        
        [Tooltip("The card's rarety : C,R,H,L,S")]
        public List<string> rarety = new List<string>();

        //[Tooltip("The card's element : Fire, Ice, Wind, Earth,  Ligthning, Water, Light, Dark")]
        //public List<string> element = new List<string>();

        //[Tooltip("The card's cost - A convertir de string to int")]
        //public List<string> cost = new List<string>();

        //[Tooltip("The card's name")]
        //public List<string> nameCard = new List<string>();

        //[Tooltip("The card's rarety : Triple, Ex")]
        //public List<string> attribute = new List<string>();

        //[Tooltip("The card's type : Forward, Backup, Summon, Monster")]
        //public List<string> type = new List<string>();

        //[Tooltip("The card's name")]
        //public List<string> job = new List<string>();

        //[Tooltip("The card's category other : dissidia...")]
        //public List<string> categoryOther = new List<string>();

        //[Tooltip("The card's category main : I,II,III,IV,V,VI,VII,VIII,IX,X,XI,XII,XII,XIV,XV...")]
        //public List<string> categoryMain = new List<string>();

        //[Tooltip("The card's power - A convertir de string to int")]
        //public List<string> power = new List<string>();


        public void Awake()
        {
            LoadCardOnDataBase();
                     
        }

                        
        public void LoadCardOnDataBase()
        {
            //Récuperation dela base de donnée  
            using (var reader = new StreamReader(path))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    numberID.Add(values[0]);
                    rarety.Add(values[1]);
                    //element.Add(values[2]);
                    //cost.Add(values[3]);
                    //nameCard.Add(values[4]);
                    //attribute.Add(values[5]);
                    //type.Add(values[6]);
                    //job.Add(values[7]);
                    //categoryOther.Add(values[8]);
                    //categoryMain.Add(values[9]);
                    //power.Add(values[10]);
                }
            }
        }

        public string numberIDDataBase(int i)
        {
            
                    return numberID[i];
                    //rarety.Add(values[1]);
                    //element.Add(values[2]);
                    //cost.Add(values[3]);
                    //nameCard.Add(values[4]);
                    //attribute.Add(values[5]);
                    //type.Add(values[6]);
                    //job.Add(values[7]);
                    //categoryOther.Add(values[8]);
                    //categoryMain.Add(values[9]);
                    //power.Add(values[10]);
             
        }

        public void PrintPropertiesCard(int i)
        {
            Debug.Log(numberID[i] + " ; " + rarety[i]);
        }

    }
    
}
