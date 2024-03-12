using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FightView : UIBase
{
    private Text cardCountTxt;
    private Text usedCardCountTxt;

    private Text hpTxt;
    private Image hpImg;

    private Text powerTxt;

    private Text defenseTxt;

    private void Awake()
    {
        // 绑定UI数据
        this.cardCountTxt = this.transform.Find("CardPile/Icon/TxtCount").GetComponent<Text>();
        this.usedCardCountTxt = this.transform.Find("UsedCardPile/Icon/TxtCount").GetComponent<Text>();

        this.hpTxt = this.transform.Find("Hp/TxtHp").GetComponent<Text>();
        this.hpImg = this.transform.Find("Hp/ImgFill").GetComponent<Image>();

        this.powerTxt = this.transform.Find("Power/TxtPower").GetComponent<Text>();

        this.defenseTxt = this.transform.Find("Hp/Defense/Txt").GetComponent<Text>();
    }

    protected override void OnShow()
    {
        this.gameObject.SetActive(true);

        UpdateHP();
        UpdatePower();
        UpdateDefense();
        UpdateCardCount();
        UpdateUsedCardCount();
    }

    protected override void OnHide()
    {
        this.gameObject.SetActive(false);
    }

    protected override void OnDestroyUI()
    {

    }

    // 更新生命值
    public void UpdateHP()
    {
        var playCurHP = FightStatManager.Instance.PlayerCurHp;
        var playerMaxHP = FightStatManager.Instance.PlayerCurHp;

        this.hpTxt.text = playCurHP.ToString() + "/" + playerMaxHP.ToString();
        this.hpImg.fillAmount = (float)playCurHP / (float)playerMaxHP;
    }

    // 更新防御值
    public void UpdateDefense()
    {
        this.defenseTxt.text = FightStatManager.Instance.PlayerDefense.ToString();
    }

    // 更新能量值
    public void UpdatePower()
    {
        var playCurPower = FightStatManager.Instance.PlayerCurPower;
        var playerMaxPower = FightStatManager.Instance.PlayerMaxPower;

        this.powerTxt.text = playCurPower.ToString() + "/" + playerMaxPower.ToString();
    }

    // 更新卡堆数量
    public void UpdateCardCount()
    {
        this.cardCountTxt.text = FightCardManager.Instance.cardCount.ToString();
    }

    // 更新弃牌堆数量
    public void UpdateUsedCardCount()
    {
        this.usedCardCountTxt.text = FightCardManager.Instance.usedCardCount.ToString();
    }
}
