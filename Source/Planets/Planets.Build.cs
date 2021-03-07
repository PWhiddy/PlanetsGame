// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Planets : ModuleRules
{
	public Planets(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "Paper2D" });
	}
}
