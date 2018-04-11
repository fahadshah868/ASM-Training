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

namespace ASMTraining.TestCases.MarketVisit
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ASMTraining.Validate_MarketVisitScreen'.", repo.ASMTraining.Validate_MarketVisitScreenInfo, new RecordItemIndex(1));
            Validate.Exists(repo.ASMTraining.Validate_MarketVisitScreenInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ASMTraining.MarketVisit_BackButton' at Center", repo.ASMTraining.MarketVisit_BackButtonInfo, new RecordItemIndex(2));
            repo.ASMTraining.MarketVisit_BackButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ASMTraining.Validate_AsmTrainingMainScreen'.", repo.ASMTraining.Validate_AsmTrainingMainScreenInfo, new RecordItemIndex(3));
            Validate.Exists(repo.ASMTraining.Validate_AsmTrainingMainScreenInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}