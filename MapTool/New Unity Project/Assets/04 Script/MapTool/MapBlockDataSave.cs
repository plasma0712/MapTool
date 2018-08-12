using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapBlockDataSave : Singleton<MapBlockDataSave>
{
    [SerializeField]
    Image iMonsterImage;

    public XMLMapBlockSettingData cMapBlockSettingData;

    public void Init(XMLMapBlockSettingData _cMapBlockSettingData)
    {
        cMapBlockSettingData = _cMapBlockSettingData;

        iMonsterImage.sprite = XMLMapBlockSetting.Instance.MapBlockSprites[(int)_cMapBlockSettingData.fNumber];
    }




}
