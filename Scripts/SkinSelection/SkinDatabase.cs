using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class SkinDatabase : ScriptableObject
{


    public SkinBase[] skinBase;


    public int SkinCounter { get { return skinBase.Length;}}

    public SkinBase GetSkin(int index)
    {
        return skinBase[index];

    }


}
