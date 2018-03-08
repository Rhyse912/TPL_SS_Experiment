// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class TPL_SS_ExperimentTarget : TargetRules
{
	public TPL_SS_ExperimentTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "TPL_SS_Experiment" } );
	}
}
