﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace ASMTraining.TestCases.View_Planogram
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ViewPlanogram recording.
    /// </summary>
    [TestModule("549c2ba4-a024-4ae3-9c89-0b64d673d272", ModuleType.Recording, 1)]
    public partial class ViewPlanogram : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ASMTraining.ASMTrainingRepository repository.
        /// </summary>
        public static ASMTraining.ASMTrainingRepository repo = ASMTraining.ASMTrainingRepository.Instance;

        static ViewPlanogram instance = new ViewPlanogram();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ViewPlanogram()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ViewPlanogram Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ASMTraining.Content.ViewPlanogram' at Center", repo.ASMTraining.Content.ViewPlanogramInfo, new RecordItemIndex(0));
            repo.ASMTraining.Content.ViewPlanogram.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='View Planogram') on item 'ASMTraining.Validate_ViewPlanogramScreen'.", repo.ASMTraining.Validate_ViewPlanogramScreenInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.ASMTraining.Validate_ViewPlanogramScreenInfo, "Text", "View Planogram");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ASMTraining.PlanogramImage' at Center", repo.ASMTraining.PlanogramImageInfo, new RecordItemIndex(2));
            repo.ASMTraining.PlanogramImage.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch gestures", "Swipe gesture with direction 'Left (180°)' starting from 'Center' with distance '1.0' with swipe duration'1s' and step count '0' on item 'ASMTraining.PlanogramImageView'.", repo.ASMTraining.PlanogramImageViewInfo, new RecordItemIndex(3));
            repo.ASMTraining.PlanogramImageView.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Left (180°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "1.0"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "1s"), 0);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'ASMTraining'.", repo.ASMTraining.SelfInfo, new RecordItemIndex(4));
            repo.ASMTraining.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ASMTraining.ViewPlanogram_BackButton' at Center", repo.ASMTraining.ViewPlanogram_BackButtonInfo, new RecordItemIndex(5));
            repo.ASMTraining.ViewPlanogram_BackButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=373,Height=310}) on item 'ASMTraining.ASMTraining_Logo'.", repo.ASMTraining.ASMTraining_LogoInfo, new RecordItemIndex(6));
            Validate.ContainsImage(repo.ASMTraining.ASMTraining_LogoInfo, ASMTraining_Logo_Screenshot1, ASMTraining_Logo_Screenshot1_Options);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage ASMTraining_Logo_Screenshot1
        { get { return repo.ASMTraining.ASMTraining_LogoInfo.GetScreenshot1(new Rectangle(0, 0, 373, 310)); } }

        Imaging.FindOptions ASMTraining_Logo_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}