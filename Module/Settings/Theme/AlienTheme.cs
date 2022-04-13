﻿using Trinity.Events;
using Trinity.SDK;
using Trinity.SDK.ButtonAPI;
using System;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Trinity.Module.Settings.Theme
{
    class AlienTheme : BaseModule, OnUpdateEvent
    {
        public AlienTheme() : base("Space\nTheme", "Enable Trinity Theme", Main.Instance.SettingsButtonTheme, QMButtonIcons.CreateSpriteFromBase64(Alien.SpaceShip), true, false) { }
        private bool SetTheme = false;
        public Sprite Background = null;
        public bool BGSet = false;
        public override void OnEnable()
        {
            try
            {
                if (Background == null) Background = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/BackgroundLayer01").GetComponent<Image>().activeSprite;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/BackgroundLayer01").GetComponent<Image>().sprite = QMButtonIcons.CreateSpriteFromBase64(Alien.BG);
                Main.Instance.OnUpdateEvents.Add(this);

            }
            catch (Exception Error)
            {
                if (Error.Message.Contains("Object reference not set to an instance of an object")) { }

            }
        }
        public override void OnDisable()
        {
            try
            {
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/BackgroundLayer01").GetComponent<Image>().sprite = Background;
                SetTheme = false;
                Main.Instance.OnUpdateEvents.Remove(this);
            }
            catch (Exception Error)
            {
                if (Error.Message.Contains("Object reference not set to an instance of an object")) { }

            }
        }
        private async Task setUITheme(int WaitToUpdate)
        {

            for (int i = 0; i < WaitToUpdate; i++)
            {
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Dashboard/Background").GetComponent<Image>().color = Color.black;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Notifications/Background").GetComponent<Image>().color = Color.black;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Here/Background").GetComponent<Image>().color = Color.black;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Camera/Background").GetComponent<Image>().color = Color.black;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_AudioSettings/Background").GetComponent<Image>().color = Color.black;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings/Background").GetComponent<Image>().color = Color.black;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Area 51 ClientTab/Background").GetComponent<Image>().color = Color.black;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Dashboard/Icon").GetComponent<Image>().color = Color.white;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Notifications/Icon").GetComponent<Image>().color = Color.white;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Here/Icon").GetComponent<Image>().color = Color.white;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Camera/Icon").GetComponent<Image>().color = Color.white;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_AudioSettings/Icon").GetComponent<Image>().color = Color.white;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings/Icon").GetComponent<Image>().color = Color.white;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Area 51 ClientTab/Icon").GetComponent<Image>().color = Color.white;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/MicButton").GetComponent<Image>().color = Color.black;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/MicButton/Icon").GetComponent<Image>().color = Color.white;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Toggle_SafeMode").GetComponent<Image>().color = Color.black;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Toggle_SafeMode/Icon").GetComponent<Image>().color = Color.white;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/Header_H1/LeftItemContainer/Text_Title").active = false;


                if (GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/BackgroundLayer02").GetComponent<Image>().color != Color.white)
                {
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/BackgroundLayer01").GetComponent<Image>().sprite = QMButtonIcons.CreateSpriteFromBase64(SDK.Alien.BG);
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/BackgroundLayer02").GetComponent<Image>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/BackgroundLayer02").active = false;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Background_QM_PagePanel").GetComponent<Image>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/Header_H1/LeftItemContainer/Text_Title").GetComponent<TextMeshProUGUI>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickLinks/LeftItemContainer/Text_Title").active = false;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickActions/LeftItemContainer/Text_Title").active = false;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickLinks/LeftItemContainer/Text_Title").GetComponent<TextMeshProUGUI>().color = Color.black;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickActions/LeftItemContainer/Text_Title").GetComponent<TextMeshProUGUI>().color = Color.black;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Icon").GetComponent<Image>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Avatars/Icon").GetComponent<Image>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Social/Icon").GetComponent<Image>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Safety/Icon").GetComponent<Image>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_GoHome/Icon").GetComponent<Image>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn/Icon").GetComponent<Image>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_SelectUser/Icon").GetComponent<Image>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Emojis/Icon").GetComponent<Image>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Background").GetComponent<Image>().color = Color.black;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Avatars/Background").GetComponent<Image>().color = Color.black;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Social/Background").GetComponent<Image>().color = Color.black;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Safety/Background").GetComponent<Image>().color = Color.black;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_GoHome/Background").GetComponent<Image>().color = Color.black;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn/Background").GetComponent<Image>().color = Color.black;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_SelectUser/Background").GetComponent<Image>().color = Color.black;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Emojis/Background").GetComponent<Image>().color = Color.black;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Text_H4").GetComponent<TextMeshProUGUI>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Avatars/Text_H4").GetComponent<TextMeshProUGUI>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Social/Text_H4").GetComponent<TextMeshProUGUI>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Safety/Text_H4").GetComponent<TextMeshProUGUI>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_GoHome/Text_H4").GetComponent<TextMeshProUGUI>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn/Text_H4").GetComponent<TextMeshProUGUI>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_SelectUser/Text_H4").GetComponent<TextMeshProUGUI>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Emojis/Text_H4").GetComponent<TextMeshProUGUI>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/DebugInfoPanel/Panel/Text_FPS").GetComponent<TextMeshProUGUI>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/DebugInfoPanel/Panel/Text_Ping").GetComponent<TextMeshProUGUI>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/Header_H1/RightItemContainer/Button_QM_Expand/Icon").GetComponent<Image>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Button/Icon").GetComponent<Image>().color = Color.white;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Button/Icon").GetComponent<Image>().color = Color.white;
                }

                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Icon_On").GetComponent<Image>().color = Color.white;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Icon_Off").GetComponent<Image>().color = Color.white;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Background").GetComponent<Image>().color = Color.black;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Text_H4").GetComponent<TextMeshProUGUI>().color = Color.white;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_CalibrateFBT/Icon").GetComponent<Image>().color = Color.white;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_CalibrateFBT/Background").GetComponent<Image>().color = Color.black;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_CalibrateFBT/Text_H4").GetComponent<TextMeshProUGUI>().color = Color.white;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_MünchenClientMünchenClient2/Icon").GetComponent<Image>().color = Color.white;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_MünchenClientMünchenClient2/Background").GetComponent<Image>().color = Color.black;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Notorious_QMTabButton_7/Icon").GetComponent<Image>().color = Color.white;
                GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Notorious_QMTabButton_7/Background").GetComponent<Image>().color = Color.black;

                if (GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/Header_H1/LeftItemContainer/Text_Title").GetComponent<TextMeshProUGUI>().color != Color.black)
                {
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/Header_H1/LeftItemContainer/Text_Title").GetComponent<TextMeshProUGUI>().color = Color.black;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickLinks/LeftItemContainer/Text_Title").active = false;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickActions/LeftItemContainer/Text_Title").active = false;
                    GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Header_StreamerMode/Header/LeftItemContainer/Icon").GetComponent<Image>().sprite = SDK.ButtonAPI.QMButtonIcons.CreateSpriteFromBase64(SDK.Alien.clientLogo);
                }
            }
        }

        public void OnUpdate()
        {
            try
            {
                setUITheme(1).Start();
            }
            catch (Exception) { }
        }
    }
}

   