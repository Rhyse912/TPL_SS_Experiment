// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class TPL_SS_ExperimentEditorTarget : TargetRules
{
	public TPL_SS_ExperimentEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "TPL_SS_Experiment" } );
	}
}
