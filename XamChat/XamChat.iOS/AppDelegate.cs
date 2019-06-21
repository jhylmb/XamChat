﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using KeyboardOverlap.Forms.Plugin.iOSUnified;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace XamChat.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
            ImageCircle.Forms.Plugin.iOS.ImageCircleRenderer.Init();
           
            global::Xamarin.Forms.Forms.Init();
            global::Xamarin.Forms.FormsMaterial.Init();

            Xamarin.IQKeyboardManager.SharedManager.Enable = true;
            Xamarin.IQKeyboardManager.SharedManager.EnableAutoToolbar = false;

            LoadApplication(new App());


            UITabBar.Appearance.SelectedImageTintColor = ((Color)App.Current.Resources["SecondaryColor"]).ToUIColor();

            //KeyboardOverlapRenderer.Init();

            return base.FinishedLaunching(app, options);
        }
    }
}
