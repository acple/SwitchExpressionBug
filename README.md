# SwitchExpressionBug

## Visual Studio 2019 Preview 3.1/4.0

```
1>------ Rebuild All started: Project: SwitchExpressionBug, Configuration: Debug Any CPU ------
1>You are using a preview version of .NET. See: https://aka.ms/dotnet-core-preview
1>C:\Program Files (x86)\Microsoft Visual Studio\2019\Preview\MSBuild\Current\Bin\Roslyn\Microsoft.CSharp.Core.targets(59,5): error MSB6006: "csc.exe" exited with code -2146232797.
1>Done building project "SwitchExpressionBug.csproj" -- FAILED.
========== Rebuild All: 0 succeeded, 1 failed, 0 skipped ==========
```

## .NET Core SDK 5.0.100-preview.6.20318.15

```
$ dotnet build
Microsoft (R) Build Engine version 16.7.0-preview-20310-07+ee1c9fd0c for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  All projects are up-to-date for restore.
  You are using a preview version of .NET. See: https://aka.ms/dotnet-core-preview
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error : Process terminated. System.NullReferenceException: Object reference not set to an instance of an object. [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock.ShortenBranches(Int32& delta) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.ComputeOffsetsAndAdjustBranches() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.RealizeBlocks() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.Realize() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.GenerateImpl() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.GenerateMethodBody(PEModuleBuilder moduleBuilder, MethodSymbol method, Int32 methodOrdinal, BoundStatement block, ImmutableArray`1 lambdaDebugInfo, ImmutableArray`1 closureDebugInfo, StateMachineTypeSymbol stateMachineTypeOpt, VariableSlotAllocator variableSlotAllocatorOpt, DiagnosticBag diagnostics, DebugDocumentProvider debugDocumentProvider, ImportChain importChainOpt, Boolean emittingPdb, Boolean emitTestCoverageData, ImmutableArray`1 dynamicAnalysisSpans, AsyncForwardEntryPoint entryPointOpt) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.CompileMethod(MethodSymbol methodSymbol, Int32 methodOrdinal, ProcessedFieldInitializers& processedInitializers, SynthesizedSubmissionFields previousSubmissionFields, TypeCompilationState compilationState) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.CompileNamedType(NamedTypeSymbol containingType) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.<>c__DisplayClass22_0.<CompileNamedTypeAsync>b__0() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Environment.FailFast(System.String, System.Exception) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.FailFast.OnFatalException(System.Exception) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.FatalError.Report(System.Exception, System.Action`1<System.Exception>) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.FatalError.ReportUnlessCanceled(System.Exception) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler+<>c__DisplayClass22_0.<CompileNamedTypeAsync>b__0() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder+BasicBlock.ShortenBranches(Int32 ByRef) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.ComputeOffsetsAndAdjustBranches() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.RealizeBlocks() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.Realize() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.GenerateImpl() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.GenerateMethodBody(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Int32, Microsoft.CodeAnalysis.CSharp.BoundStatement, System.Collections.Immutable.ImmutableArray`1<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>, System.Collections.Immutable.ImmutableArray`1<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>, Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator, Microsoft.CodeAnalysis.DiagnosticBag, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider, Microsoft.CodeAnalysis.CSharp.ImportChain, Boolean, Boolean, System.Collections.Immutable.ImmutableArray`1<Microsoft.CodeAnalysis.CodeGen.SourceSpan>, AsyncForwardEntryPoint) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.CompileMethod(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Int32, ProcessedFieldInitializers ByRef, Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields, Microsoft.CodeAnalysis.CSharp.TypeCompilationState) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.CompileNamedType(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler+<>c__DisplayClass22_0.<CompileNamedTypeAsync>b__0() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Roslyn.Utilities.UICultureUtilities+<>c__DisplayClass5_0.<WithCurrentUICulture>b__0() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Threading.Tasks.Task.InnerInvoke() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Threading.Tasks.Task+<>c.<.cctor>b__276_0(System.Object) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Threading.ExecutionContext.RunFromThreadPoolDispatchLoop(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Threading.Tasks.Task.ExecuteWithThreadLocal(System.Threading.Tasks.Task ByRef, System.Threading.Thread) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Threading.Tasks.Task.ExecuteEntryUnsafe(System.Threading.Thread) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Threading.Tasks.Task.ExecuteFromThreadPool(System.Threading.Thread) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Threading.ThreadPoolWorkQueue.Dispatch() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Threading._ThreadPoolWaitCallback.PerformWaitCallback() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error : System.NullReferenceException: Object reference not set to an instance of an object. [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock.ShortenBranches(Int32& delta) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.ComputeOffsetsAndAdjustBranches() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.RealizeBlocks() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.Realize() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.GenerateImpl() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.GenerateMethodBody(PEModuleBuilder moduleBuilder, MethodSymbol method, Int32 methodOrdinal, BoundStatement block, ImmutableArray`1 lambdaDebugInfo, ImmutableArray`1 closureDebugInfo, StateMachineTypeSymbol stateMachineTypeOpt, VariableSlotAllocator variableSlotAllocatorOpt, DiagnosticBag diagnostics, DebugDocumentProvider debugDocumentProvider, ImportChain importChainOpt, Boolean emittingPdb, Boolean emitTestCoverageData, ImmutableArray`1 dynamicAnalysisSpans, AsyncForwardEntryPoint entryPointOpt) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.CompileMethod(MethodSymbol methodSymbol, Int32 methodOrdinal, ProcessedFieldInitializers& processedInitializers, SynthesizedSubmissionFields previousSubmissionFields, TypeCompilationState compilationState) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.CompileNamedType(NamedTypeSymbol containingType) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.<>c__DisplayClass22_0.<CompileNamedTypeAsync>b__0() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]

Build FAILED.

C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error : Process terminated. System.NullReferenceException: Object reference not set to an instance of an object. [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock.ShortenBranches(Int32& delta) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.ComputeOffsetsAndAdjustBranches() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.RealizeBlocks() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.Realize() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.GenerateImpl() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.GenerateMethodBody(PEModuleBuilder moduleBuilder, MethodSymbol method, Int32 methodOrdinal, BoundStatement block, ImmutableArray`1 lambdaDebugInfo, ImmutableArray`1 closureDebugInfo, StateMachineTypeSymbol stateMachineTypeOpt, VariableSlotAllocator variableSlotAllocatorOpt, DiagnosticBag diagnostics, DebugDocumentProvider debugDocumentProvider, ImportChain importChainOpt, Boolean emittingPdb, Boolean emitTestCoverageData, ImmutableArray`1 dynamicAnalysisSpans, AsyncForwardEntryPoint entryPointOpt) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.CompileMethod(MethodSymbol methodSymbol, Int32 methodOrdinal, ProcessedFieldInitializers& processedInitializers, SynthesizedSubmissionFields previousSubmissionFields, TypeCompilationState compilationState) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.CompileNamedType(NamedTypeSymbol containingType) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.<>c__DisplayClass22_0.<CompileNamedTypeAsync>b__0() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Environment.FailFast(System.String, System.Exception) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.FailFast.OnFatalException(System.Exception) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.FatalError.Report(System.Exception, System.Action`1<System.Exception>) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.FatalError.ReportUnlessCanceled(System.Exception) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler+<>c__DisplayClass22_0.<CompileNamedTypeAsync>b__0() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder+BasicBlock.ShortenBranches(Int32 ByRef) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.ComputeOffsetsAndAdjustBranches() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.RealizeBlocks() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.Realize() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.GenerateImpl() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.GenerateMethodBody(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Int32, Microsoft.CodeAnalysis.CSharp.BoundStatement, System.Collections.Immutable.ImmutableArray`1<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>, System.Collections.Immutable.ImmutableArray`1<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>, Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator, Microsoft.CodeAnalysis.DiagnosticBag, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider, Microsoft.CodeAnalysis.CSharp.ImportChain, Boolean, Boolean, System.Collections.Immutable.ImmutableArray`1<Microsoft.CodeAnalysis.CodeGen.SourceSpan>, AsyncForwardEntryPoint) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.CompileMethod(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Int32, ProcessedFieldInitializers ByRef, Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields, Microsoft.CodeAnalysis.CSharp.TypeCompilationState) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.CompileNamedType(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler+<>c__DisplayClass22_0.<CompileNamedTypeAsync>b__0() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Roslyn.Utilities.UICultureUtilities+<>c__DisplayClass5_0.<WithCurrentUICulture>b__0() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Threading.Tasks.Task.InnerInvoke() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Threading.Tasks.Task+<>c.<.cctor>b__276_0(System.Object) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Threading.ExecutionContext.RunFromThreadPoolDispatchLoop(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Threading.Tasks.Task.ExecuteWithThreadLocal(System.Threading.Tasks.Task ByRef, System.Threading.Thread) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Threading.Tasks.Task.ExecuteEntryUnsafe(System.Threading.Thread) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Threading.Tasks.Task.ExecuteFromThreadPool(System.Threading.Thread) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Threading.ThreadPoolWorkQueue.Dispatch() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at System.Threading._ThreadPoolWaitCallback.PerformWaitCallback() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error : System.NullReferenceException: Object reference not set to an instance of an object. [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock.ShortenBranches(Int32& delta) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.ComputeOffsetsAndAdjustBranches() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.RealizeBlocks() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CodeGen.ILBuilder.Realize() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.GenerateImpl() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.GenerateMethodBody(PEModuleBuilder moduleBuilder, MethodSymbol method, Int32 methodOrdinal, BoundStatement block, ImmutableArray`1 lambdaDebugInfo, ImmutableArray`1 closureDebugInfo, StateMachineTypeSymbol stateMachineTypeOpt, VariableSlotAllocator variableSlotAllocatorOpt, DiagnosticBag diagnostics, DebugDocumentProvider debugDocumentProvider, ImportChain importChainOpt, Boolean emittingPdb, Boolean emitTestCoverageData, ImmutableArray`1 dynamicAnalysisSpans, AsyncForwardEntryPoint entryPointOpt) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.CompileMethod(MethodSymbol methodSymbol, Int32 methodOrdinal, ProcessedFieldInitializers& processedInitializers, SynthesizedSubmissionFields previousSubmissionFields, TypeCompilationState compilationState) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.CompileNamedType(NamedTypeSymbol containingType) [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
C:\Program Files\dotnet\sdk\5.0.100-preview.6.20318.15\Roslyn\Microsoft.CSharp.Core.targets(59,5): error :    at Microsoft.CodeAnalysis.CSharp.MethodCompiler.<>c__DisplayClass22_0.<CompileNamedTypeAsync>b__0() [C:\temp\SwitchExpressionBug\SwitchExpressionBug\SwitchExpressionBug.csproj]
    0 Warning(s)
    43 Error(s)

Time Elapsed 00:00:06.03
```
