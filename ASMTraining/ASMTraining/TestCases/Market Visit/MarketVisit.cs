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

namespace ASMTraining.TestCases.Market_Visit
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The MarketVisit recording.
    /// </summary>
    [TestModule("f2464afd-4450-46af-aac3-e43a0e9e88cc", ModuleType.Recording, 1)]
    public partial class MarketVisit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ASMTraining.ASMTrainingRepository repository.
        /// </summary>
        public static ASMTraining.ASMTrainingRepository repo = ASMTraining.ASMTrainingRepository.Instance;

        static MarketVisit instance = new MarketVisit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MarketVisit()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MarketVisit Instance
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ASMTraining.Content.MarketVisit' at Center", repo.ASMTraining.Content.MarketVisitInfo, new RecordItemIndex(0));
            repo.ASMTraining.Content.MarketVisit.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=389,Height=74}) on item 'ASMTraining.MarketVisit_TopHeaderLogo'.", repo.ASMTraining.MarketVisit_TopHeaderLogoInfo, new RecordItemIndex(1));
            Validate.ContainsImage(repo.ASMTraining.MarketVisit_TopHeaderLogoInfo, MarketVisit_TopHeaderLogo_Screenshot1, MarketVisit_TopHeaderLogo_Screenshot1_Options);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ASMTraining.MarketVisit_BackButton' at Center", repo.ASMTraining.MarketVisit_BackButtonInfo, new RecordItemIndex(2));
            repo.ASMTraining.MarketVisit_BackButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=373,Height=310}) on item 'ASMTraining.ASMTraining_Logo'.", repo.ASMTraining.ASMTraining_LogoInfo, new RecordItemIndex(3));
            Validate.ContainsImage(repo.ASMTraining.ASMTraining_LogoInfo, ASMTraining_Logo_Screenshot1, ASMTraining_Logo_Screenshot1_Options);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage MarketVisit_TopHeaderLogo_Screenshot1
        { get { return repo.ASMTraining.MarketVisit_TopHeaderLogoInfo.GetScreenshot1(new Rectangle(0, 0, 389, 74)); } }

        Imaging.FindOptions MarketVisit_TopHeaderLogo_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ASMTraining_Logo_Screenshot1
        { get { return repo.ASMTraining.ASMTraining_LogoInfo.GetScreenshot1(new Rectangle(0, 0, 373, 310)); } }

        Imaging.FindOptions ASMTraining_Logo_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}