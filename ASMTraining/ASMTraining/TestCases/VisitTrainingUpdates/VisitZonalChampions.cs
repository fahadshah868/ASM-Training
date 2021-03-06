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

namespace ASMTraining.TestCases.VisitTrainingUpdates
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VisitZonalChampions recording.
    /// </summary>
    [TestModule("126a36b5-73d1-4c0c-adfc-97adb50845b9", ModuleType.Recording, 1)]
    public partial class VisitZonalChampions : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ASMTraining.ASMTrainingRepository repository.
        /// </summary>
        public static ASMTraining.ASMTrainingRepository repo = ASMTraining.ASMTrainingRepository.Instance;

        static VisitZonalChampions instance = new VisitZonalChampions();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VisitZonalChampions()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VisitZonalChampions Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ASMTraining.Validate_ASM_TSEScreen'.", repo.ASMTraining.Validate_ASM_TSEScreenInfo, new RecordItemIndex(0));
            Validate.Exists(repo.ASMTraining.Validate_ASM_TSEScreenInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ASMTraining.ASM_ZonalChampButton' at Center", repo.ASMTraining.ASM_ZonalChampButtonInfo, new RecordItemIndex(1));
            repo.ASMTraining.ASM_ZonalChampButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ZONAL CHAMPIONS') on item 'ASMTraining.Validate_ASMZonalChampsScreen'.", repo.ASMTraining.Validate_ASMZonalChampsScreenInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ASMTraining.Validate_ASMZonalChampsScreenInfo, "Text", "ZONAL CHAMPIONS");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ASMTraining.AsmZonalChamp_BackButton' at Center", repo.ASMTraining.AsmZonalChamp_BackButtonInfo, new RecordItemIndex(3));
            repo.ASMTraining.AsmZonalChamp_BackButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ASMTraining.Validate_ASM_TSEScreen'.", repo.ASMTraining.Validate_ASM_TSEScreenInfo, new RecordItemIndex(4));
            Validate.Exists(repo.ASMTraining.Validate_ASM_TSEScreenInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ASMTraining.TSE_ZonalChampButton' at Center", repo.ASMTraining.TSE_ZonalChampButtonInfo, new RecordItemIndex(5));
            repo.ASMTraining.TSE_ZonalChampButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ZONAL CHAMPIONS') on item 'ASMTraining.Validate_TSEZonalChampsScreen'.", repo.ASMTraining.Validate_TSEZonalChampsScreenInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.ASMTraining.Validate_TSEZonalChampsScreenInfo, "Text", "ZONAL CHAMPIONS");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ASMTraining.TseZonalChamp_BackButton' at Center", repo.ASMTraining.TseZonalChamp_BackButtonInfo, new RecordItemIndex(7));
            repo.ASMTraining.TseZonalChamp_BackButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ASMTraining.Validate_ASM_TSEScreen'.", repo.ASMTraining.Validate_ASM_TSEScreenInfo, new RecordItemIndex(8));
            Validate.Exists(repo.ASMTraining.Validate_ASM_TSEScreenInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'ASMTraining'.", repo.ASMTraining.SelfInfo, new RecordItemIndex(9));
            repo.ASMTraining.Self.PressKeys("{BACK}");
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ASMTraining.ZoneListScreen.Validate_ZoneChampionsScreen'.", repo.ASMTraining.ZoneListScreen.Validate_ZoneChampionsScreenInfo, new RecordItemIndex(10));
            Validate.Exists(repo.ASMTraining.ZoneListScreen.Validate_ZoneChampionsScreenInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
