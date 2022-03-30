using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class Banner : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{
  public List<RectTransform> BannerList = new List<RectTransform>();

  public RectTransform Rt;
  int centerID = 1;


    void Start()
    {
        
    }


  public void OnBeginDrag(PointerEventData eventData)
  {
    Debug.Log("OnBeginDrag");
  
  }

  public void OnDrag(PointerEventData eventData) 
  {
    Debug.Log("OnDrag");
  }

  public void OnEndDrag(PointerEventData eventData) 
  {
    Debug.Log("OnEndDrag");
    Rt.DOAnchorPosX(-500f,1f).SetRelative().OnComplete(()=>SetBannerList());
  }


  void SetBannerList()
  {
    //→移動

    //0 1 2
    var box = BannerList[BannerList.Count - 1].anchoredPosition;

    //2を0の場所に
    BannerList[BannerList.Count - 1].anchoredPosition = BannerList[0].anchoredPosition;
    //0を１の場所に
    BannerList[0].anchoredPosition = BannerList[centerID].anchoredPosition;
    //1を2の場所に
    BannerList[centerID].anchoredPosition = box;

    Rt.anchoredPosition = Vector2.zero;


    /*
    //→移動

    //0 1 2
    var box = BannerList[BannerList.Count - 1].anchoredPosition;

    //2を0の場所に
    BannerList[BannerList.Count - 1].anchoredPosition = BannerList[0].anchoredPosition;
    //0を１の場所に
    BannerList[0].anchoredPosition = BannerList[centerID].anchoredPosition;
    //1を2の場所に
    BannerList[centerID].anchoredPosition = box;

    Rt.anchoredPosition = Vector2.zero;
    */
  }


}
