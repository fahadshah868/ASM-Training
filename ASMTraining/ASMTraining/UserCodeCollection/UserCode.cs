﻿/*
 * Created by Ranorex
 * User: Fahad Shah
 * Date: 2/22/2018
 * Time: 12:01 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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
using System.Linq;

namespace ASMTraining.UserCodeCollection
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class UserCode 
    {
    	public static ASMTraining.ASMTrainingRepository repo = ASMTraining.ASMTrainingRepository.Instance;
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void visitCompetencyTrainingItem()
    	{
    		var listitems = repo.ASMTraining.CompetencyTraining_ListView.Children.ToList();
    		listitems[0].Touch();
    		Delay.Milliseconds(500);
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void takePhotoButton()
    	{
    		repo.ASMTraining.TakePhotoButton.Touch();
    		Delay.Seconds(5);
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void capturingPictureList()
    	{
    		var takepicturelist = repo.ASMTraining.CapturingPicture_TakePicture.Children.ToList();
    		takepicturelist[0].Touch();
    		Delay.Milliseconds(500);
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void VisitProjectPrograms()
    	{
    		var projectprograms = repo.ASMTraining.Project_ListView.Children.ToList();
    		for(int i=0; i<projectprograms.Count; i++){
    			projectprograms[i].Touch();
    			Delay.Seconds(10);
    			ASMTraining.TestCases.CCSD_E_Book.VisitZonalRanking.Start();
    		}
    	}
   		/// <summary>
   		/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
   		/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
   		public static void visit_ZonalRanking()
    	{
    		var zonalranking = repo.ASMTraining.ZonalRanking_ListView.Children.ToList();
    		for(int i=0; i<zonalranking.Count; i++){
    			zonalranking[i].Touch();
   				Delay.Milliseconds(500);
   				ASMTraining.TestCases.CCSD_E_Book.VisitRegionalRanking.Start();
    		}
    		ASMTraining.TestCases.CCSD_E_Book.ValidateProjectProgram.Start();
    	}
   		/// <summary>
   		/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
   		/// </summary>
    	[UserCodeMethod]
    	public static void visitRegion()
   		{
    		var region = repo.ASMTraining.RegionalRanking_ListView.Children.First();
    		region.Touch();
    		Delay.Seconds(10);
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void visitCycleActivities()
    	{
    		var cycleactivities = repo.ASMTraining.CycleActivitiesList.Children.ToList();
    		for(int i=0; i<cycleactivities.Count; i++){
    			cycleactivities[i].Touch();
    			Delay.Seconds(5);
    		}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void visitTVC()
    	{
    		var tvc = repo.ASMTraining.TVC_ListView.Children.ToList();
    		tvc[0].Touch();
    		Delay.Seconds(5);
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void visitZonalChamps()
    	{
    		var zonalchamp = repo.ASMTraining.ZonalChamps_ListView.Children.ToList();
    		for(int i=0; i<zonalchamp.Count; i++){
    			zonalchamp[i].Touch();
    			Delay.Milliseconds(500);
    			ASMTraining.TestCases.Training_Updates.VisitZonalChampions.Start();
    		}
    	}
    }
}