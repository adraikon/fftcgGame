using UnityEngine;
using System.Collections;
using UnityEditor;

namespace  fftcg
{
    public class MakeCard
    {

        [MenuItem("Assets/Create/MakeCard")]
        public static void CreateMyAsset()
        {
            Card assetCard = ScriptableObject.CreateInstance<Card>();

            AssetDatabase.CreateAsset(assetCard, "Assets/NewCard.asset");
            AssetDatabase.SaveAssets();

            EditorUtility.FocusProjectWindow();

            Selection.activeObject = assetCard;
        }
    }
}
