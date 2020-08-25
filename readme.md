<!--
GENERATED FILE - DO NOT EDIT
This file was generated by [MarkdownSnippets](https://github.com/SimonCropp/MarkdownSnippets).
Source File: /readme.source.md
To change this file edit the source file and then run MarkdownSnippets.
-->

# <img src="/src/icon.png" height="30px"> DiffEngine

[![Build status](https://ci.appveyor.com/api/projects/status/b62ti1b998iy3njw/branch/master?svg=true)](https://ci.appveyor.com/project/SimonCropp/DiffEngine)
[![NuGet Status](https://img.shields.io/nuget/v/DiffEngine.svg)](https://www.nuget.org/packages/DiffEngine/)

DiffEngine manages launching and cleanup of diff tools. It is designed to be used by any Snapshot/Approval testing library.

**Currently used by:**

 * [ApprovalTests](https://github.com/approvals/ApprovalTests.Net)
 * [Verify](https://github.com/VerifyTests/Verify)

Support is available via [Tidelift](https://tidelift.com/subscription/pkg/nuget-diffengine?utm_source=nuget-diffengine&utm_medium=referral&utm_campaign=enterprise).

<a href='https://dotnetfoundation.org' alt='Part of the .NET Foundation'><img src='https://raw.githubusercontent.com/VerifyTests/Verify/master/docs/dotNetFoundation.svg' height='30px'></a><br>
Part of the <a href='https://dotnetfoundation.org' alt=''>.NET Foundation</a>

<!-- toc -->
## Contents

  * [NuGet package](#nuget-package)
  * [Supported Tools](#supported-tools)
  * [Launching a tool](#launching-a-tool)
  * [Closing a tool](#closing-a-tool)
  * [File type detection](#file-type-detection)
  * [BuildServerDetector](#buildserverdetector)
  * [Disable for a machine/process](#disable-for-a-machineprocess)
  * [Security contact information](#security-contact-information)<!-- endToc -->
  * [Tools](/docs/diff-tool.md) <!-- include: doc-index. path: /docs/mdsource/doc-index.include.md -->
  * [Tool Order](/docs/diff-tool.order.md)
  * [Custom Tool](/docs/diff-tool.custom.md)
  * [Code versus machine level settings](/docs/code-verus-machine-settings.md) <!-- endInclude -->


## NuGet package

 * https://nuget.org/packages/DiffEngine/


## [Supported Tools](/docs/diff-tool.md#supported-tools)

 * [AraxisMerge](/docs/diff-tool.md#araxismerge) <!-- include: diffToolList. path: /src/DiffEngine.Tests/diffToolList.include.md -->
 * [BeyondCompare](/docs/diff-tool.md#beyondcompare)
 * [CodeCompare](/docs/diff-tool.md#codecompare)
 * [DeltaWalker](/docs/diff-tool.md#deltawalker)
 * [Diffinity](/docs/diff-tool.md#diffinity)
 * [DiffMerge](/docs/diff-tool.md#diffmerge)
 * [ExamDiff](/docs/diff-tool.md#examdiff)
 * [Guiffy](/docs/diff-tool.md#guiffy)
 * [Kaleidoscope](/docs/diff-tool.md#kaleidoscope)
 * [KDiff3](/docs/diff-tool.md#kdiff3)
 * [Meld](/docs/diff-tool.md#meld)
 * [Neovim](/docs/diff-tool.md#neovim)
 * [P4Merge](/docs/diff-tool.md#p4merge)
 * [Rider](/docs/diff-tool.md#rider)
 * [SublimeMerge](/docs/diff-tool.md#sublimemerge)
 * [TkDiff](/docs/diff-tool.md#tkdiff)
 * [TortoiseGitMerge](/docs/diff-tool.md#tortoisegitmerge)
 * [TortoiseIDiff](/docs/diff-tool.md#tortoiseidiff)
 * [TortoiseMerge](/docs/diff-tool.md#tortoisemerge)
 * [Vim](/docs/diff-tool.md#vim)
 * [VisualStudio](/docs/diff-tool.md#visualstudio)
 * [VisualStudioCode](/docs/diff-tool.md#visualstudiocode)
 * [WinMerge](/docs/diff-tool.md#winmerge) <!-- endInclude -->


## Launching a tool

A tool can be launched using the following:

<!-- snippet: DiffRunnerLaunch -->
<a id='snippet-diffrunnerlaunch'></a>
```cs
await DiffRunner.Launch(tempFile, targetFile);
```
<sup><a href='/src/DiffEngine.Tests/DiffRunnerTests.cs#L46-L50' title='File snippet `diffrunnerlaunch` was extracted from'>snippet source</a> | <a href='#snippet-diffrunnerlaunch' title='Navigate to start of snippet `diffrunnerlaunch`'>anchor</a></sup>
<!-- endSnippet -->

Note that this method will respect the above [difference behavior](/docs/diff-tool.md#detected-difference-behavior) in terms of Auto refresh and MDI behaviors.


## Closing a tool

A tool can be closed using the following:

<!-- snippet: DiffRunnerKill -->
<a id='snippet-diffrunnerkill'></a>
```cs
DiffRunner.Kill(file1, file2);
```
<sup><a href='/src/DiffEngine.Tests/DiffRunnerTests.cs#L58-L60' title='File snippet `diffrunnerkill` was extracted from'>snippet source</a> | <a href='#snippet-diffrunnerkill' title='Navigate to start of snippet `diffrunnerkill`'>anchor</a></sup>
<!-- endSnippet -->

Note that this method will respect the above [difference behavior](/docs/diff-tool.md#detected-difference-behavior) in terms of MDI behavior.


## File type detection

DiffEngine use [EmptyFiles](https://github.com/SimonCropp/EmptyFiles) to determine if a given file or extension is a binary or text. Custom extensions can be added, or existing ones changed.


## BuildServerDetector

`BuildServerDetector.Detected` returns true if the current code is running on a build/CI server.

Supports:

 * [AppVeyor](https://www.appveyor.com/docs/environment-variables/)
 * [Travis](https://docs.travis-ci.com/user/environment-variables/#default-environment-variables)
 * [Jenkins](https://wiki.jenkins.io/display/JENKINS/Building+a+software+project#Buildingasoftwareproject-belowJenkinsSetEnvironmentVariables)
 * [GitHub Actions](https://help.github.com/en/actions/automating-your-workflow-with-github-actions/using-environment-variables#default-environment-variables)
 * [AzureDevops](https://docs.microsoft.com/en-us/azure/devops/pipelines/build/variables?view=azure-devops&tabs=yaml#agent-variables)
 * [TeamCity](https://www.jetbrains.com/help/teamcity/predefined-build-parameters.html#PredefinedBuildParameters-ServerBuildProperties)
 * [MyGet](https://docs.myget.org/docs/reference/build-services#Available_Environment_Variables)
 * [GitLab](https://docs.gitlab.com/ee/ci/variables/predefined_variables.html)


## Disable for a machine/process

Set an environment variable `DiffEngine.Disabled` with the value `true`.


## Security contact information

To report a security vulnerability, use the [Tidelift security contact](https://tidelift.com/security). Tidelift will coordinate the fix and disclosure.


## Icon

[Engine](https://thenounproject.com/term/engine/3358421/) designed by [Ian Rahmadi Kurniawan](https://thenounproject.com/irk.aminin/) from [The Noun Project](https://thenounproject.com).

https://lineicons.com/icons/
