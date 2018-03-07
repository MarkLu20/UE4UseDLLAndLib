// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.IO;

public class CallLib : ModuleRules
{
    private string ModulePath
    {
        get { return ModuleDirectory; }
        //return Path.GetDirectoryName(RulesCompiler.GetModuleFilename(this.GetType().Name));
    
    }
    private string ThirdPartyPath
    {
        get { return Path.GetFullPath(Path.Combine(ModulePath, "../../ThirdParty/")); }
    }
    public CallLib(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

        PublicIncludePaths.Add(Path.Combine(ThirdPartyPath, "Includes"));
        PublicAdditionalLibraries.Add(Path.Combine(ThirdPartyPath, "Libs", "LibVS.lib"));
        PublicDelayLoadDLLs.Add("TestDll.dll");
        RuntimeDependencies.Add(new RuntimeDependency(Path.Combine(ThirdPartyPath, "TestDll.dll")));
      

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}
