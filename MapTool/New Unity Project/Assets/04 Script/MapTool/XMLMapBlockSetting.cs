using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Linq;


public class XMLMapBlockSetting : Singleton<XMLMapBlockSetting>
{

    public Sprite[] MapBlockSprites;

    public List<XMLMapBlockSettingData> MapBlocks;

    string filePath = "./Assets/Resources/MapBlockList.xml";

    private void Awake()
    {
        //MapSpriteInspectorAutoGrid();
        CreateXml();
        LoadXml();

        MapBlockSprites = Resources.LoadAll<Sprite>("MapBlockSprite");
    }

    void CreateXml()
    {

    }
    void LoadXml()
    {

    }

    //void MapSpriteInspectorAutoGrid()
    //{
    //    for(int i =0;i<1000;i++)
    //    {
    //        MapBlockSprites[i] = Resources.LoadAll<Sprite>("MapTest"+i);
    //    }
    //}
}

public class XMLMapBlockSettingData
{
    public float fType;
    public float fNumber;

}
