﻿namespace EsnyaFactory
{
  using UdonSharp;
  using UnityEngine;
  using UnityEngine.UI;
  using VRC.SDKBase;
  using VRC.Udon;
  using VRC.SDK3.Video.Components;
  using VRC.SDK3.Video.Components.AVPro;

  public class VideoPlayerLoop : UdonSharpBehaviour
  {
    public VRCUnityVideoPlayer unityVideoPlayer;
    public VRCAVProVideoPlayer avProVideoPlayer;
    public bool loop = false;
    public Image icon;

    public void Toggle() {
      loop = !loop;
      if (unityVideoPlayer != null) unityVideoPlayer.Loop = loop;
      if (avProVideoPlayer != null) avProVideoPlayer.Loop = loop;
      if (icon != null) icon.color = loop ? Color.white : Color.gray;
    }
  }
}
