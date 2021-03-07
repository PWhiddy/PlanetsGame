// Copyright Epic Games, Inc. All Rights Reserved.

#include "PlanetsGameMode.h"
#include "PlanetsCharacter.h"

APlanetsGameMode::APlanetsGameMode()
{
	// Set default pawn class to our character
	DefaultPawnClass = APlanetsCharacter::StaticClass();	
}
